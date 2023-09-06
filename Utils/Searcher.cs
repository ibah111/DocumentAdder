using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace DocumentAdder.Utils;
public class NamePerson
{
    public string f { get; set; }
    public string i { get; set; }
    public string o { get; set; }
}

public class Searcher
{
    private NamePerson fio; //ФИО
    private string law_id; //ID Дела
    private string contract; //№ КД
    private string exec_number; //№ Дела

    public Searcher(NamePerson fio, string law_id, string contract, string exec_number)
    {
        this.fio = fio;
        this.law_id = law_id;
        this.contract = contract;
        this.exec_number = exec_number;
    }
    public void GetTables(BindingSource LawActSource, BindingSource LawExecSource)
    {
        using var db = Program.factory_db.CreateDbContext();
        LawActSource.Clear();
        LawExecSource.Clear();
        var data1 = db.LawAct.AsQueryable();
        var data2 = db.LawExec.AsQueryable();
        if (fio != null)
        {
            data1 = db.LawAct.Where(
                x => EF.Functions.Like(x.Person.f, $"{fio.f}%") && EF.Functions.Like(x.Person.i, $"{fio.i}%") && EF.Functions.Like(x.Person.o, $"{fio.o}%")
                );
            data2 = db.LawExec.Where(
                x => EF.Functions.Like(x.Person.f, $"{fio.f}%") && EF.Functions.Like(x.Person.i, $"{fio.i}%") && EF.Functions.Like(x.Person.o, $"{fio.o}%")
                );
        }
        if (contract != "")
        {
            data1 = data1.Where(x => EF.Functions.Like(x.Debt.contract, contract + "%"));
            data2 = data2.Where(x => EF.Functions.Like(x.Debt.contract, contract + "%"));
        }
        if (law_id != "")
        {
            data1 = data1.Where(x => EF.Functions.Like(x.id.ToString(), law_id + "%"));
            data2 = data2.Where(x => EF.Functions.Like(x.id.ToString(), law_id + "%"));
        }
        if (exec_number != "")
        {
            data1 = data1.Where(x => EF.Functions.Like(x.exec_number, exec_number + "%"));
            data2 = data2.Where(x => EF.Functions.Like(x.LawAct.exec_number, exec_number + "%"));
        }
        var subquery1 = data1.GroupJoin(db.LawExec,
            (x) => x.id,
            (x) => x.r_act_id,
            (x, y) => new
            {
                LawAct = x,
                LawExec = y.FirstOrDefault()
            });
        var select1 = subquery1.Select(x => new LawActResult()
        {
            id = x.LawAct.id,
            typ = x.LawAct.typ,
            status = x.LawAct.status,
            act_status = x.LawAct.act_status,
            fio_vz = x.LawAct.Debt.WorkTask.User.f + " " + x.LawAct.Debt.WorkTask.User.i + " " + x.LawAct.Debt.WorkTask.User.o,
            name = x.LawAct.name,
            portfolio = x.LawAct.Portfolio.name,
            f = x.LawAct.Person.f,
            i = x.LawAct.Person.i,
            o = x.LawAct.Person.o,
            birth_date = x.LawAct.Person.birth_date,
            contract = x.LawAct.Debt.contract,
            exec_number = x.LawAct.exec_number,
            total_sum = x.LawAct.total_sum,
            dsc = x.LawAct.dsc,
            court_doc_num = x.LawExec.court_doc_num,
            court_date = x.LawExec.court_date,
            court_name = x.LawAct.LawCourt.name,
            court_adress = x.LawAct.LawCourt.name,
            start_sum = x.LawAct.Debt.start_sum,
            number = x.LawAct.Person.Passport.number,
            series = x.LawAct.Person.Passport.series,
            birth_place = x.LawAct.Person.birth_place,
            full_adr = x.LawAct.Person.Addresses.Where(x => x.typ == 1).Select(x => x.full_adr).FirstOrDefault(),
            exec_date = x.LawAct.court_order_date,
            inn = x.LawAct.Person.inn
        });
        var select2 = data2.Select(x => new LawExecResult()
        {
            id = x.id,
            Status = x.state,
            Debt_status = x.Debt.status,
            fio_vz = x.Debt.WorkTask.User.f + " " + x.Debt.WorkTask.User.i + " " + x.Debt.WorkTask.User.o,
            portfolio = x.Portfolio.name,
            f = x.Person.f,
            i = x.Person.i,
            o = x.Person.o,
            birth_date = x.Person.birth_date,
            contract = x.Debt.contract,
            fssp_doc_num = x.fssp_doc_num,
            court_doc_num = x.court_doc_num,
            fssp_name = x.LawCourt.name,
            fssp_address = x.LawCourt.address,
            court_name = x.LawAct.LawCourt.name,
            court_address = x.LawAct.LawCourt.address,
            exec_number = x.LawAct.exec_number,
            court_date = x.court_date,
            dsc = x.dsc,
            full_adr = x.Person.Addresses.Where(x => x.typ == 1).Select(x => x.full_adr).FirstOrDefault(),
            total_sum = x.total_sum,
            start_sum = x.Debt.start_sum,
            number = x.Person.Passport.number,
            series = x.Person.Passport.series,
            inn = x.LawAct.Person.inn,
            exec_date = x.LawAct.court_order_date,
            birth_place = x.Person.birth_place
        });
        var result1 = select1.ToList();
        var result2 = select2.ToList();
        LawActSource.DataSource = result1;
        LawExecSource.DataSource = result2;
    }
}
