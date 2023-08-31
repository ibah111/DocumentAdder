using DocumentAdder.Main;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

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
            using var db = Program.factory_db.CreateDbContext();
            int count = 0;
            int[] li = new int[] { 18, 25, 77 }; // Приказ Иск/Правопреемство Испол
            Settings.status = new Dictionary<int, Dictionary<int, string>>();
            var dicts = db.Dict.Where(x => li.Contains(x.parent_id)).Select(x => new { x.parent_id, x.code, x.name }).ToList();
            var groups = dicts.GroupBy(x => x.parent_id);
            foreach (var group in groups)
            {
                Settings.status.Add(count, new Dictionary<int, string>());
                foreach (var dict in group)
                {
                    Settings.status[count].Add(dict.code, dict.name);
                }
                count++;
            }

        }

        internal static void GetUserDB()
        {
            using var db = Program.factory_db.CreateDbContext();
            foreach (var item in db.User.Where(x => string.IsNullOrEmpty(x.i)).Select(x => new { x.id, x.f, x.i }).ToList())
            {
                Settings.users.Add(item.id, $"{item.f} {item.i}");
            }
        }
    }
}