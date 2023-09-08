#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class DebtModel
{
    public int id { get; set; }
    public decimal? start_sum { get; set; }
    public string? contract { get; set; }
    public string? name { get; set; }
    public string? portfolio { get; set; }
    public string? fio_vz { get; set; }

    public int? status { get; set; }

}
