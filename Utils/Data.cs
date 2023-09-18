using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Forms;
using DocumentAdder.Models;
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


    public static i_collectContext Update(i_collectContext db, DataModel data, SettingsModel enabled)
    {
        if (!int.TryParse(id, out var id_int))
        {
            throw new Exception("Ошибка парса id");
        }
        var LawExec = db.LawExec.Include(x => x.LawAct).FirstOrDefault(x => x.id == id_int);
        var LawAct = db.LawAct.FirstOrDefault(x => x.id == id_int);

        if (enabled.exec_number)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.LawAct.exec_number = data.Exec_number;
            else
                LawAct.exec_number = data.Exec_number;
        }
        if (enabled.fssp_doc_num)
            LawExec.fssp_doc_num = data.Fssp_doc_num;

        if (enabled.court_doc_num)
            LawExec.court_doc_num = data.Court_doc_num;

        if (data.Typ == LawTyp.LawExec)
        {
            LawExec.dsc += "\r\n" + data.Dsc;
        }
        else
        {
            LawAct.dsc += "\r\n" + data.Dsc;
        }


        if (enabled.court_order_date)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.court_date = data.Court_order_date;
            else
                LawAct.court_order_date = data.Court_order_date;
        }

        if (enabled.court_exec_date)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.entry_force_dt = data.Court_exec_date;
            else
                LawAct.court_exec_date = data.Court_exec_date;
        }

        if (enabled.start_date)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.start_date = data.Start_date;
            else
                MessageBox.Show("Тут должно быть добавление даты возбуждения, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (enabled.finish_date == true)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.finish_date = data.Finish_date;
            else
                MessageBox.Show("Тут должно быть добавление Дата пост об окончании ИП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (enabled.receipt_date)
        {
            if (data.Typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата получения агентством, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else if (LawAct.typ == 1)
                LawAct.receipt_date = data.Receipt_date;
            else
                LawAct.receipt_dt = data.Receipt_date;
        }

        if (enabled.return_date)
            if (data.Typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата возврата, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else
                LawAct.LawActProtokols.Add(new LawActProtokol()
                {
                    typ = 72,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                    dsc = $"Дата возврата приказа: {data.Return_date?.ToShortDateString()} Комментарий: {data.Dsc}"
                });

        if (enabled.restriction_to_leave_dt)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.restriction_to_leave_dt = data.Restriction_to_leave_dt; //Дата ограничения выезда
            else
                MessageBox.Show("Тут должно быть добавление Дата ограничения выезда, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (enabled.reject_date)
        {
            if (data.Typ == LawTyp.LawExec)
                LawExec.reject_date = data.Reject_date;
            else
                MessageBox.Show("Тут должно быть добавление Дата отказа в возбуждении, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        }

        if (enabled.cancel_date)
        {
            {
                if (data.Typ == LawTyp.LawExec)
                    MessageBox.Show("Тут должно быть добавление Дата отмены СП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    LawAct.LawActProtokols.Add(new LawActProtokol()
                    {
                        r_user_id = Settings.user_id,
                        dt = DateTime.Now,
                        typ = 8,
                        dsc = $"Дата отмены приказа: {data.Cancel_date?.ToShortDateString()} Комментарий: {data.Dsc}"
                    });
            }
        }

        if (enabled.correct_period_date)
        {
            if (data.Typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата сроков исправления недостатков, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            else
                LawAct.correct_period_date = data.Correct_period_date;
        }

        if (enabled.session_date)
            if (data.Typ == LawTyp.LawExec)
                MessageBox.Show("Тут должно быть добавление Дата СЗ, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
        //   else
        // TODO: Добавить LawSession
        //sql.Add($"insert into law_session (parent_id,dt,status) values ({id}, \'{maskedTextBox11.Text}\',1)"); //Дата СЗ

        if (data.Typ == LawTyp.LawAct)
            LawAct.court_order_delivery = 2;


        if (data.Typ == LawTyp.LawAct && int_color != -1)
        {
            LawAct.int_color = int_color;
            LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 2, r_user_id = Settings.user_id, dt = DateTime.Now, dsc = $"Изменен цвет: {int_color} Пользователем: {Settings.username}" });
        }

        if (Settings.dateId)
        {
            if (data.Typ == LawTyp.LawAct)
                LawAct.LawExecs.ForEach(law_exec =>
                {
                    law_exec.receipt_act_dt = DateTime.Now;
                });
            else
                LawExec.receipt_act_dt = DateTime.Now;
        }



        switch (data.Typ)
        {
            case LawTyp.LawAct:
                if (status == null)
                    break;
                GetStatus(data.Typ, LawAct, LawExec);
                LawAct.LawActProtokols.Add(new LawActProtokol()
                {
                    typ = 101,
                    r_user_id = Settings.user_id,
                    dsc = $"Изменен статус: {Settings.dicts[LawAct.typ > 1 ? 25 : 18][LawAct.typ > 1 ? LawAct.act_status.Value : LawAct.status.Value]} Пользователем: {Settings.username}"
                });
                break;
            case LawTyp.LawExec:
                if (status == null)
                    break;
                GetStatus(data.Typ, LawAct, LawExec);
                LawExec.LawExecProtokols.Add(new LawExecProtokol()
                {
                    typ = 6,
                    r_user_id = Settings.user_id,
                    dsc = $"Изменен статус: {Settings.dicts[77][LawExec.state.Value]} Пользователем: {Settings.username}"
                });
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
