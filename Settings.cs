using DocumentAdder.Models;
using System.Collections.Generic;

namespace DocumentAdder
{
    class Settings
    {
        //#if DEBUG
        //        public static string dbs = "i_collect_test";
        //        public static string main = "\\\\newct\\Luxbase\\Docattach2";
        //        public static string server = "http://localhost:3001";
        //        public static string server_ws = "http://localhost:3001";
        //        public static string server_login = "http://localhost:3000/apps/mail";
        //#else
        public static string dbs = "i_collect";
        public static string main = "\\\\newct\\Luxbase\\Docattach";
        public static string server = "https://apps.usb.ru:3001";
        public static string server_ws = "https://apps.usb.ru:3001";
        public static string server_login = "https://chat.nbkfinance.ru/apps/mail";
        //#endif
        private static string _json;
        private static int _user_id;
        private static string _username;
        public static string command;
        public static string command1;
        private static string _debt_id;
        private static bool _conv;
        private static string _date_post;
        private static string _adr_otp;
        private static string _otprav;
        private static string _doc_name;
        private static bool _nal_skan;
        private static string _user_id_tasks;
        private static string _fio;
        private static string _kd;
        private static string _reestr;
        private static string _dsc;
        private static string _template_id_task;
        private static string _action;
        private static int _vkl;
        private static int _mode;
        private static string _ist;
        private static string _dateDoc;
        private static string _ecp;
        private static string _adres;
        private static string _mail;

        public static string json { get { return _json; } set { _json = value; } }
        public static int user_id { get { return _user_id; } set { _user_id = value; } }
        public static string username { get { return _username; } set { _username = value; } }
        public static string token { get; set; }
        public static string debt_id { get { return _debt_id; } set { _debt_id = value; } }
        public static int vkl { get { return _vkl; } set { _vkl = value; } }
        public static bool conv { get { return _conv; } set { _conv = value; } }
        public static string date_post { get { return _date_post; } set { _date_post = value; } }
        public static string adr_otp { get { return _adr_otp; } set { _adr_otp = value; } }
        public static string otprav { get { return _otprav; } set { _otprav = value; } }
        public static string doc_name { get { return _doc_name; } set { _doc_name = value; } }
        public static bool nal_skan { get { return _nal_skan; } set { _nal_skan = value; } }
        public static string user_id_tasks { get { return _user_id_tasks; } set { _user_id_tasks = value; } }
        public static string fio { get { return _fio; } set { _fio = value; } }
        public static string kd { get { return _kd; } set { _kd = value; } }
        public static string reestr { get { return _reestr; } set { _reestr = value; } }
        public static string dsc { get { return _dsc; } set { _dsc = value; } }
        public static string template_id_task { get { return _template_id_task; } set { _template_id_task = value; } }
        public static string action { get { return _action; } set { _action = value; } }
        public static bool dateId { get; set; } = false;
        public static int mode { get { return _mode; } set { _mode = value; } }
        public static string ist { get { return _ist; } set { _ist = value; } }
        public static string dateDoc { get { return _dateDoc; } set { _dateDoc = value; } }
        public static string ecp { get { return _ecp; } set { _ecp = value; } }
        public static string adres { get { return _adres; } set { _adres = value; } }
        public static string mail { get { return _mail; } set { _mail = value; } }
        public static bool barcode { get; set; }


        public static Dictionary<int, string> users = new Dictionary<int, string>();
        public static Dictionary<int, Dictionary<int, DictModel>> dicts = new();
    }
}
