#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class LawExecModel
{
    public int id { get; set; }
    public int? state { get; set; }
    public string? fssp_doc_num { get; set; }
    public string? court_doc_num { get; set; }
    public DateTime? court_date { get; set; }
    public decimal? total_sum { get; set; }
    public string? dsc { get; set; }
}
