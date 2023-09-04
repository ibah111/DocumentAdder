using DatabaseContact.Models;
using DocumentAdder.Forms;
using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DocumentAdder.Dialogs
{
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
            List<DatabaseContact.Models.DocAttach> data;
            if (law_typ == LawTyp.LawAct)
            {
                data = db.DocAttach.Include(x => x.User).Where(x => x.r_id == id && x.obj_id == 46).ToList();
            }
            else
            {
                data = db.DocAttach.Include(x => x.User).Where(x => x.r_id == id && x.obj_id == 47).ToList();

            }
            dataGridView1.DataSource = data;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using var db = Program.factory_db.CreateDbContext();
            string main_dir = db.ConstValue.Where(x => x.name == "DocAttach.SavePath").Select(x => x.value).First();
            if (e.ColumnIndex == 3 && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))
                try
                {
                    Process.Start($"{main_dir}{dataGridView1.Rows[e.RowIndex].Cells[1].Value}{dataGridView1.Rows[e.RowIndex].Cells[2].Value}");
                }
                catch { }
        }
    }
}
