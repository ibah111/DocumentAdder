using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace DatabaseContact.DatabaseContact.Configurations
{
    public partial class DictNameConfiguration : IEntityTypeConfiguration<DictName>
    {
        public void Configure(EntityTypeBuilder<DictName> entity)
        {
            entity.ToTable("dict_name", tb =>
            {
                tb.HasComment("описатель словаря");
                tb.HasTrigger("tr_dict_name_bidu");
            });

            entity.Property(e => e.code)
            .ValueGeneratedNever()
            .HasComment("номер словаря");
            entity.Property(e => e.NAME2).HasComment("название на альтернативном языке");
            entity.Property(e => e.NOT_USE).HasComment("признак отсутствия использования словаря у Клиента. 1 – словарь не используется. Иначе – используется");
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.r_code).HasComment("код родительского словаря");
            entity.Property(e => e.typ).HasComment("1 - системный, 2 - общий");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DictName> entity);
    }
}
