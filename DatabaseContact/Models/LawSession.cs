#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace DatabaseContact.Models;

[Table("law_session")]
public partial class LawSession
{
    [Key]
    public int id { get; set; }

    public int? parent_id { get; set; }

    [ForeignKey(nameof(parent_id))]
    [InverseProperty(nameof(Models.LawAct.LawSessions))]
    public virtual LawAct? LawAct { get; set; }

    public int? r_debt_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dt { get; set; }

    public int? r_judge_id { get; set; }

    public int? status { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? decision { get; set; }

    public int? result { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// тип судебного заседания (слова
    /// </summary>
    public int? TYP { get; set; }
}

