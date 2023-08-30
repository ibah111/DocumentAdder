﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

/// <summary>
/// информация о значении константы
/// </summary>
[Index("name", Name = "IX_const_value_name")]
[Table("const_table")]
public partial class ConstValue
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// название
    /// </summary>
    [StringLength(64)]
    [Unicode(false)]
    public string? name { get; set; }

    /// <summary>
    /// комментарий
    /// </summary>
    [StringLength(512)]
    [Unicode(false)]
    public string? dsc { get; set; }

    /// <summary>
    /// тип константы (словарь №8)
    /// </summary>
    public int? typ { get; set; }

    /// <summary>
    /// значение константы в текстовой
    /// </summary>
    [StringLength(1024)]
    public string? value { get; set; }

    /// <summary>
    /// дата изменения записи
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? change_dt { get; set; }

    public int? kind { get; set; }

    [StringLength(512)]
    public string? DSC2 { get; set; }

    [StringLength(1024)]
    public string? VALUE_DEFAULT { get; set; }
}