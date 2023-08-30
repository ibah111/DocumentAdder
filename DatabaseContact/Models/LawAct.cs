﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

/// <summary>
/// информация о судебной работе
/// </summary>
[Index("r_person_id", Name = "IX_LAW_ACT_R_PERSON_ID")]
[Index("r_user_id", Name = "IX_LAW_ACT_R_USER_ID")]
[Index("r_debt_id", Name = "IX_law_act_r_debt_id")]
[Table("law_act")]
public partial class LawAct
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// ссылка на person
    /// </summary>
    public int? r_person_id { get; set; }

    [ForeignKey(nameof(r_person_id))]
    [InverseProperty(nameof(Models.Person.LawActs))]
    public virtual Person? Person { get; set; }

    /// <summary>
    /// ссылка на debt
    /// </summary>
    public int? r_debt_id { get; set; }

    [ForeignKey(nameof(r_debt_id))]
    [InverseProperty(nameof(Models.Debt.LawActs))]
    public virtual Debt? Debt { get; set; }

    /// <summary>
    /// ссылка на portfolio
    /// </summary>
    public int? r_portfolio_id { get; set; }

    [ForeignKey(nameof(r_portfolio_id))]
    [InverseProperty(nameof(Models.Portfolio.LawActs))]
    public virtual Portfolio? Portfolio { get; set; }

    /// <summary>
    /// тип суд. работы (0 - неопределенное суд. дело, 1 - приказ, 2 - иск, 3 - правопреемство, 4 - банкротство, 5 – исполнительная надпись)
    /// </summary>
    public int? typ { get; set; }

    /// <summary>
    /// дата поступления дела
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? fd { get; set; }

    /// <summary>
    /// название суда (устар.)
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? court_name { get; set; }

    /// <summary>
    /// территориальность и адрес суда
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? court_adres { get; set; }

    /// <summary>
    /// родовая подсудность (словарь №
    /// </summary>
    public int? court_kind { get; set; }

    /// <summary>
    /// тип суда (словарь №15)
    /// </summary>
    public int? court_typ { get; set; }

    /// <summary>
    /// размер пошлины
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? due_sum { get; set; }

    /// <summary>
    /// размер требования по заявлению
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? total_sum { get; set; }

    /// <summary>
    /// дата подачи заявления в суд
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? start_date { get; set; }

    /// <summary>
    /// способ доставки заявления в су
    /// </summary>
    public int? delivery_typ { get; set; }

    /// <summary>
    /// период ожидания вынесения суде
    /// </summary>
    public int? court_order_period { get; set; }

    /// <summary>
    /// дата отправки судебного приказ
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? court_order_date { get; set; }

    /// <summary>
    /// способ доставки судебного прик
    /// </summary>
    public int? court_order_delivery { get; set; }

    /// <summary>
    /// дата получения судебного прика
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? receipt_date { get; set; }

    /// <summary>
    /// статус (словарь №18)
    /// </summary>
    public int? status { get; set; }

    /// <summary>
    /// укомплектованность (словарь №1
    /// </summary>
    public int? full_strength { get; set; }

    /// <summary>
    /// ФИО судьи (предв. заседание) (
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? court_pre_fio { get; set; }

    /// <summary>
    /// дата предв. заседания (не испо
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? court_pre_date { get; set; }

    /// <summary>
    /// определение вынесенное на пред
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? court_pre_def { get; set; }

    /// <summary>
    /// ФИИ судьи (не используется)
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? court_fio { get; set; }

    /// <summary>
    /// дата заседания (не используетс
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? court_date { get; set; }

    /// <summary>
    /// определение вынесенное на засе
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? court_def { get; set; }

    /// <summary>
    /// статус иска (словарь №25)
    /// </summary>
    public int? act_status { get; set; }

    /// <summary>
    /// крайний срок подачи
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? deadline { get; set; }

    /// <summary>
    /// комментарий
    /// </summary>
    [StringLength(4000)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// указания руководителя
    /// </summary>
    [StringLength(512)]
    [Unicode(false)]
    public string? instruct { get; set; }

    /// <summary>
    /// ссылка на users
    /// </summary>
    public int? r_user_id { get; set; }

    [ForeignKey(nameof(r_user_id))]
    [InverseProperty(nameof(Models.User.LawActs))]
    public virtual User? User { get; set; }

    /// <summary>
    /// ссылка на law_court
    /// </summary>
    public int? r_court_id { get; set; }

    /// <summary>
    /// утвержденный размер пошлины
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? due_conf_sum { get; set; }

    /// <summary>
    /// номер договора
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? contract { get; set; }

    /// <summary>
    /// валюта
    /// </summary>
    public int? currency { get; set; }

    /// <summary>
    /// дата вступления в силу (иска)
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? court_exec_date { get; set; }

    /// <summary>
    /// цвет
    /// </summary>
    public int? int_color { get; set; }

    /// <summary>
    /// название продукта
    /// </summary>
    [StringLength(256)]
    public string? name { get; set; }

    /// <summary>
    /// тип продукта (ссылка на словар
    /// </summary>
    public int? typ_name { get; set; }

    /// <summary>
    /// номер документа (приказа/иска)
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? exec_number { get; set; }

    /// <summary>
    /// дата документа (приказа/иска)
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? exec_date { get; set; }

    /// <summary>
    /// дата загрузки\формирования дел
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? load_dt { get; set; }

    /// <summary>
    /// дата получения исп листа на об
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? receipt_act_dt { get; set; }

    /// <summary>
    /// дата получения исп.листа
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? receipt_dt { get; set; }

    /// <summary>
    /// Сумма по решению суда
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? court_sum { get; set; }

    /// <summary>
    /// дата расторжения договора
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? terminate_contract_dt { get; set; }

    /// <summary>
    /// сумма мирового соглашения
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? settlement_sum { get; set; }

    /// <summary>
    /// дата мирового соглашения
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? settlement_date { get; set; }

    /// <summary>
    /// УСТАРЕЛО, ВПОСЛЕДСВИИ БУДЕТ УД
    /// </summary>
    public int? is_obtain_contract { get; set; }

    /// <summary>
    /// УСТАРЕЛО, ВПОСЛЕДСВИИ БУДЕТ УД
    /// </summary>
    public int? is_entire_amount { get; set; }

    /// <summary>
    /// дата отказа
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? failure_date { get; set; }

    /// <summary>
    /// дата срока исполнения недостат
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? correct_period_date { get; set; }

    /// <summary>
    /// дата оплаты госпошлины
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? due_pay_date { get; set; }

    /// <summary>
    /// номер платежного поручения
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? due_pay_num { get; set; }

    /// <summary>
    /// результат длеа (ссылка на слов
    /// </summary>
    public int? user_result { get; set; }

    /// <summary>
    /// судья (ссылка на law_r_judge_i
    /// </summary>
    public int? r_judge_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? basic_sum { get; set; }

    [Column(TypeName = "money")]
    public decimal? commission_sum { get; set; }

    [Column(TypeName = "money")]
    public decimal? peni_basic_sum { get; set; }

    [Column(TypeName = "money")]
    public decimal? peni_commission { get; set; }

    [Column(TypeName = "money")]
    public decimal? peni_percent { get; set; }

    [Column(TypeName = "money")]
    public decimal? peni_sum { get; set; }

    [Column(TypeName = "money")]
    public decimal? percent_sum { get; set; }

    /// <summary>
    /// тип иска (0,null - исходящий, 
    /// </summary>
    public int? act_direct { get; set; }

    /// <summary>
    /// дата перевода в архивный стату
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? dt_to_archive { get; set; }

    /// <summary>
    /// входящий номер (используется д
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? inner_number { get; set; }

    [Column(TypeName = "money")]
    public decimal? PENALTY_SUM { get; set; }

    /// <summary>
    /// статус судебного дела (ссылка 
    /// </summary>
    public int? PRE_ACT_STATUS { get; set; }

    /// <summary>
    /// Примечание судебного дела (Словарь №247)
    /// </summary>
    public int? dict_value_1 { get; set; }

    /// <summary>
    /// адрес, по которому на должника
    /// </summary>
    public int? r_address_id { get; set; }

    [Column("ext_id$")]
    public int? ext_id_ { get; set; }

    /// <summary>
    /// ссылка на родительский иск
    /// </summary>
    public int? R_LAW_ACT_ID { get; set; }

    /// <summary>
    /// Предмет иска (словарь №327)
    /// </summary>
    public int? ACT_SUBJECT { get; set; }

    /// <summary>
    /// Техническое поле типа строка 1
    /// </summary>
    [StringLength(256)]
    public string? STRING_VALUE_1 { get; set; }

    /// <summary>
    /// Ссылка на объединенное судебное дело
    /// </summary>
    public int? R_COMMON_LAW_ACT_ID { get; set; }

    /// <summary>
    /// Техническое поле типа дата 1
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DT_VALUE_1 { get; set; }

    /// <summary>
    /// Техническое поле типа число 1
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? NUMBER_VALUE_1 { get; set; }

    /// <summary>
    /// Основания отказа суда от полного удовлетворения иска (словарь №406)
    /// </summary>
    public int? REFUSAL_REASON { get; set; }

    [InverseProperty(nameof(LawActProtokol.LawAct))]
    public virtual List<LawActProtokol> LawActProtokols { get; set; } = new();

    [InverseProperty(nameof(LawActDscLog.LawAct))]
    public virtual List<LawActDscLog> LawActDscLogs { get; set; } = new();

    [InverseProperty(nameof(LawExec.LawAct))]
    public virtual List<LawExec> LawExecs { get; set; } = new();
}