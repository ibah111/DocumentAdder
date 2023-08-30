﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContact.Models;

[Index("R_LAW_ACT_ID", Name = "IX_LAW_ACT_PERSON_LINK_ACT_ID")]
[Table("LAW_ACT_PERSON_LINK")]
public partial class LawActPersonLink
{
    /// <summary>
    /// идентификатор записи
    /// </summary>
    [Key]
    public int ID { get; set; }

    /// <summary>
    /// ID дела
    /// </summary>
    public int? R_LAW_ACT_ID { get; set; }

    /// <summary>
    /// Тип связи (1-Ответчик/2-Истец/3-Третье лицо)
    /// </summary>
    public int? LINK_TYPE { get; set; }

    /// <summary>
    /// Роль участника договора в судебном процессе по словарю №235
    /// </summary>
    public int? PERSON_ROLE { get; set; }

    /// <summary>
    /// Ссылка на физ. или юр. лицо (таблицы person, debt_guarantor)
    /// </summary>
    public int? PERSON_ID { get; set; }
}