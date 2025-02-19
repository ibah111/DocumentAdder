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
    public partial class PassportConfiguration : IEntityTypeConfiguration<Passport>
    {
        public void Configure(EntityTypeBuilder<Passport> entity)
        {

            entity.HasKey(e => e.id).HasName("passport_PK");

            entity.ToTable("passport");

            entity.Property(e => e.DOC_TYPE).HasComment("Тип документа, удостоверяющего личность (Словарь 335)");
            entity.Property(e => e.EXT_ID_).HasComment("используется в ETL");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Passport> entity);
    }
}
