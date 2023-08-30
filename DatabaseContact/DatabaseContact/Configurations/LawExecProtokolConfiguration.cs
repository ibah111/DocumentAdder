﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseContact.DatabaseContact.Configurations
{
    public partial class LawExecProtokolConfiguration : IEntityTypeConfiguration<LawExecProkokol>
    {
        public void Configure(EntityTypeBuilder<LawExecProkokol> entity)
        {

            entity.HasKey(e => e.id).HasName("law_exec_protokol_PK");

            entity.ToTable("law_exec_protokol");

            entity.Property(e => e.ACTION_DT).HasComment("дата действия");
            entity.Property(e => e.REASON).HasComment("причина перевода в текущий статус (словарь 321)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LawExecProkokol> entity);
    }
}
