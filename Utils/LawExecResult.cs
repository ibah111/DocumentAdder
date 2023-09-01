using System;



namespace DocumentAdder.Utils;

public class LawExecResult
{
    public int id { get; set; }
    public int? Status { get; set; }
    public int? Debt_status { get; set; }
    public string fio_vz { get; set; }
    public string portfolio { get; set; }
    public string fio { get; set; }
    public DateTime? birth_date { get; set; }
    public string contract { get; set; }
    public string fssp_doc_num { get; set; }
    public string court_doc_num { get; set; }
    public string fssp_name { get; set; }
    public string fssp_address { get; set; }
    public string court_name { get; set; }
    public string court_address { get; set; }
    public string exec_number { get; set; }
    public string dsc { get; set; }
    public string full_adr { get; set; }
    public decimal? start_sum { get; set; }
    public string number { get; set; }
    public string series { get; set; }
    public string inn { get; set; }
    public DateTime? exec_date { get; set; }
    public string birth_place { get; set; }

    public DateTime? court_date { get; set; }
    public decimal? total_sum { get; set; }


}

