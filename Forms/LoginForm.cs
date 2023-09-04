using DatabaseContact.DatabaseContact;
using DocumentAdder.Main;
using DocumentAdder.Utils;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAdder.Forms
{
    public class BitrixAuthenticator : IAuthenticator
    {
        private string token;
        public BitrixAuthenticator(string token = null)
        {
            this.token = token;
        }
        public void useToken(string token)
        {
            this.token = token;
        }
        public ValueTask Authenticate(IRestClient client, RestRequest request)
        {
            if (token != null)
                request.AddHeader("token", token);
            return new ValueTask();
        }
    }
    public partial class LoginForm : Form
    {
        static string LoginPath = "/login.json";
        static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/DocumentAdder";
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
                    MessageBox.Show("Вы не найдены в контакте. Обратитесь в IT-Отдел.");
                }
            }
            else
            {
                if (Visible)
                {
                    MessageBox.Show("Произошла ошибка при авторизации, попробуйте еще раз");
                }
                Show();

            }
        }
        public bool GetLoginContact()
        {
            using var db = Program.factory_db.CreateDbContext();
            Settings.user_id = db.User.Where(x => x.email == logedData.login).Select(x => x.id).FirstOrDefault();
            string[] names = { logedData.firstname, logedData.secondname, logedData.thirdname };
            Settings.username = Addons.GetName(names);
            if (Settings.user_id == 0)
                return false;
            return true;
        }
        private bool CheckToken()
        {
            var request = new RestRequest("/login");
            if (client.Options.Authenticator is BitrixAuthenticator auth)
            {
                auth.useToken(loginData.token);
            }
            try
            {
                var response = client.Post<LogedData>(request);
                if (response.login_result)
                    logedData = response;
                Program.factory_db = new(Program.getOptionsSql<i_collectContext>(logedData.database));
                return response.login_result;
            }
            catch
            {
                return false;
            }

        }

        private void InitData()
        {
            if (!Directory.Exists(appdata))
            {
                Directory.CreateDirectory(appdata);
            }
            if (File.Exists(appdata + LoginPath))
            {
                loginData = JsonConvert.DeserializeObject<LoginData>(File.ReadAllText(appdata + LoginPath));
            }
            else
            {
                loginData = new LoginData();
            }
            server = new Server();
            server.OnGetToken += (string token) =>
            {
                loginData.token = token;
                File.WriteAllText(appdata + LoginPath, JsonConvert.SerializeObject(loginData));
                CheckLogin();
            };
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"{Settings.server_login}/oauth") { UseShellExecute = true });
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
        public string database = Settings.dbs;
    }
}
