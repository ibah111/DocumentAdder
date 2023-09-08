#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models
{
    public class PersonModel
    {
        public int id { get; set; }
        public string f { get; set; } = null!;
        public string? i { get; set; }
        public string? o { get; set; }
        public string fio
        {
            get
            {
                return f + " " + i + " " + o;
            }
        }
        public DateTime? birth_date { get; set; }
        public string? birth_place { get; set; }
        public string? number { get; set; }
        public string? series { get; set; }
        public string? inn { get; set; }
        public string? full_adr { get; set; }
    }
}
