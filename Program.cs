﻿using System;
using System.Data.Odbc;
using System.Net;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace DocumentAdder.Main
{
    static class Program
    {
        public static readonly RestClient client = new RestClient(Settings.server);
        public static OdbcConnection Conn = new OdbcConnection($"Driver={{SQL Server}};Server=newct.usb.ru;Database={Settings.dbs};Uid=docmail;Pwd=docmail;");
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
            client.UseNewtonsoftJson();
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
