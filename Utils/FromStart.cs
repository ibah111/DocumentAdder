using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace DocumentAdder.Utils
{
    internal class FromStart
    {
        internal static string DownloadInfo()
        {
            GetUserDB();
            GetStatus();
            return GetUser();
        }

        public static string GetUser()
        {
            return $"Входящая почта. Документооборот. Пользователь: {Settings.username} [{Settings.user_id}]";
        }

        internal static void GetStatus()
        {
            int count = 0;
            int[] li = new int[] { 18, 25, 77 }; // Приказ Иск/Правопреемство Испол
            Settings.status = new Dictionary<int, Dictionary<int, string>>();
            foreach (int a in li)
            {
                OdbcCommand command = new OdbcCommand($"select code,name from dict where parent_id={a}");
                command.Connection = Program.Conn;
                command.ExecuteNonQuery();
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    Settings.status.Add(count, new Dictionary<int, string>());
                    while (reader.Read())
                    {
                        Settings.status[count].Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
                count++;
            }
        }

        internal static void GetUserDB()
        {
            string queryString = "select id,f,i from users where i != null or i != ''";
            OdbcCommand command = new OdbcCommand(queryString);
            command.Connection = Program.Conn;
            command.ExecuteNonQuery();
            Settings.users = new Dictionary<int, string>();
            using (OdbcDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Settings.users.Add(Convert.ToInt32(reader[0]), $"{reader[1]} {reader[2]}");
                    }
                }
            }
        }
    }
}