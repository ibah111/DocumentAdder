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
    public partial class ConstValueConfiguration : IEntityTypeConfiguration<ConstValue>
    {
        public void Configure(EntityTypeBuilder<ConstValue> entity)
        {
            entity.HasKey(e => e.id).HasName("const_value_PK");

            entity.ToTable("const_value", tb =>
            {
                tb.HasComment("информация о значении константы");
                tb.HasTrigger("const_value_change");
                tb.HasTrigger("tr_const_value_bidu");
            });

            entity.Property(e => e.id).HasComment("");
            entity.Property(e => e.change_dt).HasComment("дата изменения записи");
            entity.Property(e => e.dsc).HasComment("комментарий");
            entity.Property(e => e.name).HasComment("название");
            entity.Property(e => e.typ).HasComment("тип константы (словарь №8)");
            entity.Property(e => e.value).HasComment("значение константы в текстовой");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ConstValue> entity);
    }
}
