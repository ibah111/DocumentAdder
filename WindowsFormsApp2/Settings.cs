using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Settings
    {
#if DEBUG
        public static string dbs = "i_collect_test";
#else
        public static string dbs = "i_collect";
#endif
        private static string _json;
        private static int _user_id;
        private static string _username;
        public static string command;
        private static string _debt_id;
#if DEBUG
        public static string main = "\\\\newct\\Luxbase\\Docattach2";
#else
        public static string main = "\\\\newct\\Luxbase\\Docattach";
#endif
        private static int _vkl;
        public static string json { get { return _json; } set { _json = value; } }
        public static int user_id { get { return _user_id; } set { _user_id = value; } }
        public static string username { get { return _username; } set { _username = value; } }
        public static string debt_id { get { return _debt_id; } set { _debt_id = value; } }
        public static int vkl { get { return _vkl; } set { _vkl = value; } }




        public static Dictionary<int, string> users = new Dictionary<int, string>();
        public static Dictionary<int, Dictionary<int, string>> status = new Dictionary<int, Dictionary<int, string>>();
    }
}
