using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //select u.f+' '+u.i+' '+u.o, lap.dt,d.name,lap.dsc from law_act_protokol lap left join users u on u.id = lap.r_user_id left join dict d on d.code = lap.typ where d.parent_id = 26
        private void Form3_Load(object sender, EventArgs e)
        {
            dataSet1.DataTable3.Clear();
            dataGridView1.DataSource = dataSet1.DataTable3;
            if (Settings.vkl != 4)
            {
                string command = $"select u.f+' '+u.i+' '+u.o,da.REL_SERVER_PATH,da.FILE_SERVER_NAME, da.name, lap.dt,d.name,lap.dsc from law_act_protokol lap left join users u on u.id = lap.r_user_id left join dict d on d.code = lap.typ left join doc_attach da on da.id = lap.r_doc_attach_id where d.parent_id = 26 and lap.parent_id = {Settings.debt_id}";
                string connect = $"Driver={{ODBC Driver 17 for SQL Server}};Server=newct;Database=i_collect;Uid=contact;Pwd=contact;";
                using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connect))
                {
                    dataAdapter.Fill(dataSet1.DataTable3);
                }
                dataGridView1.DataSource = dataSet1.DataTable3;
            }
            else
            {
                string command = $"select u.f+' '+u.i+' '+u.o,da.REL_SERVER_PATH,da.FILE_SERVER_NAME, da.name, lap.dt,d.name,lap.dsc from law_exec_protokol lap left join users u on u.id = lap.r_user_id left join dict d on d.code = lap.typ left join doc_attach da on da.id = lap.r_doc_attach_id where d.parent_id = 26 and lap.parent_id = {Settings.debt_id}";
                string connect = $"Driver={{ODBC Driver 17 for SQL Server}};Server=newct;Database=i_collect;Uid=contact;Pwd=contact;";
                using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, connect))
                {
                    dataAdapter.Fill(dataSet1.DataTable3);
                }
                dataGridView1.DataSource = dataSet1.DataTable3;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3 && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))
                try
                {
                    Process.Start($"{Settings.main}{dataGridView1.Rows[e.RowIndex].Cells[1].Value}{dataGridView1.Rows[e.RowIndex].Cells[2].Value}");
                }
                catch { }
        }
    }
}
