using DocumentAdder.Main;
using DocumentAdder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentAdder.Utils;

internal class FromStart
{
    internal static string DownloadInfo()
    {
        GetUserDB();
        Settings.dicts = GetDicts(405, 18, 25, 77);
        return GetUser();
    }

    public static string GetUser()
    {
        return $"Входящая почта. Документооборот. Пользователь: {Settings.username} [{Settings.user_id}]";
    }
    public static Dictionary<int, Dictionary<int, DictModel>> GetDicts(params int[] list)
    {

        using var db = Program.factory_db.CreateDbContext();
        var data = db.Dict.Where(x => list.Contains(x.parent_id)).Select(x => new
        {
            x.parent_id,
            x.code,
            x.name
        }).ToList().GroupBy(x => x.parent_id).ToDictionary(x => x.Key, x => x.ToDictionary(x => x.code, x => new DictModel
        {
            code = x.code,
            name = x.name
        }));
        return data;
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