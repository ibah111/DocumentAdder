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
    public partial class LawActDscLogConfiguration : IEntityTypeConfiguration<LawActDscLog>
    {
        public void Configure(EntityTypeBuilder<LawActDscLog> entity)
        {

            entity.HasKey(e => e.id).HasName("PK__law_act_dsc_log__12D3B480");

            entity.ToTable("law_act_dsc_log");

            entity.Property(e => e.dsc).HasComment("комментарий");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LawActDscLog> entity);
    }
}
