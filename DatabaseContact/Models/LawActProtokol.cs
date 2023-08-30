﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

[Index("parent_id", Name = "IX_law_act_protokol$parent_id")]
[Table("law_act_protokol")]
public partial class LawActProtokol
{
    [Key]
    public int id { get; set; }

    public int? parent_id { get; set; }

    public int? r_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dt { get; set; }

    public int? typ { get; set; }

    public int? r_doc_attach_id { get; set; }

    public int? r_doc_link_id { get; set; }

    [StringLength(2000)]
    public string? dsc { get; set; }

    /// <summary>
    /// дата действия
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? ACTION_DT { get; set; }

    /// <summary>
    /// причина перевода в текущий статус (словарь 319 - иск/банкротство/правопреемство, 320 - приказ)
    /// </summary>
    public int? REASON { get; set; }
}