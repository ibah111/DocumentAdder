using AutoUpdaterDotNET;
using DatabaseContact.DatabaseContact;
using DocumentAdder.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Net;
using System.Windows.Forms;

namespace DocumentAdder.Main
{
    static class Program
    {
        public static readonly RestClientOptions clientOptions = new RestClientOptions(Settings.server) { Authenticator = new BitrixAuthenticator() };
        public static readonly RestClient client = new RestClient(clientOptions, configureSerialization: s => s.UseNewtonsoftJson());
        public static PooledDbContextFactory<i_collectContext> factory_db = null;
        static public void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                DownloadURL = json.url
            };
        }
        static public DbContextOptions<T> getOptionsSql<T>(string db) where T : DbContext
        {
            return new DbContextOptionsBuilder<T>().UseLazyLoadingProxies().UseSqlServer(getConfigSql(db)).Options;
        }
        static public string getConfigSql(string db)
        {
            return "Data Source=newct;"
                + $"Initial Catalog={db};"
                + "Persist Security Info=True;"
                + "User ID=docmail;"
                + "Password=docmail;"
                + "Trust Server Certificate=True";
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
            Application.Run(new App());

        }
    }
}
