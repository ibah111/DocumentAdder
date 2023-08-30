using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace DatabaseContact.Models;
[Table("law_court")]
public partial class LawCourt
{
    [Key]
    public int id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? index_code { get; set; }

    [StringLength(200)]
    public string? name { get; set; }

    [StringLength(1000)]
    public string? address { get; set; }

    [StringLength(100)]
    public string? phone { get; set; }

    public int? court_typ { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? district { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// тип органа (1 - суд, 2 – исполнительный орган, 3 - нотариус)
    /// </summary>
    public int? typ { get; set; }

    [StringLength(256)]
    [Unicode(false)]
    public string? recipient { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? inn { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? kpp { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? bik { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? cur_account { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? corr_account { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? bank { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? kbk { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? okato { get; set; }

    public int? r_parent_id { get; set; }

    [Column("EXT_ID$")]
    [StringLength(64)]
    public string? EXT_ID_ { get; set; }

    /// <summary>
    /// Email адрес
    /// </summary>
    [StringLength(64)]
    public string? EMAIL { get; set; }

    /// <summary>
    /// Веб-сайт
    /// </summary>
    [StringLength(128)]
    public string? SITE { get; set; }

    /// <summary>
    /// тип нотариуса (словарь 342)
    /// </summary>
    public int? notary_typ { get; set; }

    /// <summary>
    /// нотариальный орган
    /// </summary>
    [StringLength(1000)]
    public string? notarial_authority { get; set; }

    /// <summary>
    /// код суда в ГАС Правосудие
    /// </summary>
    [StringLength(16)]
    public string? GAS_JUSTICE_CODE { get; set; }

    /// <summary>
    /// Признак &quot;Не используется&quot;
    /// </summary>
    public int? NOT_USED { get; set; }

    /// <summary>
    /// Код получателя
    /// </summary>
    [StringLength(16)]
    public string? RECIPIENT_CODE { get; set; }

    /// <summary>
    /// Филиал (Словарь №61)
    /// </summary>
    public int? FILIAL { get; set; }

    /// <summary>
    /// Номер лицевого счета в УФК (Заполняется только для ФССП)
    /// </summary>
    [StringLength(11)]
    public string? ACCOUNT_NUMBER { get; set; }

    /// <summary>
    /// Категория суда (Словарь №401)
    /// </summary>
    public int? COURT_CATEGORY { get; set; }

    /// <summary>
    /// Тип доверенности (Словарь №402)
    /// </summary>
    public int? POWER_OF_ATTORNEY_TYPE { get; set; }

    /// <summary>
    /// Источник (Словарь №403)
    /// </summary>
    public int? SOURCE_CODE { get; set; }

    /// <summary>
    /// казначейский счет
    /// </summary>
    [StringLength(32)]
    public string? TREASURY_ACCOUNT { get; set; }

    [InverseProperty(nameof(LawAct.LawCourt))]
    public virtual List<LawAct> LawActs { get; set; } = new();

    [InverseProperty(nameof(LawExec.LawCourt))]
    public virtual List<LawExec> LawExecs { get; set; } = new();

}


