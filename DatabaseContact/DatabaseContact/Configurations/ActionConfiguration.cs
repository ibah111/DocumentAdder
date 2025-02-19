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
    public partial class ActionConfiguration : IEntityTypeConfiguration<Models.Action>
    {
        public void Configure(EntityTypeBuilder<Models.Action> entity)
        {
            entity.HasIndex(e => new { e.r_user_id, e.dt }, "IX_actions_r_user_id&dt").HasFillFactor(85);

            entity.ToTable("actions");

            entity.Property(e => e.id).ValueGeneratedOnAdd();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Models.Action> entity);
    }
}
