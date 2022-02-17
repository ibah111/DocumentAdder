using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        private static string path_to_list_otvet = Environment.CurrentDirectory + "\\Список_Для_Ответственного(Вне_реестра).txt";
        private static string path_to_list_FIO = Environment.CurrentDirectory + "\\Список_Для_ФИО(Должник_Вне_Реестра).txt";
        public Form4()
        {
            InitializeComponent();
            if (File.Exists(path_to_list_otvet))
            {
                List<string> spis = File.ReadLines(path_to_list_otvet).ToList();
                comboBox1.DataSource = spis;
            }
            else
                File.CreateText(path_to_list_otvet);
            if (File.Exists(path_to_list_FIO))
            {
                List<string> spis1 = File.ReadLines(path_to_list_FIO).ToList();
                comboBox2.DataSource = spis1;
            }
            else
                File.CreateText(path_to_list_FIO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboBox2.Text == " ") || (comboBox2.Text == ""))
                MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
            else
            {
                StreamWriter sw = new StreamWriter(path_to_list_FIO, true);
                sw.WriteLine($"{comboBox2.Text}");
                sw.Close();
                List<string> spis = File.ReadLines(path_to_list_FIO).ToList();
                comboBox2.DataSource = spis;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == " ") || (comboBox1.Text == ""))
                MessageBox.Show("При добавлении возникли ошибки, скорее всего, поле не заполнено");
            else
            {
                StreamWriter sw = new StreamWriter(path_to_list_otvet, true);
                sw.WriteLine($"{comboBox1.Text}");
                sw.Close();
                List<string> spis1 = File.ReadLines(path_to_list_otvet).ToList();
                comboBox1.DataSource = spis1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
                var vm = new { token = "f3989a11-801c-458c-be04-9b4437620666", action = "without_task", date_post = DateTime.Parse(Settings.date_post), Convert = Settings.conv, adr_otp = Settings.adr_otp, otprav = Settings.otprav, reestr = textBox1.Text, doc_name = Settings.doc_name, gd = textBox2.Text, fio_dol = comboBox2.Text, ispol_zadach = comboBox1.Text, kto_obrabotal = $"{Settings.username}", id_kto_obrabotal = $"{Settings.user_id}", nal_skan = Settings.nal_skan };
                var dataString = JsonConvert.SerializeObject(vm);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var response = client.UploadString(new Uri($"https://{Settings.domain}:3001/123"), "POST", dataString);
                MessageBox.Show("Данные в таблицу занесены");
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Ошибка:{ee}\r\nДанные в таблицу не занесены!");
            }
        }
    }
}
