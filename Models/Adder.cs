using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models
{
    class Adder
    {
        public class FileItem
        {
            public string path { get; set; }
            public string name { get; set; }
        }
        public static List<FileItem> files = new List<FileItem>(); //Путь до файла | Название файла
    }
}
