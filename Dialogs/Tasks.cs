using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DocumentAdder.Utils;
using DocumentAdder.Forms;
using RestSharp;
using DocumentAdder.Main;
using DocumentAdder.Models;

namespace DocumentAdder.Dialogs
{
    public partial class Tasks : Form
    {
        private int errors;
        private MainForm Forms;
        private PersonInfo _personInfo;
        private List<ClientDoc> docs;

        public Tasks(ref int errors, MainForm form, PersonInfo personInfo, List<ClientDoc> docs)
        {
            InitializeComponent();
            Templates();
            this.errors = errors;
            this.Forms = form;
            this._personInfo = personInfo;
            this.docs = docs;
        }

        private void Templates()
        {
            try
            {
                var vm = new { token = "f3989a11-801c-458c-be04-9b4437620666", action = "templates" };
                var request = new RestRequest("/123").AddJsonBody(vm);
                var response = Program.client.Post<List<ServerTemplate>>(request);
                if (response != null)
                    if (response.Count > 0)
                        comboBox1.DataSource = response;
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
                var vm = Forms.getRequest("with_task", comboBox1.SelectedValue.ToString(), this.docs);
                var request = new RestRequest("/123").AddJsonBody(vm);
                var response = Program.client.Post<ServerResults>(request);
                if (response.Barcodes != null)
                    foreach (var barcode in response.Barcodes)
                        Utils.Printer.PrintBarCode(barcode.barcode);
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
