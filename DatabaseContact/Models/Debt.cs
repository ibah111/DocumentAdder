﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

/// <summary>
/// информация о долге (кредите)
/// </summary>
[Index("contract", Name = "IX_debt_contract")]
[Index("parent_id", Name = "IX_debt_parent_id")]
[Index("r_portfolio_id", Name = "IX_debt_r_portfolio_id")]
[Index("status", Name = "IX_debt_status")]
[Table("debt")]
public partial class Debt
{
    /// <summary>
    /// ID долга
    /// </summary>
    [Key]
    public int id { get; set; }

    /// <summary>
    /// ссылка на person
    /// </summary>
    public int? parent_id { get; set; }

    [ForeignKey(nameof(parent_id))]
    [InverseProperty(nameof(Models.Person.Debts))]
    public virtual Person? Person { get; set; }

    /// <summary>
    /// название продукта
    /// </summary>
    [StringLength(256)]
    public string? name { get; set; }

    /// <summary>
    /// дата выдачи кредита
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? credit_date { get; set; }

    /// <summary>
    /// процентная ставка по кредиту
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? interest_rate { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? penalty { get; set; }

    /// <summary>
    /// дата выхода на просрочку
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? start_date { get; set; }

    /// <summary>
    /// крайний срок погашения
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? deadline { get; set; }

    /// <summary>
    /// cумма необходимая к погашению
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? debt_sum { get; set; }

    /// <summary>
    /// полный размер кредита
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? total_sum { get; set; }

    /// <summary>
    /// статус (словарь №6)
    /// </summary>
    public int? status { get; set; }

    /// <summary>
    /// комментарий
    /// </summary>
    [StringLength(512)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// номер договора с банком
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? contract { get; set; }

    /// <summary>
    /// лицевой счет должника
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? account { get; set; }

    /// <summary>
    /// город выдачи
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? city_name { get; set; }

    /// <summary>
    /// возможная минимальная сумма пл
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? min_sum { get; set; }

    /// <summary>
    /// валюта
    /// </summary>
    public int? currency { get; set; }

    /// <summary>
    /// тип продукта (словарь №11)
    /// </summary>
    public int? typ { get; set; }

    /// <summary>
    /// причина возникновения задолжен
    /// </summary>
    public int? reason { get; set; }

    /// <summary>
    /// начальная cумма, необходимая к
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? start_sum { get; set; }

    /// <summary>
    /// номер цвета, для внутреннего и
    /// </summary>
    public int? int_color { get; set; }

    /// <summary>
    /// признак отсутствия работы по д
    /// </summary>
    public int? flag_no_work { get; set; }

    /// <summary>
    /// пользователь call-центра, локи
    /// </summary>
    public int? r_lock_user_id { get; set; }

    /// <summary>
    /// результат работы с должником
    /// </summary>
    [StringLength(1024)]
    [Unicode(false)]
    public string? rep_text { get; set; }

    /// <summary>
    /// предложение по дальнейшей рабо
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? offer_text { get; set; }

    /// <summary>
    /// основной долг
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? basic_sum { get; set; }

    /// <summary>
    /// просроченный основной долг
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? exp_basic_sum { get; set; }

    /// <summary>
    /// проценты
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? percent_sum { get; set; }

    /// <summary>
    /// просроченные проценты
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? exp_percent_sum { get; set; }

    /// <summary>
    /// штрафы
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? penalty_sum { get; set; }

    /// <summary>
    /// пени
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? peni_sum { get; set; }

    /// <summary>
    /// комиссия
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? commission_sum { get; set; }

    /// <summary>
    /// гос. пошлина
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? due_sum { get; set; }

    /// <summary>
    /// ссылка на портфель
    /// </summary>
    public int? r_portfolio_id { get; set; }

    [ForeignKey(nameof(r_portfolio_id))]
    [InverseProperty(nameof(Models.Portfolio.Debts))]
    public virtual Portfolio? Portfolio { get; set; }

    /// <summary>
    /// состояние (словарь №29)
    /// </summary>
    public int? state { get; set; }

    /// <summary>
    /// предыдущее состояние (словарь 
    /// </summary>
    public int? prev_state { get; set; }

    /// <summary>
    /// регион (словарь №39)
    /// </summary>
    public int? filial { get; set; }

    /// <summary>
    /// Количество дней просрочки
    /// </summary>
    public int? dpd { get; set; }

    /// <summary>
    /// часовой пояс (словарь №51)
    /// </summary>
    public int? gmt { get; set; }

    /// <summary>
    /// ID в главной БД
    /// </summary>
    [Column("id$")]
    public int? id_ { get; set; }

    /// <summary>
    /// дата расчета остатка
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? debt_dt { get; set; }

    /// <summary>
    /// дата локирования
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? lock_dt { get; set; }

    /// <summary>
    /// дата загрузки
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? load_dt { get; set; }

    /// <summary>
    /// дата актуальности остатка
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? debt_exp_dt { get; set; }

    /// <summary>
    /// кол-во обработок должника в ca
    /// </summary>
    public int? lock_cnt { get; set; }

    /// <summary>
    /// комиссия агента
    /// </summary>
    public float? agency_rate { get; set; }

    /// <summary>
    /// остаток основного долга
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? total_rest { get; set; }

    /// <summary>
    /// филиал (Словарь №61)
    /// </summary>
    public int? filial_new { get; set; }

    /// <summary>
    /// ID в системе клиента
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? ext_id { get; set; }

    /// <summary>
    /// последний платеж
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? last_pay { get; set; }

    [Column(TypeName = "money")]
    public decimal? exp_commission_sum { get; set; }

    /// <summary>
    /// флаг &quot;Профилактика&quot;
    /// </summary>
    public int? flag_preventive { get; set; }

    /// <summary>
    /// переплата
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? debt_sum_extra { get; set; }

    /// <summary>
    /// сумма полследнего платежа
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? last_pay_sum { get; set; }

    /// <summary>
    /// указывает, что есть судебное д
    /// </summary>
    public int? law_act_flag { get; set; }

    /// <summary>
    /// указывает, что есть ИП
    /// </summary>
    public int? law_exec_flag { get; set; }

    public int? use_strategy { get; set; }

    public int? strategy_id { get; set; }

    public int? strategy_day { get; set; }

    public int? strategy_block { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? strategy_dt { get; set; }

    /// <summary>
    /// ссылка последний на платеж, из
    /// </summary>
    public int? r_calc_id { get; set; }

    /// <summary>
    /// словарь №101 (атрибут, доступн
    /// </summary>
    public int? mark1 { get; set; }

    /// <summary>
    /// словарь №102 (атрибут, доступн
    /// </summary>
    public int? mark2 { get; set; }

    /// <summary>
    /// акция
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? stock { get; set; }

    /// <summary>
    /// дата следующего платежа
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? next_pay { get; set; }

    /// <summary>
    /// точка продаж
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? pos_name { get; set; }

    /// <summary>
    /// суммa остатка на счете заемщик
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? sum_on_bank_account { get; set; }

    /// <summary>
    /// суммa аннуитетного платежа
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? annuity_pay { get; set; }

    /// <summary>
    /// единовременный штраф
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? fine_sum { get; set; }

    /// <summary>
    /// сумма следующего платежа
    /// </summary>
    [Column(TypeName = "money")]
    public decimal? next_pay_sum { get; set; }

    public int? r_portfolio_out_id { get; set; }

    /// <summary>
    /// Дата формирования заявки для п
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? archive_dt { get; set; }

    /// <summary>
    /// причина смены статуса
    /// </summary>
    public int? reason_status { get; set; }

    public int? MARK3 { get; set; }

    public int? MARK4 { get; set; }

    public int? TEST_ID { get; set; }

    /// <summary>
    /// Дата пролонгации
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? EXTENTION_DT { get; set; }

    /// <summary>
    /// Ссылка на банковские реквизиты
    /// </summary>
    public int? R_BANK_REQUISITE_ID { get; set; }

    /// <summary>
    /// ссылка на правило расчета остатков
    /// </summary>
    public int? R_CALC_RULE_ID { get; set; }

    [InverseProperty(nameof(LawAct.Debt))]
    public virtual List<LawAct> LawActs { get; set; } = new();

    [InverseProperty(nameof(LawExec.Debt))]
    public virtual List<LawExec> LawExecs { get; set; } = new();

    [InverseProperty(nameof(Models.WorkTask.Debt))]
    public virtual WorkTask? WorkTask { get; set; }

    [InverseProperty(nameof(DebtCalc.Debt))]
    public virtual List<DebtCalc> DebtCalcs { get; set; } = new();

    [InverseProperty(nameof(Models.DebtGuarantor.Debt))]
    public virtual DebtGuarantor? DebtGuarantor { get; set; } = new();

}