using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Utils;

class Data
{
    private static int? _status;
    private static string _id;
    public static int int_color;

    public static int? status { get { return _status; } set { _status = value; } }
    public static string id { get { return _id; } set { _id = value; } }


    public static i_collectContext Update(i_collectContext db, LawTyp typ, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox11, MaskedTextBox maskedTextBox1, MaskedTextBox maskedTextBox2, MaskedTextBox maskedTextBox3, MaskedTextBox maskedTextBox4, MaskedTextBox maskedTextBox5, MaskedTextBox maskedTextBox6, MaskedTextBox maskedTextBox7, MaskedTextBox maskedTextBox8, MaskedTextBox maskedTextBox9, MaskedTextBox maskedTextBox10, MaskedTextBox maskedTextBox11, TextBox textBox23, string text)
    {
        if (!int.TryParse(id, out var id_int))
        {
            throw new Exception("Ошибка парса id");
        }
        var LawExec = db.LawExec.Include(x => x.LawAct).FirstOrDefault(x => x.id == id_int);
        var LawAct = db.LawAct.FirstOrDefault(x => x.id == id_int);

        if (textBox8.Enabled == true)
        {
            if (typ == LawTyp.LawExec)
                LawExec.LawAct.exec_number = textBox8.Text;
            else
                LawAct.exec_number = textBox8.Text;
        }
        if (textBox9.Enabled == true)
            LawExec.fssp_doc_num = textBox9.Text;

        if (textBox10.Enabled == true)
            LawExec.court_doc_num = textBox10.Text;
        if (textBox23.Enabled == true)
        {
            if (typ == LawTyp.LawAct)
            {
                if (!decimal.TryParse(textBox23.Text, out var total_sum))
                    throw new Exception("Ошибка получения суммы");
                LawAct.total_sum = total_sum;
            }
        }

        if (textBox11.Enabled == true)
        {
            if (typ == LawTyp.LawExec)
            {
                LawExec.dsc += "\r\n" + textBox11.Text;
            }
            else
            {
                LawAct.dsc += "\r\n" + textBox11.Text;
            }
        }

        if (maskedTextBox1.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox1.Text, out var court_date)) throw new Exception("Ошибка даты вынесения судебного приказа");
            if (typ == LawTyp.LawExec)
                LawExec.court_date = court_date;
            else
                LawAct.court_order_date = court_date;
        }

        if (maskedTextBox2.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox1.Text, out var exec_date)) throw new Exception("Ошибка даты вступления в силу");
            if (typ == LawTyp.LawExec)
                LawExec.entry_force_dt = exec_date;
            else
                LawAct.court_exec_date = exec_date;
        }

        if (maskedTextBox3.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox3.Text, out var start_date))
                throw new Exception("Ошибка дата возбуждения");
            if (typ == LawTyp.LawExec)
                LawExec.start_date = start_date;
            else
                MessageBox.Show("Тут должно быть добавление даты возбуждения, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (maskedTextBox4.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox4.Text, out var complete_date))
                throw new Exception("Ошибка дата окончания");
            if (typ == LawTyp.LawExec)
                LawExec.complete_date = complete_date;
            else
                MessageBox.Show("Тут должно быть добавление Дата пост об окончании ИП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (maskedTextBox5.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox5.Text, out var receipt_date))
                throw new Exception("Ошибка дата получения агенством");
            if (typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата получения агентством, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else if (LawAct.typ == 1)
                LawAct.receipt_date = receipt_date;
            else
                LawAct.receipt_dt = receipt_date;
        }

        if (maskedTextBox6.Enabled == true)
            if (typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата возврата, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else
                LawAct.LawActProtokols.Add(new LawActProtokol()
                {
                    typ = 72,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                    dsc = $"Дата возврата приказа: {maskedTextBox6.Text} Комментарий: {textBox11.Text}"
                });

        if (maskedTextBox7.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox7.Text, out var restriction_to_leave_dt))
                throw new Exception("Ошибка дата ограничения выезда");
            if (typ == LawTyp.LawExec)
                LawExec.restriction_to_leave_dt = restriction_to_leave_dt; //Дата ограничения выезда
            else
                MessageBox.Show("Тут должно быть добавление Дата ограничения выезда, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (maskedTextBox8.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox8.Text, out var reject_date))
                throw new Exception("Ошибка Дата отказа в возбуждении");
            if (typ == LawTyp.LawExec)
                LawExec.reject_date = reject_date;
            else
                MessageBox.Show("Тут должно быть добавление Дата отказа в возбуждении, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (maskedTextBox9.Enabled == true)
        {
            {
                if (typ == LawTyp.LawExec)
                    MessageBox.Show("Тут должно быть добавление Дата отмены СП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    LawAct.LawActProtokols.Add(new LawActProtokol()
                    {
                        r_user_id = Settings.user_id,
                        dt = DateTime.Now,
                        typ = 8,
                        dsc = $"Дата отмены приказа: {maskedTextBox9.Text} Комментарий: {textBox11.Text}"
                    });
            }
        }

        if (maskedTextBox10.Enabled == true)
        {
            if (!DateTime.TryParse(maskedTextBox10.Text, out var correct_period_date))
                throw new Exception("Ошибка, дата сроков исправления недостатков");
            if (typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата сроков исправления недостатков, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else
                LawAct.correct_period_date = correct_period_date;
        }

        if (maskedTextBox11.Enabled == true)
            if (typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата СЗ, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else
        // TODO: Добавить LawSession
        //sql.Add($"insert into law_session (parent_id,dt,status) values ({id}, \'{maskedTextBox11.Text}\',1)"); //Дата СЗ

        if (typ == LawTyp.LawAct)
                LawAct.court_order_delivery = 2;


        if (typ == LawTyp.LawAct && int_color != -1)
        {
            LawAct.int_color = int_color;
            LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 2, r_user_id = Settings.user_id, dt = DateTime.Now, dsc = $"Изменен цвет: {int_color} Пользователем: {Settings.username}" });
        }

        if (Settings.dateId)
        {
            if (typ == LawTyp.LawAct)
                LawAct.LawExecs.ForEach(law_exec =>
                {
                    law_exec.receipt_act_dt = DateTime.Now;
                });
            else
                LawExec.receipt_act_dt = DateTime.Now;
        }



        switch (typ)
        {
            case LawTyp.LawAct:
                if (status == null)
                    break;
                GetStatus(typ, LawAct, LawExec);
                LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 101, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                break;
            case LawTyp.LawExec:
                if (status == null)
                    break;
                GetStatus(typ, LawAct, LawExec);
                LawExec.LawExecProtokols.Add(new LawExecProtokol() { typ = 6, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                break;
        }
        return db;
    }

    private static void GetStatus(LawTyp typ, LawAct LawAct, LawExec LawExec)
    {
        if (status == null)
            return;
        switch (typ)
        {
            case LawTyp.LawAct:
                if (LawAct.typ == 1)
                    LawAct.status = status;
                else LawAct.act_status = status;
                break;
            case LawTyp.LawExec:
                LawExec.state = status;
                break;
        }
    }
}
