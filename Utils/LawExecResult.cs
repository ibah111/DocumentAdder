#nullable enable
using DocumentAdder.Models;
using System;



namespace DocumentAdder.Utils;

public class LawExecResult
{

    public ActDataModel data;
    public LawExecResult(ActDataModel data)
    {
        this.data = data;
    }
    public int id { get { return data.id; } }
    public int? Status { get { return data.LawExec.state; } }
    public int? Debt_status { get { return data.Debt.status; } }
    public string? fio_vz { get { return data.Debt.fio_vz; } }
    public string? portfolio { get { return data.Debt.portfolio; } }
    public string? fio { get { return data.Person.fio; } }
    public DateTime? birth_date { get { return data.Person.birth_date; } }
    public string contract { get { return data.Debt.contract; } }
    public string? fssp_doc_num { get { return data.LawExec.fssp_doc_num; } }
    public string? court_doc_num { get { return data.LawExec.court_doc_num; } }
    public string? fssp_name { get { return data.LawCourt?.name; } }
    public string? fssp_address { get { return data.LawCourt?.address; } }
    public string? exec_number { get { return data.LawAct?.exec_number; } }
    public string? dsc { get { return data.LawExec.dsc; } }
    public string? full_adr { get { return data.Person.full_adr; } }
    public decimal? start_sum { get { return data.Debt.start_sum; } }
    public string? number { get { return data.Person.number; } }
    public string? series { get { return data.Person.series; } }
    public string? inn { get { return data.Person.inn; } }
    public DateTime? exec_date { get { return data.LawAct?.court_order_date; } }
    public string? birth_place { get { return data.Person.birth_place; } }

    public DateTime? court_date { get { return data.LawExec.court_date; } }
    public decimal? total_sum { get { return data.LawExec.total_sum; } }


}

