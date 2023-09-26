#nullable enable
using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class ChangeData {
    public int typ { get; init; }

}

public class ListValue<T>
{
    public delegate void LawData(T data, DataModel value, SettingsModel settings);
    public delegate bool LawCondition(T data, DataModel value, SettingsModel settings);

    public string? database_order { get; init; }
    public string? database_act { get; init; }
    public string? instance { get; init; }
    public object? value { get; init; }
    public LawData? change;
    public LawCondition? condition { get; init; }
}
public class ListLawFields
{
    public List<ListValue<LawAct>> LawAct = new()
    {
        new() { database_order = "exec_number", instance = "Exec_number" },
        new() { database_order = "status", database_act = "act_status", instance = "Status" },
        new() { database_order = "dsc", instance = "Dsc" },
        new() { database_order = "court_order_date", instance = "Court_order_date" },
        new() { database_order = "court_exec_date", instance = "Court_exec_date" },
        new() { database_order = "receipt_date", instance = "Receipt_date", database_act = "receipt_dt" },
        new()
        {
            database_order = "correct_period_date",
            instance = "Correct_period_date",
        },
        new()
        {
            instance = "Return_date",
            change = (data, value, _) =>
            {
                data.LawActProtokols.Add(new LawActProtokol()
                {
                    typ = 72,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                    dsc = $"Дата возврата приказа: {value.Return_date?.ToShortDateString()} Комментарий: {value.Dsc}"
                });
            }
        },
        new()
        {
            instance = "Cancel_date",
            change = (data, value, _) =>
            {
                data.LawActProtokols.Add(new ()
                {
                    typ = 8,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                    dsc = $"Дата отмены приказа: {value.Cancel_date?.ToShortDateString()} Комментарий: {value.Dsc}"
                });
            }
        },
        new()
        {
            instance = "Session_date",
            change = (data, value, _) =>
            {
                data.LawSessions.Add(new()
                { dt = value.Session_date, status = 1 });
            }
        },
        new()
        {
            database_order = "court_order_delivery",
            value = 2,
        },
        new(){ 
            database_order = "int_color",
            condition = (_, _, settings) => {
                return settings.color != -1;
            },
            change = (data, value, settings) => 
            {
                data.int_color = settings.color;
                data.LawActProtokols.Add(new() {
                    typ = 2,
                    dt=DateTime.Now,
                    r_user_id=Settings.user_id,
                    dsc = $"Изменен цвет: {settings.color} Пользователем: {Settings.username}"
                });
            }
        }
    };
    public List<ListValue<LawExec>> LawExec = new()
    {
        new() { database_order = "exec_number", instance = "Exec_number" },
        new() { database_order = "state", instance = "Status" },
        new() { database_order = "fssp_doc_num", instance = "Fssp_doc_num" },
        new() { database_order = "court_doc_num", instance = "Court_doc_num" },
        new() { database_order = "dsc", instance = "Dsc" },
        new() { database_order = "court_date", instance = "Court_order_date" },
        new() { database_order = "entry_force_dt", instance = "Court_exec_date" },
        new() { database_order = "start_date", instance = "Start_date" },
        new() { database_order = "finish_date", instance = "Finish_date" },
        new() { database_order = "restriction_to_leave_dt", instance = "Restriction_to_leave_dt" },
        new() { database_order = "reject_date", instance = "Reject_date" },
        new() { database_order = "receipt_act_dt", value = DateTime.Now }
    };

    public void writeChanges(i_collectContext db) {
        db.ChangeTracker.DetectChanges();
        db.ChangeTracker.Entries();
    }
}