using DocumentAdder.Forms;
using DocumentAdder.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs;

public partial class DebtCalc : Form
{
    private LawTyp law_typ;
    private int id;
    public DebtCalc(LawTyp law_typ, int id)
    {
        this.law_typ = law_typ;
        InitializeComponent();
        this.id = id;

    }

    private void DebtCalc_Load(object sender, EventArgs e)
    {
        using var db = Program.factory_db.CreateDbContext();
        List<DatabaseContact.Models.DebtCalc> data;
        if (law_typ == LawTyp.LawAct)
            data = db.LawAct.Where(x => x.id == id).Select(x => x.Debt.DebtCalcs).First();
        else
            data = db.LawExec.Where(x => x.id == id).Select(x => x.Debt.DebtCalcs).First();
        dataGridView1.DataSource = data;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }
}
