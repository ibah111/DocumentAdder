using DocumentAdder.Main;
using DocumentAdder.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs;

public partial class OtherDocs : Form
{
    private static string path_to_list_otvet = Environment.CurrentDirectory + "\\Список_Для_Ответственного(Вне_реестра).txt";
    private static string path_to_list_FIO = Environment.CurrentDirectory + "\\Список_Для_ФИО(Должник_Вне_Реестра).txt";
    public int mode = 1;
    private string to_mail_text = "";
    private string who_mail_text = "";
    public OtherDocs(int mode)
    {
        this.mode = mode;
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
            var vm = new { action = "without_task", date_post = DateTime.Parse(Settings.date_post), Convert = Settings.conv, adr_otp = Settings.adr_otp, otprav = Settings.otprav, reestr = textBox1.Text, doc_name = Settings.doc_name, gd = textBox2.Text, fio_dol = comboBox2.Text, ispol_zadach = comboBox1.Text, kto_obrabotal = $"{Settings.username}", id_kto_obrabotal = $"{Settings.user_id}", nal_skan = Settings.nal_skan, mode = mode, adres = to_mail_text, mail = who_mail_text };
            var request = new RestRequest("/123").AddJsonBody(vm);
            var response = Program.client.Post<ServerResults>(request);
            if (response.Barcodes != null)
                foreach (var barcode in response.Barcodes)
                    Utils.Printer.PrintBarCode(barcode.barcode);
            MessageBox.Show("Данные в таблицу занесены");
        }
        catch (Exception ee)
        {
            MessageBox.Show($"Ошибка:{ee}\r\nДанные в таблицу не занесены!");
        }
        Close();
    }

    private void OtherDocs_Load(object sender, EventArgs e)
    {
        if (mode == 3)
        {
            to_mail.Enabled = true;
            who_mail.Enabled = true;
        }
        else
        {
            to_mail.Enabled = false;
            who_mail.Enabled = false;
        }
    }

    private void to_mail_TextChanged(object sender, EventArgs e)
    {
        to_mail_text = to_mail.Text;
    }

    private void who_mail_TextChanged(object sender, EventArgs e)
    {
        who_mail_text = who_mail.Text;
    }
}
