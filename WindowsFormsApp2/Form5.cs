using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        private int errors;
        private Form1 Forms;
        private PersonInfo _personInfo;

        public Form5(ref int errors, Form1 form, PersonInfo personInfo)
        {
            InitializeComponent();
            Templates();
            this.errors = errors;
            this.Forms = form;
            this._personInfo = personInfo;
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

        public void Send(ref int errors, PersonInfo personInfo)
        {
            if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
                       || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
                       || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
                       || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу"))
            {
                try
                {
                    var (error, message) = VTBAdder.CreateExcel();
                    if (error)
                    {
                        MessageBox.Show(this, message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        VTBAdder.Add(personInfo);
                }
                catch
                {
                    MessageBox.Show(this, "Строчка не добавлена, скорее всего открыт Excel файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //if (comboBox1.Text.Contains("Дубликат судебного приказа (СП) в НАШУ пользу")
            //        || comboBox1.Text.Contains("Судебный приказ (СП) в НАШУ пользу")
            //        || comboBox1.Text.Contains("ИЛ в НАШУ пользу")
            //        || comboBox1.Text.Contains("Дубликат ИЛ в НАШУ пользу"))
            //{
            //    bool r = Forms.SberAdder();
            //    if (!r)
            //    {
            //        errors += 1;
            //        MessageBox.Show("Файл для Сбербанка не создан");
            //    }
            //}
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
            Forms.ClearTextBox();
            errors = 0;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send(ref errors, _personInfo);
        }
    }
}
