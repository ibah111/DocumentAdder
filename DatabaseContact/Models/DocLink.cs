﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;
[Table("doc_links")]
public partial class DocLink
{
    [Key]
    public int id { get; set; }

    public int obj_id { get; set; }

    public int r_id { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? filename { get; set; }

    [StringLength(512)]
    public string? filepath { get; set; }

    public int? link_typ { get; set; }

    public int? r_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dt { get; set; }

    /// <summary>
    /// дата последнего изменения
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CHANGE_DT { get; set; }

    /// <summary>
    /// размер файла
    /// </summary>
    public int? DOC_SIZE { get; set; }

    /// <summary>
    /// Внешний идентификатор
    /// </summary>
    [StringLength(32)]
    public string? EXT_ID { get; set; }

    /// <summary>
    /// Техническое поле типа словарь 1
    /// </summary>
    public int? DICT_VALUE_1 { get; set; }

    /// <summary>
    /// Техническое поле типа дата 1
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? DT_VALUE_1 { get; set; }

    /// <summary>
    /// Пользователь, загрузивший документ
    /// </summary>
    public int? R_CREATE_USER_ID { get; set; }
}