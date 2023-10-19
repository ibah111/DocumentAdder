#nullable enable
using DocumentAdder.Forms;
using DocumentAdder.Main;
using DocumentAdder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
        var select1 = data1.Select(x => new ActDataModel()
        {
            id = x.id,
            typ = LawTyp.LawAct,
            LawAct = new()
            {
                act_status = x.act_status,
                id = x.id,
                typ = x.typ,
                status = x.status,
                exec_number = x.exec_number,
                court_order_date = x.court_order_date,
                total_sum = x.total_sum,
                court_exec_date = x.court_exec_date,
                receipt_dt = x.receipt_dt,
                receipt_act_dt = x.receipt_act_dt,
                receipt_date = x.receipt_date,
                dsc = x.dsc,
                failure_date = x.failure_date,
                correct_period_date = x.correct_period_date
            },
            Debt = x.Debt != null ? new()
            {
                id = x.Debt.id,
                contract = x.Debt.contract,
                start_sum = x.Debt.start_sum,
                portfolio = x.Debt.Portfolio.name,
                name = x.Debt.name,
                fio_vz = x.Debt.WorkTask.User.f + " " + x.Debt.WorkTask.User.i + " " + x.Debt.WorkTask.User.o,
                status = x.Debt.status
            } : null,
            Person = new()
            {
                id = x.Person.id,
                birth_date = x.Person.birth_date,
                f = x.Person.f,
                i = x.Person.i,
                o = x.Person.o,
                inn = x.Person.inn,
                birth_place = x.Person.birth_place,
                number = x.Person.Passport.number,
                series = x.Person.Passport.series,
                full_adr = x.Person.Addresses.Where(x => x.typ == 1).Select(x => x.full_adr).FirstOrDefault()
            },
            LawCourt = x.LawCourt != null ? new() { id = x.LawCourt.id, name = x.LawCourt.name, address = x.LawCourt.address } : null
        });

        var select2 = data2.Select(x => new ActDataModel()
        {
            id = x.id,
            typ = LawTyp.LawExec,
            LawExec = new()
            {
                id = x.id,
                court_date = x.court_date,
                court_doc_num = x.court_doc_num,
                fssp_doc_num = x.fssp_doc_num,
                state = x.state,
                total_sum = x.total_sum,
                start_date = x.start_date,
                dsc = x.dsc,
                finish_date = x.finish_date,
                receipt_act_dt = x.receipt_act_dt,
                restriction_to_leave_dt = x.restriction_to_leave_dt,
            },
            LawAct = x.LawAct != null ? new()
            {
                act_status = x.LawAct.act_status,
                id = x.LawAct.id,
                typ = x.LawAct.typ,
                status = x.LawAct.status,
                court_exec_date = x.LawAct.court_exec_date,
                exec_number = x.LawAct.exec_number,
                court_order_date = x.LawAct.court_order_date,
                total_sum = x.LawAct.total_sum,
                dsc = x.LawAct.dsc,
                receipt_dt = x.LawAct.receipt_dt,
                receipt_act_dt = x.LawAct.receipt_act_dt,
                receipt_date = x.LawAct.receipt_date,
                failure_date = x.LawAct.failure_date,
                correct_period_date = x.LawAct.correct_period_date
            } : null,
            Debt = x.Debt != null ? new()
            {
                id = x.Debt.id,
                contract = x.Debt.contract,
                start_sum = x.Debt.start_sum,
                portfolio = x.Debt.Portfolio.name,
                name = x.Debt.name,
                fio_vz = x.Debt.WorkTask.User.f + " " + x.Debt.WorkTask.User.i + " " + x.Debt.WorkTask.User.o,
                status = x.Debt.status
            } : null,
            Person = new()
            {
                id = x.Person.id,
                birth_date = x.Person.birth_date,
                f = x.Person.f,
                i = x.Person.i,
                o = x.Person.o,
                inn = x.Person.inn,
                birth_place = x.Person.birth_place,
                number = x.Person.Passport.number,
                series = x.Person.Passport.series,
                full_adr = x.Person.Addresses.Where(x => x.typ == 1).Select(x => x.full_adr).FirstOrDefault()
            },
            LawCourt = x.LawCourt != null ? new() { id = x.LawCourt.id, name = x.LawCourt.name, address = x.LawCourt.address } : null
        });
        var result1 = select1.ToList();
        var result2 = select2.ToList();
        LawActSource.DataSource = new SortableBindingList<LawActResult>(result1.Select(x => new LawActResult(x)).ToList());
        LawExecSource.DataSource = new SortableBindingList<LawExecResult>(result2.Select(x => new LawExecResult(x)).ToList());
    }
}
