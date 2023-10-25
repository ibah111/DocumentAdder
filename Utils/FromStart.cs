using DocumentAdder.Main;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentAdder.Utils;

internal class FromStart
{
    internal static async Task<string> DownloadInfo()
    {
        await GetUserDB();
        Settings.dicts = await GetDicts(405, 18, 25, 26, 76, 77, 41, 6, 100);
        return GetUser();
    }

    public static string GetUser()
    {
        return $"Входящая почта. Документооборот. Пользователь: {Settings.username} [{Settings.user_id}]";
    }
    public static async Task<Dictionary<int, Dictionary<int, DictModel>>> GetDicts(params int[] list)
    {

        using var db = await Program.factory_db.CreateDbContextAsync();
        var data = await db.Dict.Where(x => list.Contains(x.parent_id)).Select(x => new
        {
            x.parent_id,
            x.code,
            x.name
        }).GroupBy(x => x.parent_id).ToDictionaryAsync(x => x.Key, x => x.ToDictionary(x => x.code, x => new DictModel
        {
            code = x.code,
            name = x.name
        }));
        return data;
    }

    internal static async Task GetUserDB()
    {
        using var db = await Program.factory_db.CreateDbContextAsync();
        Settings.users = (await db.User.Where(x => string.IsNullOrEmpty(x.i)).Select(x => new { x.id, x.f, x.i }).ToListAsync()).ToDictionary(x => x.id, item => $"{item.f} {item.i}");
    }
}