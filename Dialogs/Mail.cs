using DocumentAdder.Forms;
using DocumentAdder.Main;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore.Storage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs;

public partial class Mail : Form
{
    private readonly MainForm _form;
    private int errors;
    private readonly bool _task;
    private readonly List<ClientDoc> docs;
    private MailModelEnabled enabled;
    private MailModel current;
    private IDbContextTransaction transaction;

    public Mail(int mode, MainForm form, ref int errors, bool task, List<ClientDoc> docs, IDbContextTransaction transaction)
    {
        InitializeComponent();
        this.errors = errors;
        this._form = form;
        this._task = task;
        this.docs = docs;
        this.transaction = transaction;

        switch (mode)
        {
            case 2:
                {
                    enabled = new() { Cert = true, Court_date = true, Debtor = true };
                    break;
                }
            case 3:
                {
                    enabled = new() { Court_date = true, From_mail = true, To_mail = true };
                    break;
                }
            case 5:
            case 4:
                {
                    enabled = new() { Cert = true, Court_date = true };
                    break;
                }
            default:
                {
                    enabled = new() { Cert = true, Court_date = true, Debtor = true, To_mail = true, From_mail = true };
                    break;
                }
        }
        current = new();
        mailModelEnabledBinding.DataSource = enabled;

        mailModelBinding.DataSource = current;
    }

    private async void DoneBtn_Click(object sender, EventArgs e)
    {
        DoneBtn.Enabled = true;
        if (_task)
        {
            _form.newTask(errors, docs, transaction);
        }
        else
        {
            try
            {
                List<(int, string)> list = new List<(int, string)>();
                foreach (var item in this.docs)
                {
                    list.Add((item.doc, item.title));
                }


                var vm = _form.getRequest("without_task", docs: this.docs, current);
                var request = new RestRequest("/123").AddJsonBody(vm);
                var response = await Program.client.PostAsync<ServerResults>(request);

                if (response.Barcodes != null) 
                {
                    foreach (var barcode in response.Barcodes) 
                    {
                        var str = list.FirstOrDefault(x => x.Item1 == barcode.doc).Item2;
                        Utils.Printer.PrintBarсodeWithTitle(barcode.barcode, str);
                    
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
            errors = 0;
            _form.ClearTextBox();
        }
        Close();
    }
}
