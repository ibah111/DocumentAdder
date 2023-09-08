using DocumentAdder.Models;
using System;



namespace DocumentAdder.Utils;

public class LawActResult
{
    public ActDataModel data;
    public LawActResult(ActDataModel data)
    {
        this.data = data;
    }
    public int id { get { return data.id; } }
    public int? typ { get { return data.LawAct.typ; } }
    public int? status { get { return data.LawAct.status; } }
    public int? act_status { get { return data.LawAct.act_status; } }
    public string fio_vz { get { return data.Debt.fio_vz; } }
    public string? name { get { return data.Debt.name; } }
    public string portfolio { get { return data.Debt.portfolio; } }
    public string fio { get { return data.Person.fio; } }
    public DateTime? birth_date { get { return data.Person.birth_date; } }
    public string contract { get { return data.Debt.contract; } }
    public string exec_number { get { return data.LawAct.exec_number; } }
    public decimal? total_sum { get { return data.LawAct.total_sum; } }
    public string dsc { get { return data.LawAct.dsc; } }
    public string court_name { get { return data.LawCourt.name; } }
    public string court_adress { get { return data.LawCourt.address; } }
    public decimal? start_sum { get { return data.Debt.start_sum; } }
    public string number { get { return data.Person.number; } }
    public string series { get { return data.Person.series; } }
    public string birth_place { get { return data.Person.birth_place; } }
    public string full_adr { get { return data.Person.full_adr; } }
    public DateTime? exec_date { get { return data.LawAct.court_order_date; } }
    public string inn { get { return data.Person.inn; } }


}

