using AutoUpdaterDotNET;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;
using DocumentAdder.Forms;
using DatabaseContact.DatabaseContact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DocumentAdder.Main
{
    static class Program
    {
        public static readonly RestClientOptions clientOptions = new RestClientOptions(Settings.server) { Authenticator = new BitrixAuthenticator() };
        public static readonly RestClient client = new RestClient(clientOptions, configureSerialization: s => s.UseNewtonsoftJson());
        public static OdbcConnection Conn = new OdbcConnection($"Driver={{SQL Server}};Server=newct.usb.ru;Database={Settings.dbs};Uid=docmail;Pwd=docmail;");
        public static PooledDbContextFactory<i_collectContext> factory_db = new(new DbContextOptionsBuilder<i_collectContext>().UseLazyLoadingProxies().UseSqlServer($"Data Source=newct;Initial Catalog={Settings.dbs};Persist Security Info=True;User ID=docmail;Password=docmail;Trust Server Certificate=True").Options);
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
            Application.Run(new App());

        }
    }
}
