using DocumentAdder.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Windows.Forms;



namespace DocumentAdder.Utils
{
    public class Searcher
    {
        private string _last_name; //Фамилия
        private string _first_name; //имя
        private string _middle_name; //Отчество
        private string _id; //ID Дела
        private string _kd; //№ КД
        private string _exec_num; //№ Дела

        public Searcher(string last_name, string first_name, string middle_name, string debt_id, string kd, string exec_num)
        {
            _last_name = last_name;
            _first_name = first_name;
            _middle_name = middle_name;
            _id = debt_id;
            _kd = kd;
            _exec_num = exec_num;
        }
        public void GetTables(DataGridView dataGridView1, DataGridView dataGridView2, DataSet1 dataSet1)
        {
            dataSet1.Clear();
            if (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Clear();
            if (dataGridView2.Rows.Count != 0)
                dataGridView2.Rows.Clear();
            string where = GetSQL("la.");

            /*Settings.command = "select TOP(100) la.id,case la.typ when 0 then 'Неопределен' when 1 then 'Приказ' when 2 then 'Иск' when 3 then 'Правопреемство' when 4 then 'Банкротство' end typ," +
                "case la.typ when 2 then (select name from dict where parent_id = 25 and code = la.act_status) else (select name from dict where parent_id = 18 and code = la.status) end status," +
                " u.f+' '+u.i+' '+u.o fio_vz, la.name,pr.name,p.f+' '+p.i+' '+p.o,p.birth_date,la.contract, la.exec_number,	lc.name," +
                "convert(varchar,la.total_sum) + ' Руб', la.dsc from law_act la left join person p on p.id = la.r_person_id " +
                "left join law_court lc on lc.id=la.r_court_id 	left join portfolio pr on pr.id = la.r_portfolio_id left join work_task wt on wt.r_debt_id = la.r_debt_id left join users u on u.id = wt.r_user_id" +
                $" where {where}";*/

            var data = Program.db.LawAct.Where(
                x => EF.Functions.Like(x.Person.f + x.Person.i + x.Person.o, $"{_last_name}{_first_name}{_middle_name}%")
                );
            if (_kd != "")
                data = data.Where(x => EF.Functions.Like(x.Debt.contract, _kd + "%"));
            if (_id != "")
                data = data.Where(x => EF.Functions.Like(x.id.ToString(), _id + "%"));
            var subquery = Program.db.LawExec.GroupBy(x => x.r_act_id).Select(x => new { r_act_id = x.Key, court_doc_num = x.Max(a => a.court_doc_num), court_date = x.Max(a => a.court_date) });
            var newData = data.Join(subquery, (x) => x.id, (x) => x.r_act_id, (x, y) => new { LawAct = x, LawExec = y });
            var select = newData.Select(x => new LawActResult()
            {
                id = x.LawAct.id,
                typ = x.LawAct.typ,
                status = x.LawAct.status,
                act_status = x.LawAct.act_status,
                fio_vz = x.LawAct.User.f + " " + x.LawAct.User.i + " " + x.LawAct.User.o,
                name = x.LawAct.name,
                portfolio = x.LawAct.Portfolio.name,
                fio = x.LawAct.Person.f + " " + x.LawAct.Person.i + " " + x.LawAct.Person.o,
                birth_date = x.LawAct.Person.birth_date,
                contract = x.LawAct.Debt.contract,
                exec_number = x.LawAct.exec_number,
                total_sum = x.LawAct.total_sum.ToString() + " Руб",
                dsc = x.LawAct.dsc,
                court_doc_num = x.LawExec.court_doc_num,
                court_date = x.LawExec.court_date.Value.ToShortDateString(),
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
            var result = select.ToList();

            Settings.command = "select TOP(100) la.id,case la.typ when 0 then 'Неопределен' when 1 then 'Приказ' when 2 then 'Иск' when 3 then 'Правопреемство' when 4 then 'Банкротство' end typ, " +
            "case when la.typ > 2 then (select name from dict where parent_id = 25 and code = la.act_status) else (select name from dict where parent_id = 18 and code = la.status) end status, " +
            "u.f+' '+u.i+' '+u.o fio_vz, la.name, pr.name,p.f+' '+p.i+' '+p.o,p.birth_date,d.contract, la.exec_number, lc.name, " +
            "convert(varchar,la.total_sum) + ' Руб', la.dsc, le.court_doc_num,CONVERT(varchar, le.court_date, 104) court_date,lc.name court_name, lc.address court_adress,cast(d.start_sum as decimal(16,2)) start_sum, " +
            "pass.number,pass.series,p.birth_place, a.full_adr, la.court_order_date exec_date, p.inn from law_act la " +
            "left join person p on p.id = la.r_person_id " +
            "left join law_court lc on lc.id = la.r_court_id " +
            "left join portfolio pr on pr.id = la.r_portfolio_id " +
            "left join work_task wt on wt.r_debt_id = la.r_debt_id " +
            "left join users u on u.id = wt.r_user_id " +
            "left join (select r_act_id, max(court_doc_num) court_doc_num,max(court_date) court_date from law_exec GROUP BY r_act_id) le on le.r_act_id = la.id " +
            "left join debt d on d.id = la.r_debt_id " +
            "left join passport pass on pass.id=p.r_passport_id " +
            "left join address a on a.parent_id = p.id and a.typ=1 " +
            $"where {where}";
            using (OdbcDataAdapter dataAdapter = new OdbcDataAdapter(Settings.command, Program.Conn))
            {
                dataAdapter.Fill(dataSet1.DataTable1);
            }
            string where1 = GetSQL("le.");
            /*Settings.command1 = "select TOP(100) le.id,(select name from dict where parent_id = 77 and code = le.state) Status,(select name from dict where parent_id = 6 and code=d.status) Debt_status," +
                "u.f+' '+u.i+' '+u.o fio_vz,pr.name,p.f+' '+p.i+' '+p.o,p.birth_date,le.contract,le.fssp_doc_num , le.court_doc_num,lc.name,convert(varchar,la.total_sum) + ' Руб',lc1.name,la.exec_number," +
                " le.dsc from law_exec le left join person p on p.id = le.r_person_id left join portfolio pr on pr.id = le.r_portfolio_id left join law_act la on la.id=le.r_act_id " +
                "left join debt d on d.id = le.r_debt_id left join law_court lc on lc.id=le.r_court_id left join law_court lc1 on lc1.id = la.r_court_id left join work_task wt on wt.r_debt_id = la.r_debt_id" +
                " left join users u on u.id = wt.r_user_id " +
                $" where {where1} and le.state != 5 and le.state != 6";*/
            Settings.command1 = "select TOP(100) le.id,(select name from dict where parent_id = 77 and code = le.state) Status,(select name from dict where parent_id = 6 and code=d.status) Debt_status, " +
                "u.f+' '+u.i+' '+u.o fio_vz,pr.name,p.f+' '+p.i+' '+p.o,p.birth_date,d.contract,le.fssp_doc_num , le.court_doc_num,lc.name,convert(varchar,la.total_sum) + ' Руб',lc1.name,la.exec_number, " +
                "le.dsc, CONVERT(varchar, le.court_date, 104) court_date1,lc1.address court_adress1,cast(d.start_sum as decimal(16,2)) start_sum1, pass.number number1,pass.series series1,p.birth_place birth_place1, " +
                "a.full_adr full_adr1, la.court_order_date exec_date1, p.inn inn1 from law_exec le " +
                "left join person p on p.id = le.r_person_id " +
                "left join portfolio pr on pr.id = le.r_portfolio_id " +
                "left join law_act la on la.id=le.r_act_id " +
                "left join debt d on d.id = le.r_debt_id " +
                "left join law_court lc on lc.id=le.r_court_id " +
                "left join law_court lc1 on lc1.id = la.r_court_id " +
                "left join work_task wt on wt.r_debt_id = la.r_debt_id " +
                "left join users u on u.id = wt.r_user_id " +
                "left join passport pass on pass.id=p.r_passport_id " +
                "left join address a on a.parent_id = p.id and a.typ=1 " +
                $" where {where1} and le.state != 5 and le.state != 6";
            using (OdbcDataAdapter dataAd = new OdbcDataAdapter(Settings.command1, Program.Conn))
            {
                dataAd.Fill(dataSet1.DataTable2);
            }
            dataGridView1.DataSource = result;
            dataGridView2.DataSource = dataSet1.DataTable2;
        }

        private string GetSQL(string prefix)
        {
            List<string> list = new List<string>();
            if (_last_name != "")
                list.Add($"p.f like \'{_last_name}%\'");
            if (_first_name != "")
                list.Add($"p.i like \'{_first_name}%\'");
            if (_middle_name != "")
                list.Add($"p.o like \'{_middle_name}%\'");
            if (_id != "")
                list.Add($"{prefix}id like \'{_id}%\'");
            if (_kd != "")
                list.Add($"d.contract like \'{_kd}%\'");
            if (_exec_num != "")
                list.Add($"la.exec_number like \'{_exec_num}%\'");
            return string.Join(" and ", list);
        }
    }
}
