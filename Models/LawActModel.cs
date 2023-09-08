#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class LawActModel
{
    public int id { get; set; }
    public int? typ { get; set; }
    public int? status { get; set; }
    public int? act_status { get; set; }
    public DateTime? court_order_date { get; set; }

    public decimal? total_sum { get; set; }
    public string? exec_number { get; set; }
    public string? dsc { get; set; }

}
