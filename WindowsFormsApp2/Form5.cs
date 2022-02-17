using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        private int errors;
        private Form1 Forms;

        public Form5(ref int errors, Form1 form)
        {
            InitializeComponent();
            Templates();
            this.errors = errors;
            this.Forms = form;
        }

        private void Templates()
        {
            try
            {
                WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
                var vm = new { token = "f3989a11-801c-458c-be04-9b4437620666", action = "templates" };
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var response = client.UploadString(new Uri($"https://{Settings.domain}:3001/123"), "POST", dataString);
                List<Template> responseString = JsonConvert.DeserializeObject<List<Template>>(response);
                if (responseString != null)
                    if (responseString.Count > 0)
                        comboBox1.DataSource = responseString;
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Ошибка:{ee.Message}\r\nЗадача не поставлена!");
            }
        }

        public void Send(ref int errors)
        {
            try
            {
                WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
                var vm = Forms.getRequest("with_task", comboBox1.SelectedValue.ToString());
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var response = client.UploadString(new Uri($"https://{Settings.domain}:3001/123"), "POST", dataString);
            }
            catch (Exception ee)
            {
                errors += 1;
                MessageBox.Show($"Ошибка: {ee}\r\nДанные в таблицу не занесены!");
            }
            if (errors == 0)
            {
                MessageBox.Show("Успешно добавлено!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show($"Возникли непредвиденные ошибки\r\nКол-во: {errors}\r\nВсе ошибки находятся в ErrorsSQL.txt");
            errors = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send(ref errors);
            
        }
    }
}
