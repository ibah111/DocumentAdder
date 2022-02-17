﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string command;
            if (Settings.vkl != 4)
                command = $"select dc.sum,dc.calc_date,dc.dt,dc.report_date,dc.is_confirmed,dc.dsc from law_act la left join debt_calc dc on dc.parent_id = la.r_debt_id where la.id = {Settings.debt_id}";
            else
                command = $"select dc.sum,dc.calc_date,dc.dt,dc.report_date,dc.is_confirmed,dc.dsc from law_exec la left join debt_calc dc on dc.parent_id = la.r_debt_id where la.id = {Settings.debt_id}";
            using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command, Program.Conn))
            {
                dataAdapter.Fill(dataSet1.debt_calc);
            }
            dataGridView1.DataSource = dataSet1.debt_calc;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
