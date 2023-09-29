#nullable enable
using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Forms;
using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAdder.Models;
public class TestData
{
    public string name;
    public object original;
    public object current;
}
public class ChangerData<T, D>
{
    public ChangerData(string name, LawTyp typ, ChangerWrite<T, D> write)
    {
        this.name = name;
        this.typ = typ;
        this.write = write;
    }
    public delegate void ChangerWrite<T, D>(T? original, T? current, D data);
    public string name;
    public LawTyp typ;
    public ChangerWrite<T, D> write;
}


public class ListValue<T>
{
    public delegate void LawData(T data, DataModel value, SettingsModel settings);
    public delegate bool LawCondition(T data, DataModel value, SettingsModel settings);

    public bool checking { get; init; } = true;

    public string? database_order { get; init; }
    public string? database_act { get; init; }
    public string? instance { get; init; }
    public object? value { get; init; }
    public LawData? change;
    public LawCondition? condition { get; init; }
}
public class ListLawFields
{
    public static Dictionary<int, DictModel> getDict(int parent)
    {
        return Settings.dicts[parent];
    }
    public static string? getDict(int parent, int? code)
    {
        if (code == null) return null;
        return getDict(parent)[code.Value].name;
    }
    public static LawActProtokol createProtokolAct(int typ)
    {
        var name = getDict(26, typ);
        return new()
        {
            typ = typ,
            dsc = name,
            dt = DateTime.Now,
            r_user_id = Settings.user_id,
        };
    }
    public static LawExecProtokol createProtokolExec(int typ)
    {
        var name = getDict(76, typ);
        return new()
        {
            typ = typ,
            dsc = name,
            dt = DateTime.Now,
            r_user_id = Settings.user_id,
        };
    }
    public List<object> changer = new()
    {
        new List<string>() { "court_order_date", "Дата вынесения решения" },
        new List<string>() { "court_exec_date", "Дата вступления в силу" },
        new List<string>() { "receipt_dt", "receipt_date", "Дата получения агенством" },
        new List<string>() { "correct_period_date", "Дата исполнения недостатков" },
        new List<string>() { "start_date", "Дата возбуждения" },
        new List<string>() { "exec_number", "Номер дела" },
        new List<string>() { "fssp_doc_num", "Номер ИП" },
        new List<string>() { "court_doc_num", "Номер ИД" },
        new List<string>() { "restriction_to_leave_dt", "Дата ограничения на выезд" },
        new List<string>() { "failure_date", "Дата отказа в возбуждении" },
        new List<string>() { "finish_date", "Дата постановлении об окончании" },
        new ChangerData<int?, LawExec>("state", LawTyp.LawExec, (int? original, int? current, LawExec data) =>
        {
            LawExecProtokol? protokol = null;
            if (current == 1) { protokol = createProtokolExec(30); }
            else if (current == 7)
            {
                protokol = new()
                {
                    typ = 6,
                    dsc = $"Статус дела \"{getDict(77, current)}\". Номер исп. производства: {data.fssp_doc_num}",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            else if (current == 4)
            {
                protokol = new()
                {
                    typ = 31,
                    dsc = $"Причина окончания: {getDict(41, data.finish_reason)}. Дата окончания: {data.finish_date?.ToShortDateString()}",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            else
            {
                protokol = new()
                {
                    typ = 6,
                    dsc = $"Статус дела \"{getDict(77, current)}\"",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            if (protokol != null)
                data.LawExecProtokols.Add(protokol);
        }),
        new ChangerData<int?, LawAct>("act_status", LawTyp.LawAct, (int? original, int? current, LawAct data) =>
        {
            LawActProtokol? protokol = null;
            // Исковое производство: иск подготовлен 2, 11
            if (current == 2)
            {
                protokol = new()
                {
                    typ = 11,
                    dsc = "Исковое производство: иск подготовлен. Крайняя дата подачи: " + data.deadline?.ToShortDateString(),
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Исковое производство: подача иска 3, 12
            else if (current == 3)
            {
                protokol = new()
                {
                    typ = 12,
                    dsc = $"Исковое производство: подача в суд. Дата подачи: {data.deadline?.ToShortDateString()}, размер требования: {data.total_sum?.ToString("N")} руб., гос. пошлина: {data.due_sum?.ToString("N")}",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Суд: определение о принятии иска к производству 4, 13
            else if (current == 4)
            {
                protokol = new()
                {
                    typ = 13,
                    dsc = "Суд: определение о принятии иска к производству. " + data.dsc,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Суд: отказ в принятии иска 5, 14
            else if (current == 5)
            {
                protokol = new()
                {
                    typ = 14,
                    dsc = "Суд: отказ в принятии иска. " + data.dsc,
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Предв. заседание: мировое соглашение 6, 37
            else if (current == 6)
            {
                protokol = new()
                {
                    typ = 37,
                    //TODO: требуется разобраться
                    dsc = $"Мировое соглашение. Сумма: {data.settlement_sum?.ToString("N")}. Дата: ${data.settlement_date?.ToShortDateString()}.",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Предв. заседание: определение о рассмотрении по существу 7, 16
            else if (current >= 7)
            {
                protokol = createProtokolAct(16);
            }
            // Судебное разбирательство: удовлетворение иска 8, 17
            else if (current == 8)
            {
                protokol = createProtokolAct(17);
            }
            // Судебное разбирательство: отказ в удовлетворении иска 9, 18
            else if (current == 9)
            {
                protokol = createProtokolAct(18);
            }
            // Подача жалобы (10,31,37), 58
            else if (current != null && new List<int> { 10, 31, 37 }.Contains(current.Value))
            {

                protokol = new()
                {
                    typ = 58,
                    dsc = current == 10 ? "Аппеляция" : current == 31 ? "Кассация" : "Надзор",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            // Решение Суда обжаловано 11, 20
            else if (current == 11)
            {

                protokol = createProtokolAct(20);
            }
            // Жалоба отклонена 12, 21
            else if (current == 12)
            {

                protokol = createProtokolAct(21);
            }
            else
            {
                protokol = new()
                {
                    typ = 105,
                    dsc = $"Статус дела \"{getDict(25, current)}\"",
                    r_user_id = Settings.user_id,
                    dt = DateTime.Now,
                };
            }
            if (protokol != null)
                data.LawActProtokols.Add(protokol);
        })
    };
    public List<ListValue<LawAct>> LawAct = new()
    {
        new() { database_order = "exec_number", instance = "Exec_number" },
        new()
        {
            database_order = "status",
            database_act = "act_status",
            instance = "Status",
            checking = false,
            condition = (_, value, _) =>
            {
                return value.Status > -1;
            }
        },
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
                data.LawActProtokols.Add(new()
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
            checking = false,
            value = 2,
        },
        new()
        {
            database_order = "int_color",
            checking = false,
            condition = (_, _, settings) =>
            {
                return settings.Color != -1;
            },
            change = (data, value, settings) =>
            {
                data.int_color = settings.Color;
                data.LawActProtokols.Add(new()
                {
                    typ = 2,
                    dt = DateTime.Now,
                    r_user_id = Settings.user_id,
                    dsc = $"Изменен цвет: {settings.Color} Пользователем: {Settings.username}"
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
        new() { database_order = "receipt_act_dt", checking = false, value = DateTime.Now }
    };

    public void writeChanges(i_collectContext db)
    {
        db.ChangeTracker.DetectChanges();
        var data = db.ChangeTracker.Entries().ToList();

        var list_strings = (List<List<string>>)changer.Where(i => i is List<string>);
        var list_changers = (List<ChangerData<object, object>>)changer.Where(i => i is not List<string>);
        data.ForEach(entry =>
        {
            if (entry.Entity is LawAct act)
                foreach (var entityProperty in entry.Properties.Where(prop => prop.IsModified))
                {
                    {
                        var strings = list_strings.Where(x => x.Contains(entityProperty.Metadata.Name)).FirstOrDefault();
                        if (strings != null)
                        {
                            act.LawActProtokols.Add(new()
                            {
                                typ = 2,
                                dsc = $"{strings.Last()}. Новое значение: {entityProperty.CurrentValue?.ToString()}. Старое значение: {entityProperty.OriginalValue?.ToString()}.",
                                dt = DateTime.Now,
                                r_user_id = Settings.user_id
                            });
                        }
                        var changer = list_changers.Where(x => x.name == entityProperty.Metadata.Name && x.typ == LawTyp.LawAct).FirstOrDefault();
                        if (changer != null)
                        {
                            changer.write(entityProperty.OriginalValue, entityProperty.CurrentValue, act);
                        }
                    }
                }
            if (entry.Entity is LawExec exec)
                foreach (var entityProperty in entry.Properties.Where(prop => prop.IsModified))
                {
                    {
                        var strings = list_strings.Where(x => x.Contains(entityProperty.Metadata.Name)).FirstOrDefault();
                        if (strings != null)
                        {
                            exec.LawExecProtokols.Add(new()
                            {
                                typ = 2,
                                dsc = $"{strings.Last()}. Новое значение: {entityProperty.CurrentValue?.ToString()}. Старое значение: {entityProperty.OriginalValue?.ToString()}.",
                                dt = DateTime.Now,
                                r_user_id = Settings.user_id
                            });
                        }
                        var changer = list_changers.Where(x => x.name == entityProperty.Metadata.Name && x.typ == LawTyp.LawExec).FirstOrDefault();
                        if (changer != null)
                        {
                            changer.write(entityProperty.OriginalValue, entityProperty.CurrentValue, exec);
                        }
                    }
                }
        });
        MessageBox.Show("stop");

    }
}