using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Utils
{
    class Data
    {
        private static string _vkl_string;
        private static int _status;
        private static int _vkl_int;
        private static string _id;
        private static string _status_text;
        public static int int_color;

        public static string vkl_string { get { return vkl_string; } set { _vkl_string = value; } }
        public static int status { get { return _status; } set { _status = value; } }
        public static int vkl_int { get { return _vkl_int; } set { _vkl_int = value; } }
        public static string id { get { return _id; } set { _id = value; } }
        public static string status_text { get { return _status_text; } set { _status_text = value; } }


        public static i_collectContext Update(i_collectContext db, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox11, MaskedTextBox maskedTextBox1, MaskedTextBox maskedTextBox2, MaskedTextBox maskedTextBox3, MaskedTextBox maskedTextBox4, MaskedTextBox maskedTextBox5, MaskedTextBox maskedTextBox6, MaskedTextBox maskedTextBox7, MaskedTextBox maskedTextBox8, MaskedTextBox maskedTextBox9, MaskedTextBox maskedTextBox10, MaskedTextBox maskedTextBox11, TextBox textBox23, string text)
        {
            if (!int.TryParse(id, out var id_int))
            {
                throw new Exception("Ошибка парса id");
            }
            var LawExec = db.LawExec.Include(x => x.LawAct).FirstOrDefault(x => x.id == id_int);
            var LawAct = db.LawAct.FirstOrDefault(x => x.id == id_int);

            if (textBox8.Enabled == true)
            {
                if (vkl_int == 4)
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
                if (vkl_int < 4)
                {
                    if (!decimal.TryParse(textBox23.Text, out var total_sum))
                        throw new Exception("Ошибка получения суммы");
                    LawAct.total_sum = total_sum;
                }
            }

            if (textBox11.Enabled == true)
            {
                if (vkl_int == 4)
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
                if (vkl_int == 4)
                    LawExec.court_date = court_date;
                else
                    LawAct.court_order_date = court_date;
            }

            if (maskedTextBox2.Enabled == true)
            {
                if (!DateTime.TryParse(maskedTextBox1.Text, out var exec_date)) throw new Exception("Ошибка даты вступления в силу");
                if (vkl_int == 4)
                    LawExec.entry_force_dt = exec_date;
                else
                    LawAct.court_exec_date = exec_date;
            }

            if (maskedTextBox3.Enabled == true)
            {
                if (!DateTime.TryParse(maskedTextBox3.Text, out var start_date))
                    throw new Exception("Ошибка дата возбуждения");
                if (vkl_int == 4)
                    LawExec.start_date = start_date;
                else
                    MessageBox.Show("Тут должно быть добавление даты возбуждения, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            }

            if (maskedTextBox4.Enabled == true)
            {
                if (!DateTime.TryParse(maskedTextBox4.Text, out var complete_date))
                    throw new Exception("Ошибка дата окончания");
                if (vkl_int == 4)
                    LawExec.complete_date = complete_date;
                else
                    MessageBox.Show("Тут должно быть добавление Дата пост об окончании ИП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            }

            if (maskedTextBox5.Enabled == true)
            {
                if (!DateTime.TryParse(maskedTextBox5.Text, out var receipt_date))
                    throw new Exception("Ошибка дата получения агенством");
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата получения агентством, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else if (vkl_int == 0)
                    LawAct.receipt_date = receipt_date;
                else
                    LawAct.receipt_dt = receipt_date;
            }

            if (maskedTextBox6.Enabled == true)
                if (vkl_int == 4)
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
                if (vkl_int == 4)
                    LawExec.restriction_to_leave_dt = restriction_to_leave_dt; //Дата ограничения выезда
                else
                    MessageBox.Show("Тут должно быть добавление Дата ограничения выезда, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            }

            if (maskedTextBox8.Enabled == true)
            {
                if (!DateTime.TryParse(maskedTextBox8.Text, out var reject_date))
                    throw new Exception("Ошибка Дата отказа в возбуждении");
                if (vkl_int == 4)
                    LawExec.reject_date = reject_date;
                else
                    MessageBox.Show("Тут должно быть добавление Дата отказа в возбуждении, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
            }

            if (maskedTextBox9.Enabled == true)
            {
                {
                    if (vkl_int == 4)
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
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата сроков исправления недостатков, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    LawAct.correct_period_date = correct_period_date;
            }

            if (maskedTextBox11.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата СЗ, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
            // TODO: Добавить LawSession
            //sql.Add($"insert into law_session (parent_id,dt,status) values ({id}, \'{maskedTextBox11.Text}\',1)"); //Дата СЗ

            if (vkl_int != 4)
                    LawAct.court_order_delivery = 2;


            if (vkl_int != 4 && int_color != -1)
            {
                LawAct.int_color = int_color;
                LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 2, r_user_id = Settings.user_id, dt = DateTime.Now, dsc = $"Изменен цвет: {int_color} Пользователем: {Settings.username}" });
            }

            if (Settings.dateId)
            {
                if (vkl_int != 4)
                    LawAct.LawExecs.ForEach(law_exec =>
                    {
                        law_exec.receipt_act_dt = DateTime.Now;
                    });
                else
                    LawExec.receipt_act_dt = DateTime.Now;
            }



            switch (vkl_int)
            {
                case 0:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(LawAct, LawExec);
                    LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 101, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                    break;
                case 1:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(LawAct, LawExec);
                    LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 101, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                    break;
                case 2:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(LawAct, LawExec);
                    LawAct.LawActProtokols.Add(new LawActProtokol() { typ = 101, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                    break;
                case 3:
                    break;
                case 4:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(LawAct, LawExec);
                    LawExec.LawExecProtokols.Add(new LawExecProtokol() { typ = 6, r_user_id = Settings.user_id, dsc = $"Изменен статус: {text} Пользователем: {Settings.username}" });
                    break;
            }
            return db;
        }

        private static void GetStatus(LawAct LawAct, LawExec LawExec)
        {
            if (status_text == "Без статуса")
                return;
            switch (vkl_int)
            {
                case 0:
                    foreach (KeyValuePair<int, string> prikaz in Settings.status[0])
                        if (prikaz.Value == status_text)
                            LawAct.status = prikaz.Key;
                    break;
                case 1:
                    foreach (KeyValuePair<int, string> isk in Settings.status[1])
                        if (isk.Value == status_text)
                            LawAct.act_status = isk.Key;
                    break;
                case 2:
                    foreach (KeyValuePair<int, string> pravo in Settings.status[1])
                        if (pravo.Value == status_text)
                            LawAct.status = pravo.Key;
                    break;
                case 3:
                    break;
                case 4:
                    foreach (KeyValuePair<int, string> ispol in Settings.status[2])
                        if (ispol.Value == status_text)
                            LawExec.state = ispol.Key;
                    break;
            }
        }
    }

}
