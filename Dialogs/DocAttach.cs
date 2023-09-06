using DocumentAdder.Forms;
using DocumentAdder.Main;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs;

public partial class DocAttach : Form
{
    private LawTyp law_typ;
    public DocAttach(LawTyp law_typ)
    {
        this.law_typ = law_typ;
        InitializeComponent();
    }

    //select u.f+' '+u.i+' '+u.o, lap.dt,d.name,lap.dsc from law_act_protokol lap left join users u on u.id = lap.r_user_id left join dict d on d.code = lap.typ where d.parent_id = 26
    private void Form3_Load(object sender, EventArgs e)
    {
        if (!int.TryParse(Settings.debt_id, out var id)) throw new Exception("Ошибка формы");
        using var db = Program.factory_db.CreateDbContext();
        userModelBindingSource.DataSource = db.User.Select(x => new UserModel() { id = x.id, fio = x.f + " " + x.i + " " + x.o }).ToList();
        dictModelBindingSource.DataSource = db.Dict.Where(x => x.parent_id == 100).Select(x => new DictModel() { code = x.code, name = x.name }).ToList();
        List<DatabaseContact.Models.DocAttach> data;
        if (law_typ == LawTyp.LawAct)
        {
            data = db.DocAttach.Include(x => x.User).Where(x => x.r_id == id && x.obj_id == 46).ToList();
        }
        else
        {
            data = db.DocAttach.Include(x => x.User).Where(x => x.r_id == id && x.obj_id == 47).ToList();

        }
        docAttachBindingSource.DataSource = data;

    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        docAttachBindingSource.DataSource = null;
        base.OnFormClosing(e);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        using var db = Program.factory_db.CreateDbContext();
        string main_dir = db.ConstValue.Where(x => x.name == "DocAttach.SavePath").Select(x => x.value).First();
        var data = ((List<DatabaseContact.Models.DocAttach>)docAttachBindingSource.DataSource)[e.RowIndex];
        Process.Start(new ProcessStartInfo($"{main_dir}{data.REL_SERVER_PATH}{data.FILE_SERVER_NAME}") { UseShellExecute = true });
    }
}
