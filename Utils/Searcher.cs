﻿using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;



namespace DocumentAdder.Utils
{
    public class Searcher
    {
        private string _fio; //ФИО
        private string _id; //ID Дела
        private string _kd; //№ КД
        private string _exec_num; //№ Дела

        public Searcher(string fio, string debt_id, string kd, string exec_num)
        {
            _fio = fio;
            _id = debt_id;
            _kd = kd;
            _exec_num = exec_num;
        }
        public void GetTables(BindingSource LawActSource, BindingSource LawExecSource)
        {
            using var db = Program.factory_db.CreateDbContext();
            LawActSource.Clear();
            LawExecSource.Clear();

            var data1 = db.LawAct.Where(
                x => EF.Functions.Like(x.Person.f + x.Person.i + x.Person.o, $"{_fio}%")
                );
            var data2 = db.LawExec.Where(
                x => EF.Functions.Like(x.Person.f + x.Person.i + x.Person.o, $"{_fio}%")
                );
            if (_kd != "")
            {
                data1 = data1.Where(x => EF.Functions.Like(x.Debt.contract, _kd + "%"));
                data2 = data2.Where(x => EF.Functions.Like(x.Debt.contract, _kd + "%"));
            }
            if (_id != "")
            {
                data1 = data1.Where(x => EF.Functions.Like(x.id.ToString(), _id + "%"));
                data2 = data2.Where(x => EF.Functions.Like(x.id.ToString(), _id + "%"));
            }
            if (_exec_num != "")
            {
                data1 = data1.Where(x => EF.Functions.Like(x.exec_number, _exec_num + "%"));
                data2 = data2.Where(x => EF.Functions.Like(x.LawAct.exec_number, _exec_num + "%"));
            }
            var subquery1 = data1.Join(db.LawExec.GroupBy(x => x.r_act_id).
                Select(x => new
                {
                    r_act_id = x.Key,
                    court_doc_num = x.Max(a => a.court_doc_num),
                    court_date = x.Max(a => a.court_date)
                }),
                (x) => x.id,
                (x) => x.r_act_id,
                (x, y) => new
                {
                    LawAct = x,
                    LawExec = y
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
                fio = x.LawAct.Person.f + " " + x.LawAct.Person.i + " " + x.LawAct.Person.o,
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
                fio = x.Person.f + " " + x.Person.i + " " + x.Person.o,
                birth_date = x.Person.birth_date,
                contract = x.Debt.contract,
                fssp_doc_num = x.fssp_doc_num,
                court_doc_num = x.court_doc_num,
                fssp_name = x.LawCourt.name,
                fssp_address = x.LawCourt.address,
                court_name = x.LawAct.LawCourt.name,
                court_address = x.LawAct.LawCourt.address,
                exec_number = x.LawAct.exec_number,
                dsc = x.dsc,
                full_adr = x.Person.Addresses.Where(x => x.typ == 1).Select(x => x.full_adr).FirstOrDefault(),
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
}
