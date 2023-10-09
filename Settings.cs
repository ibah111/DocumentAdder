using DocumentAdder.Models;
using System.Collections.Generic;

namespace DocumentAdder;

class Settings
{
#if DEBUG
    public static string dbs = "i_collect3";
    public static string server = "http://alex.usb.ru:3001";
    public static string server_ws = "http://alex.usb.ru:3001";
    public static string server_login = "https://chat.nbkfinance.ru/apps/mail";
#else
    public static string dbs = "i_collect";
    public static string server = "https://apps.usb.ru:3001";
    public static string server_ws = "https://apps.usb.ru:3001";
    public static string server_login = "https://chat.nbkfinance.ru/apps/mail";
#endif
    private static int _user_id;
    private static string _username;

    public static string json { get; set; }
    public static int user_id { get; set; }
    public static string username { get; set; }

    public static bool barcode { get; set; }


    public static Dictionary<int, string> users = new Dictionary<int, string>();
    public static Dictionary<int, Dictionary<int, DictModel>> dicts = new();
}
