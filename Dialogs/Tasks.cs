using DocumentAdder.Forms;
using DocumentAdder.Main;
using DocumentAdder.Models;
using DocumentAdder.Utils;
using Microsoft.EntityFrameworkCore.Storage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs;

public partial class Tasks : Form
{
    private int errors;
    private MainForm Forms;
    private PersonInfo _personInfo;
    private List<ClientDoc> docs;
    private IDbContextTransaction transaction;
    public Tasks(ref int errors, MainForm form, PersonInfo personInfo, List<ClientDoc> docs, IDbContextTransaction transaction)
    {
        InitializeComponent();
        Templates();
        this.errors = errors;
        this.Forms = form;
        this._personInfo = personInfo;
        this.docs = docs;
        this.transaction = transaction;
    }

    private async void Templates()
    {
        try
        {
            var vm = new { action = "templates" };
            var request = new RestRequest("/123").AddJsonBody(vm);
            var response = await Program.client.PostAsync<List<ServerTemplate>>(request);
            if (response != null)
                if (response.Count > 0)
                    comboBox1.DataSource = response;
            comboBox1.SelectAll();
            comboBox1.Focus();
        }
        catch (Exception ee)
        {
            MessageBox.Show($"Ошибка:{ee.Message}\r\nЗадача не поставлена!");
        }
    }

    public async void Send(PersonInfo personInfo)
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
            Forms.current.Task_id = (int)comboBox1.SelectedValue;
            
            List<(int, string)> list = new List<(int, string)>();
            
            foreach (var item in this.docs) 
            {
                list.Add((item.doc, item.title));
            }
            var vm = Forms.getRequest("with_task", this.docs);
            var request = new RestRequest("/123").AddJsonBody(vm);
            var response = await Program.client.PostAsync<ServerResults>(request);

            if (response.Barcodes != null)
            {
                foreach (var barcode in response.Barcodes)
                {
                    var portfolio = Forms.current.Data.Debt.portfolio;
                    if(portfolio.Length > 0)
                    {
                    var str = list.FirstOrDefault(x => x.Item1 == barcode.doc).Item2 + '\n' + portfolio;
                    Utils.Printer.PrintBarсodeWithTitle(barcode.barcode, str);
                    }
                    else
                    {
                        var str = list.FirstOrDefault(x => x.Item1 == barcode.doc).Item2;
                        Utils.Printer.PrintBarсodeWithTitle(barcode.barcode, str);
                    }
                }
            }
        }
        catch (Exception ee)
        {
            errors += 1;
            MessageBox.Show($"Ошибка: {ee}\r\nДанные в таблицу не занесены!");
        }
        if (errors == 0)
        {
            await transaction.CommitAsync();
            MessageBox.Show("Успешно добавлено!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            await transaction.RollbackAsync();
            MessageBox.Show($"Возникли непредвиденные ошибки\r\nКол-во: {errors}\r\nВсе ошибки находятся в ErrorsSQL.txt");
        }
        Forms.ClearTextBox();
        errors = 0;
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        button2.Enabled = false;
        Send(_personInfo);
    }
}
