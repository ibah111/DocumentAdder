using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data.Odbc;
using System.IO;
using System.Windows.Forms;
using DocumentAdder.Utils;
using DocumentAdder.Main;

namespace DocumentAdder.Forms
{
    public partial class LoginForm : Form
    {
        static string LoginPath = "/login.json";
        static public LogedData logedData;
        Timer timer = new Timer();
        LoginData loginData;
        Server server;
        RestClient client = Program.client;

        public LoginForm()
        {
            timer.Interval = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;
            timer.Tick += (object sender, EventArgs e) => CheckLogin();
            InitializeComponent();
            InitData();
        }
        public delegate void CallEvent();
        public event CallEvent OnLoged;
        public event CallEvent OnNotLoged;
        public void CheckLogin()
        {
            if (CheckToken())
            {
                if (GetLoginContact())
                {
                    Hide();
                    if (!timer.Enabled) timer.Start();
                    OnLoged?.Invoke();
                }
                else
                {
                    OnNotLoged?.Invoke();
                    if (timer.Enabled) timer.Stop();
                    MessageBox.Show("Вы не найдены в контакте");
                }
            }
            else
            {
                OnNotLoged?.Invoke();
                if (timer.Enabled) timer.Stop();
                if (Visible)
                {
                    MessageBox.Show("Произошла ошибка при авторизации, попробуйте еще раз");
                }
                Show();
            }
        }
        public bool GetLoginContact()
        {
            string queryString = $"select id from users where email = \'{LoginForm.logedData.login}\'";
            OdbcCommand command = new OdbcCommand(queryString);
            command.Connection = Program.Conn;
            using (OdbcDataReader reader = command.ExecuteReader())
                while (reader.Read())
                    Settings.user_id = reader.GetInt32(0);
            string[] names = { logedData.firstname, logedData.secondname, logedData.thirdname };
            Settings.username = Addons.GetName(names);
            if (Settings.user_id == 0)
                return false;
            return true;
        }
        private bool CheckToken()
        {
            var request = new RestRequest("/login");
            request.AddJsonBody(loginData);
            try
            {
                var response = client.Post<LogedData>(request);
                if (response.login_result)
                    logedData = response;
                return response.login_result;
            }
            catch
            {
                return false;
            }

        }

        private void InitData()
        {
            if (File.Exists(Environment.CurrentDirectory + LoginPath))
            {
                loginData = JsonConvert.DeserializeObject<LoginData>(File.ReadAllText(Environment.CurrentDirectory + LoginPath));
            }
            else
            {
                loginData = new LoginData();
            }
            server = new Server();
            server.OnGetToken += (string token) =>
            {
                loginData.token = token;
                File.WriteAllText(Environment.CurrentDirectory + LoginPath, JsonConvert.SerializeObject(loginData));
                CheckLogin();
            };
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{Settings.server_login}/apps/mail/login.php");
            server.Start();
        }
    }

    class LoginData
    {
        public string token;
    }
    public class LogedData
    {
        public string output;
        public string error;
        public int id;
        public string login;
        public bool login_result;
        public string birthdate;
        public string department;
        public string position;
        public string firstname;
        public string secondname;
        public string thirdname;
    }
}
