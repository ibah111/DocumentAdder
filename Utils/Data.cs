using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using DocumentAdder.Forms;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAdder.Utils;


class Data
{

    private static void callerData<T>(T row, DataModel data, SettingsModel enabled, ListValue<T> item, bool act = false)
    {

        MethodInfo setter = null;
        if (item.database_order != null)
            setter = row.GetType().GetMethod("set_" + item.database_order);
        if (act && item.database_act != null)
            setter = row.GetType().GetMethod("set_" + item.database_act);

        var checker = enabled.GetType().GetMethod("get_" + item.instance);
        if ((item.checking == false || checker != null && ((bool)checker.Invoke(enabled, null))) && (item.condition == null || (item.condition != null && item.condition(row, data, enabled))))
        {
            if (item.value != null)
            {

                setter.Invoke(row, new[] { item.value });
            }
            if (item.change != null)
            {
                item.change(row, data, enabled);
            }
            var getter = data.GetType().GetMethod("get_" + item.instance);
            if (setter != null && getter != null)
            {
                setter.Invoke(row, new[] { getter.Invoke(data, null) });
            }
        }
    }


    public static async Task<i_collectContext> Update(i_collectContext db, DataModel data, SettingsModel enabled)
    {
        var LawExec = await db.LawExec.Include(x => x.LawAct).FirstOrDefaultAsync(x => x.id == data.Id);
        var LawAct = await db.LawAct.FirstOrDefaultAsync(x => x.id == data.Id);
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
