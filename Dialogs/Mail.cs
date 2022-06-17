using DocumentAdder.Forms;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs
{
    public partial class Mail : Form
    {
        private MainForm _form;
        private int errors;
        private bool _task;

        public Mail(int mode, MainForm form, ref int errors, bool task)
        {
            InitializeComponent();
            this.errors = errors;
            this._form = form;
            this._task = task;
            switch (mode)
            {
                case 2:
                    {
                        AdrTB.Enabled = false;
                        MailTB.Enabled = false;
                        IstCB.Text = Settings.ist;
                        ECPCB.Text = Settings.ecp;
                        break;
                    }
                case 3:
                    {
                        IstCB.Enabled = false;
                        ECPCB.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        IstCB.Enabled = false;
                        ECPCB.Enabled = false;
                        MailTB.Enabled = false;
                        break;
                    }
            }
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Settings.ist = IstCB.Text;
            Settings.dateDoc = DateDocMB.Text;
            Settings.ecp = ECPCB.Text;
            Settings.adres = AdrTB.Text;
            Settings.mail = MailTB.Text;
            if (_task)
            {
                _form.newTask(errors);
            }
            else
            {
                try
                {
                    WebClient client = new WebClient() { Encoding = Encoding.UTF8 };
                    var vm = _form.getRequest("without_task");
                    var dataString = JsonConvert.SerializeObject(vm);
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    client.UploadString(new Uri($"{Settings.server}/123"), "POST", dataString);
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
                _form.ClearTextBox();
            }
            Close();
        }
    }
}
