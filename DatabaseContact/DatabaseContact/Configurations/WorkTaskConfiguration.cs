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
    public partial class WorkTaskConfiguration : IEntityTypeConfiguration<WorkTask>
    {
        public void Configure(EntityTypeBuilder<WorkTask> entity)
        {
            entity.HasKey(e => e.id).IsClustered(false);

            entity.ToTable("work_task", tb =>
            {
                tb.HasComment("связь долга и оператора (соотн");
                tb.HasTrigger("tr_work_task_ai");
                tb.HasTrigger("tr_work_task_au");
            });

            entity.HasIndex(e => e.r_debt_id, "IX_work_task_r_debt_id").IsClustered();

            entity.Property(e => e.PLAN_FINISH_WORK_DATE).HasComment("Плановая дата завершения работы с должником");
            entity.Property(e => e.call_time).HasComment("дата и время для звонка должни");
            entity.Property(e => e.finish_work_date).HasComment("дата завершения работы с должн");
            entity.Property(e => e.office_time).HasComment("дата посещение офиса");
            entity.Property(e => e.prior).HasComment("приоритет (чем меньше тем выше");
            entity.Property(e => e.r_admin_id).HasComment("пользователь, который своим де");
            entity.Property(e => e.r_contact_id).HasComment("см. расшифровку внизу");
            entity.Property(e => e.r_debt_id).HasComment("ссылка на долг");
            entity.Property(e => e.r_user_id).HasComment("ссылка на оператора (users.id)");
            entity.Property(e => e.r_user_id_h).HasComment("ссылка на оператора (users.id)");
            entity.Property(e => e.r_user_id_l).HasComment("ссылка на оператора (users.id)");
            entity.Property(e => e.reason_hard).HasComment("причина перевода в legal (слов");
            entity.Property(e => e.reason_soft).HasComment("причина перевода в hard (слова");
            entity.Property(e => e.start_work_date).HasComment("дата начала работы с должником");

            entity.HasOne(d => d.r_user_id_hNavigation).WithMany(p => p.work_taskr_user_id_hNavigation).HasConstraintName("FK_work_task_r_user_id_h_users");

            entity.HasOne(d => d.r_user_id_lNavigation).WithMany(p => p.work_taskr_user_id_lNavigation).HasConstraintName("FK_work_task_r_user_id_l_users");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkTask> entity);
    }
}
