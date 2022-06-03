using System;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    static class Program
    {
        public static OdbcConnection Conn = new OdbcConnection($"Driver={{ODBC Driver 17 for SQL Server}};Server=newct;Database={Settings.dbs};Uid=docmail;Pwd=docmail;");
        static public void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                DownloadURL = json.url
            };
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.InstalledVersion = new Version("2.0.0.15");
            AutoUpdater.DownloadPath = Application.StartupPath;
            AutoUpdater.ParseUpdateInfoEvent += AutoUpdaterOnParseUpdateInfoEvent;
            AutoUpdater.Synchronous = true;
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.Start("https://chat.nbkfinance.ru/apps/mail/standelone.json");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => { return true; };
#endif
            Conn.Open();
            Application.Run(new Form1());
            
        }
    }
}
