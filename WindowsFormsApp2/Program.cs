using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static OdbcConnection Conn = new OdbcConnection($"Driver={{ODBC Driver 17 for SQL Server}};Server=newct;Database={Settings.dbs};Uid=contact;Pwd=contact;");
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conn.Open();
            Application.Run(new Form1());
        }
    }
}
