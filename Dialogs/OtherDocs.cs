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
    private OtherDocModel current;
    public OtherDocs(DataModel current)
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
        this.current = new(current);
        otherDocModelBinding.DataSource = this.current;
        otherDocModelEnabledBinding.DataSource = new OtherDocModelEnabled() { Fio = true, Portfolio = true, User_task = true, From_mail = current.Mode == 3 ? true : false, To_mail = current.Mode == 3 ? true : false };

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
        button3.Enabled = false;
        try
        {
            var vm = new
            {
                action = "without_task",
                date_post = current.data.Date_post.ToString("o").Replace("+03:00", ""),
                Convert = current.data.Check,
                adr_otp = current.data.Post_address,
                otprav = current.data.Post_name,
                reestr = current.Portfolio,
                doc_name = current.data.Document_name,
                gd = current.data.Exec_number,
                fio_dol = current.Fio,
                ispol_zadach = current.User_task,
                kto_obrabotal = $"{Settings.username}",
                id_kto_obrabotal = Settings.user_id,
                nal_skan = current.data.Scan,
                mode = current.data.Mode,
                adres = current.From_mail,
                mail = current.To_mail,
                have_kd = current.data.Have_kd,
                scan_copy_kd = current.data.Scan_copy_kd,
                return_reason = current.data.Return_reason,
            };
            var request = new RestRequest("/123").AddJsonBody(vm);
            var response = Program.client.Post<ServerResults>(request);
            if (response.Barcodes != null) {
                foreach (var barcode in response.Barcodes)
                {

                    var str = $"Док: " + vm.doc_name + '\n' + vm.reestr;
                    Utils.Printer.PrintBarсodeWithTitle(barcode.barcode, str);

                }            
            }
            MessageBox.Show("Данные в таблицу занесены");
        }
        catch (Exception ee)
        {
            MessageBox.Show($"Ошибка:{ee}\r\nДанные в таблицу не занесены!");
        }
        Close();
    }
}
