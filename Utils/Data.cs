using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Utils
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


        public static List<string> Update(TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10, TextBox textBox11, MaskedTextBox maskedTextBox1, MaskedTextBox maskedTextBox2, MaskedTextBox maskedTextBox3, MaskedTextBox maskedTextBox4, MaskedTextBox maskedTextBox5, MaskedTextBox maskedTextBox6, MaskedTextBox maskedTextBox7, MaskedTextBox maskedTextBox8, MaskedTextBox maskedTextBox9, MaskedTextBox maskedTextBox10, MaskedTextBox maskedTextBox11, string text)
        {
            List<string> sql = new List<string>();
            sql.Clear();
            if (textBox7.Enabled == true)
                sql.Add($"update {vkl_string} set contract = \'{textBox7.Text}\' where id = {id}");

            if (textBox8.Enabled == true)
            {
                if (vkl_int == 4)
                    sql.Add($"update la set la.exec_number = \'{textBox8.Text}\' from law_act la inner join law_exec le on la.id = le.r_act_id where le.id = {id}");
                else
                    sql.Add($"update law_act set exec_number = \'{textBox8.Text}\' where id = {id}");
            }
            if (textBox9.Enabled == true)
                sql.Add($"update law_exec set fssp_doc_num = \'{textBox9.Text}\' where id = {id}");

            if (textBox10.Enabled == true)
                sql.Add($"update law_exec set court_doc_num = \'{textBox10.Text}\' where id = {id}");

            if (textBox11.Enabled == true)
            {
                if (vkl_int == 4)
                {
                    Getcomm("law_exec", id, sql, textBox11.Text);
                }
                else
                {
                    Getcomm("law_act", id, sql, textBox11.Text);
                }
            }

            if (maskedTextBox1.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set court_date = \'{maskedTextBox1.Text}\' where id = {id}");
                else
                    sql.Add($"update law_act set court_order_date = \'{maskedTextBox1.Text}\' where id = {id}");

            if (maskedTextBox2.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set entry_force_dt = \'{maskedTextBox2.Text}\' where id = {id}");
                else
                    sql.Add($"update law_act set court_exec_date = \'{maskedTextBox2.Text}\' where id = {id}");

            if (maskedTextBox3.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set start_date = \'{maskedTextBox3.Text}\' where id = {id}"); //Дата возбуждения
                else
                    MessageBox.Show("Тут должно быть добавление даты возбуждения, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");

            if (maskedTextBox4.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set complete_date = \'{maskedTextBox4.Text}\' where id = {id}"); // Дата пост об окончании ИП
                else
                    MessageBox.Show("Тут должно быть добавление Дата пост об окончании ИП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");

            if (maskedTextBox5.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата получения агентством, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else if (vkl_int == 0)
                    sql.Add($"update law_act set receipt_date = \'{maskedTextBox5.Text}\' where id = {id}"); // Дата получения агентством
                else
                    sql.Add($"update law_act set receipt_dt = \'{maskedTextBox5.Text}\' where id = {id}"); // Дата получения агентством


            if (maskedTextBox6.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата возврата, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    sql.Add($"insert into law_act_protokol (parent_id,typ,r_user_id,dt,dsc) values ({id},72,{Settings.user_id},getdate(),\'Дата возврата приказа: {maskedTextBox6.Text} Комментарий: {textBox11.Text}\')"); //Дата возврата

            if (maskedTextBox7.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set restriction_to_leave_dt = \'{maskedTextBox7.Text}\' where id = {id}"); //Дата ограничения выезда
                else
                    MessageBox.Show("Тут должно быть добавление Дата ограничения выезда, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");

            if (maskedTextBox8.Enabled == true)
                if (vkl_int == 4)
                    sql.Add($"update law_exec set reject_date = \'{maskedTextBox8.Text}\' where id = {id}"); //Дата отказа в возбуждении
                else
                    MessageBox.Show("Тут должно быть добавление Дата отказа в возбуждении, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");

            if (maskedTextBox9.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата отмены СП, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    sql.Add($"insert into law_act_protokol (parent_id, r_user_id, dt, typ,dsc) values({id},{Settings.user_id},getdate(),8,\'Дата отмены приказа: {maskedTextBox9.Text} Комментарий: {textBox11.Text}\')"); //Дата отмены СП

            if (maskedTextBox10.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата сроков исправления недостатков, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    sql.Add($"update law_act set correct_period_date = \'{maskedTextBox10.Text}\' where id = {id}"); //Дата сроков исправления недостатков

            if (maskedTextBox11.Enabled == true)
                if (vkl_int == 4)
                    MessageBox.Show("Тут должно быть добавление Дата СЗ, но я его не нашел в БД.\r\nЕсли видишь, то добавь скрин где оно находится");
                else
                    sql.Add($"insert into law_session (parent_id,dt,status) values ({id}, \'{maskedTextBox11.Text}\',1)"); //Дата СЗ

            if (vkl_int != 4)
                sql.Add($"update law_act set court_order_delivery = 2 where id = {id}");


            if (vkl_int != 4 && int_color != -1)
                sql.Add($"update law_act set int_color = {int_color} where id = {id}");

            if (Settings.dateId)
            {
                if (vkl_int != 4)
                    sql.Add($"update law_exec set receipt_act_dt = \'{DateTime.Now}\' where r_act_id = {id}");
                else
                    sql.Add($"update law_exec set receipt_act_dt = \'{DateTime.Now}\' where id = {id}");
            }



            switch (vkl_int)
            {
                case 0:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(sql);
                    sql.Add($"insert into law_act_protokol (parent_id,typ,r_user_id,dt,dsc) values ({id},101,{Settings.user_id},getdate(),\'Изменен статус: {text} Пользователем: {Settings.username}\')");
                    break;
                case 1:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(sql);
                    sql.Add($"insert into law_act_protokol (parent_id,typ,r_user_id,dt,dsc) values ({id},101,{Settings.user_id},getdate(),\'Изменен статус: {text} Пользователем: {Settings.username}\')");
                    break;
                case 2:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(sql);
                    sql.Add($"insert into law_act_protokol (parent_id,typ,r_user_id,dt,dsc) values ({id},101,{Settings.user_id},getdate(),\'Изменен статус: {text} Пользователем: {Settings.username}\')");
                    break;
                case 3:
                    break;
                case 4:
                    if (status_text == "Без статуса")
                        break;
                    GetStatus(sql);
                    sql.Add($"insert into law_exec_protokol (parent_id,typ,r_user_id,dt,dsc) values ({id},6,{Settings.user_id},getdate(),\'Изменен статус: {text} Пользователем: {Settings.username}\')");
                    break;
            }
            return sql;
        }

        private static void Getcomm(string prefix, string id, List<string> sql, string text)
        {
            if (!string.IsNullOrEmpty(id))
            {
                OdbcCommand command = new OdbcCommand($"select dsc from {prefix} where id = {id}");
                command.Connection = Program.Conn;
                command.ExecuteNonQuery();
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader[0] == DBNull.Value)
                            sql.Add($"update {prefix} set dsc = \'{DateTime.Now.ToShortDateString()} {text}\' where id = {id}");
                        else
                            sql.Add($"update {prefix} set dsc = dsc + CHAR(13) + \'{DateTime.Now.ToShortDateString()} {text}\' where id = {id}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Должник не выбран!");
            }
        }

        private static void GetStatus(List<string> sql)
        {
            if (status_text == "Без статуса")
                return;
            switch (vkl_int)
            {
                case 0:
                    foreach (KeyValuePair<int, string> prikaz in Settings.status[0])
                        if (prikaz.Value == status_text)
                            sql.Add($"update law_act set status = {prikaz.Key} where id = {id}");
                    break;
                case 1:
                    foreach (KeyValuePair<int, string> isk in Settings.status[1])
                        if (isk.Value == status_text)
                            sql.Add($"update law_act set act_status = {isk.Key} where id = {id}");
                    break;
                case 2:
                    foreach (KeyValuePair<int, string> pravo in Settings.status[1])
                        if (pravo.Value == status_text)
                            sql.Add($"update law_act set act_status = {pravo.Key} where id = {id}");
                    break;
                case 3:
                    break;
                case 4:
                    foreach (KeyValuePair<int, string> ispol in Settings.status[2])
                        if (ispol.Value == status_text)
                            sql.Add($"update law_exec set state = {ispol.Key} where id = {id}"); ;
                    break;
            }
        }
    }
}
