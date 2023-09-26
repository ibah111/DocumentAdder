using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Forms;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DocumentAdder.Utils;


class Data
{
    private static int? _status;
    private static string _id;
    public static int int_color;

    public static int? status { get { return _status; } set { _status = value; } }
    public static string id { get { return _id; } set { _id = value; } }

    private static void callerData<T>(T row, DataModel data, SettingsModel enabled, ListValue<T> item, bool act = false)
    {

        MethodInfo setter = null;
        if (item.database_order != null)
            setter = row.GetType().GetMethod("set_" + item.database_order);
        if (act && item.database_act != null)
            setter = row.GetType().GetMethod("set_" + item.database_act);

        var checker = enabled.GetType().GetMethod("get_" + item.instance);
        if ((bool)checker.Invoke(enabled, null) && (item.condition == null || (item.condition != null && item.condition(row, data, enabled))))
        {
            if (item.value != null)
            {
                setter.Invoke(row, new[] { item.value });
            }
            if (item.change != null)
            {
                item.change(row, data, enabled);
            }
            if (setter != null)
            {
                var getter = data.GetType().GetMethod("get_" + item.instance);
                setter.Invoke(row, new[] { getter.Invoke(data, null) });
            }
        }
    }


    public static i_collectContext Update(i_collectContext db, DataModel data, SettingsModel enabled)
    {
        if (!int.TryParse(id, out var id_int))
        {
            throw new Exception("Ошибка парса id");
        }
        var LawExec = db.LawExec.Include(x => x.LawAct).FirstOrDefault(x => x.id == id_int);
        var LawAct = db.LawAct.FirstOrDefault(x => x.id == id_int);
        var fields = new ListLawFields();
        if (data.Typ == LawTyp.LawAct)
            foreach (var item in fields.LawAct)
            {
                callerData(LawAct, data, enabled, item, LawAct.typ > 1);
            }

        if (data.Typ == LawTyp.LawExec)
            foreach (var item in fields.LawExec)
            {
                callerData(LawExec, data, enabled, item);
            }
        fields.writeChanges(db);

        return db;
    }
}
