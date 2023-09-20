﻿using DocumentAdder.Forms;
using DocumentAdder.Main;
using DocumentAdder.Models;
using RestSharp;
using System;
using System.Collections.Generic;
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

    public Mail(int mode, MainForm form, ref int errors, bool task, List<ClientDoc> docs)
    {
        InitializeComponent();
        this.errors = errors;
        this._form = form;
        this._task = task;
        this.docs = docs;

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
                    IstCB.Enabled = false;
                    ECPCB.Enabled = false;
                    break;
                }
            case 5:
            case 4:
                {
                    enabled = new() { Cert = true, Court_date = true };
                    IstCB.Enabled = false;
                    ECPCB.Enabled = false;
                    MailTB.Enabled = false;
                    break;
                }
            default:
                {
                    enabled = new() { Cert = true, Court_date = true, Debtor = true, To_mail = true, From_mail = true };
                    break;
                }
        }
        current = new();
    }

    private void DoneBtn_Click(object sender, EventArgs e)
    {
        if (_task)
        {
            _form.newTask(errors, docs);
        }
        else
        {
            try
            {
                var vm = _form.getRequest("without_task", docs: this.docs, current);
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
            errors = 0;
            _form.ClearTextBox();
        }
        Close();
    }
}
