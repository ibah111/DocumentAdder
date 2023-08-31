﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

/// <summary>
/// информация о пользователе сист
/// </summary>
[Table("users")]
public partial class User
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// логин
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? login { get; set; }

    /// <summary>
    /// пароль
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? password { get; set; }

    /// <summary>
    /// фамилия
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? f { get; set; }

    /// <summary>
    /// имя
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? i { get; set; }

    /// <summary>
    /// отчество
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? o { get; set; }

    /// <summary>
    /// ссылка на роль
    /// </summary>
    public int? r_role_id { get; set; }

    /// <summary>
    /// признак &quot;заблокировать логин&quot;
    /// </summary>
    public int? block_flag { get; set; }

    /// <summary>
    /// комментарий
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// тип (soft или hard)
    /// </summary>
    [StringLength(16)]
    [Unicode(false)]
    public string? depart { get; set; }

    /// <summary>
    /// внутр. тел.
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? int_num { get; set; }

    /// <summary>
    /// моб. тел.
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? mob_num { get; set; }

    /// <summary>
    /// ссылка на график
    /// </summary>
    public int? r_timetable_id { get; set; }

    /// <summary>
    /// ссылка на подразделение (depar
    /// </summary>
    public int? r_department_id { get; set; }

    /// <summary>
    /// 0 или NULL, если обычный, 1 - 
    /// </summary>
    public int? depart_status { get; set; }

    /// <summary>
    /// должность
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? position { get; set; }

    /// <summary>
    /// ранг
    /// </summary>
    public int? rank { get; set; }

    /// <summary>
    /// имя пользователя Windows
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? win_user_name { get; set; }

    /// <summary>
    /// раб. тел.
    /// </summary>
    [StringLength(128)]
    [Unicode(false)]
    public string? work_num { get; set; }

    /// <summary>
    /// флаг &quot;перезакреплять при обеща
    /// </summary>
    public int? prom_trans { get; set; }

    /// <summary>
    /// филиал. Словарь 61.
    /// </summary>
    public int? filial { get; set; }

    /// <summary>
    /// ссылка на план сбора
    /// </summary>
    public int? r_collection_plan_id { get; set; }

    [Column("dt1$", TypeName = "datetime")]
    public DateTime? dt1_ { get; set; }

    /// <summary>
    /// подпись
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? mail_sign { get; set; }

    /// <summary>
    /// ID Агента (Идентификатор агент
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? agent_id { get; set; }

    /// <summary>
    /// № агента СС
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? agent_number { get; set; }

    /// <summary>
    /// признак виртуальности оператор
    /// </summary>
    public int? is_virtual { get; set; }

    /// <summary>
    /// дата выхода сотрудника в штат
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? start_work_date { get; set; }

    public int? oper_id { get; set; }

    /// <summary>
    /// электронная почта оператора
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? email { get; set; }

    /// <summary>
    /// табельный номер
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? emp_number { get; set; }

    /// <summary>
    /// дата последней смены пароля
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? password_change_dt { get; set; }

    /// <summary>
    /// дата увольнения
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? finish_work_date { get; set; }

    /// <summary>
    /// пароль агента
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? agent_pass { get; set; }

    /// <summary>
    /// имя агента
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? agent_name { get; set; }

    [StringLength(38)]
    [Unicode(false)]
    public string? sid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sid_dt { get; set; }

    /// <summary>
    /// рабочий адрес
    /// </summary>
    [StringLength(256)]
    [Unicode(false)]
    public string? work_address { get; set; }

    /// <summary>
    /// индекс рабочего адреса
    /// </summary>
    [StringLength(32)]
    [Unicode(false)]
    public string? work_zip_code { get; set; }

    /// <summary>
    /// Геолокация - широта
    /// </summary>
    [Column(TypeName = "numeric(18, 6)")]
    public decimal? latitude { get; set; }

    /// <summary>
    /// Геолокация - долгота
    /// </summary>
    [Column(TypeName = "numeric(18, 6)")]
    public decimal? longitude { get; set; }

    /// <summary>
    /// Квалификация пользователя (Словарь №237)
    /// </summary>
    public int? skill { get; set; }

    /// <summary>
    /// ссылка на подразделение (depar
    /// </summary>
    public int? R_DEPARTMENT_ID2 { get; set; }

    public int? SKIN { get; set; }

    public int? typ { get; set; }

    public int? r_person_anket_id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? room { get; set; }

    /// <summary>
    ///  В новый Combobox подгружать з
    /// </summary>
    public int? DICT_VALUE_1 { get; set; }

    /// <summary>
    /// язык пользователя (словарь 78)
    /// </summary>
    public int? LANG { get; set; }

    /// <summary>
    /// Ключ агента телефонии в JSON с
    /// </summary>
    [StringLength(128)]
    public string? AGENT_KEY { get; set; }

    /// <summary>
    /// Токен агента телефонии в JSON 
    /// </summary>
    [StringLength(1024)]
    public string? AGENT_TOKEN { get; set; }

    /// <summary>
    /// Тип сервера телефонии (словарь
    /// </summary>
    public int? AGENT_SERVER_TYPE { get; set; }

    /// <summary>
    /// дата последнего изменения
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CHANGE_DT { get; set; }

    /// <summary>
    /// Идентификатор в системе CASEPRO
    /// </summary>
    [Column("EXT_ID$")]
    [StringLength(64)]
    public string? EXT_ID_ { get; set; }

    /// <summary>
    /// Дата блокировки пользователя 
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? BLOCK_DT { get; set; }

    /// <summary>
    /// Причина блокировки пользователя (словарь № 396)
    /// </summary>
    public int? BLOCK_REASON { get; set; }

    /// <summary>
    /// Код должности по словарю № 404
    /// </summary>
    public int? POSITION_CODE { get; set; }

    [InverseProperty("r_user_id_hNavigation")]
    public virtual ICollection<WorkTask> work_taskr_user_id_hNavigation { get; set; } = new List<WorkTask>();

    [InverseProperty("r_user_id_lNavigation")]
    public virtual ICollection<WorkTask> work_taskr_user_id_lNavigation { get; set; } = new List<WorkTask>();

    [InverseProperty(nameof(WorkTask.User))]
    public virtual List<WorkTask> WorkTasks { get; set; } = new();

    [InverseProperty(nameof(LawAct.User))]
    public virtual List<LawAct> LawActs { get; set; } = new();

    [InverseProperty(nameof(LawExec.User))]
    public virtual List<LawExec> LawExecs { get; set; } = new();

    [InverseProperty(nameof(LawActProtokol.User))]
    public virtual List<LawActProtokol> LawActProtokols { get; set; } = new();

    [InverseProperty(nameof(LawExecProtokol.User))]
    public virtual List<LawExecProtokol> LawExecProtokols { get; set; } = new();

    [InverseProperty(nameof(LawActDscLog.User))]
    public virtual List<LawActDscLog> LawActDscLogs { get; set; } = new();

    [InverseProperty(nameof(LawExecDscLog.User))]
    public virtual List<LawExecDscLog> LawExecDscLogs { get; set; } = new();

    [InverseProperty(nameof(DebtCalc.User))]
    public virtual List<DebtCalc> DebtCalcs { get; set; } = new();
}