
using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace DatabaseContact.DatabaseContact.Configurations
{
    public partial class DictConfiguration : IEntityTypeConfiguration<Dict>
    {
        public void Configure(EntityTypeBuilder<Dict> entity)
        {
            entity.ToTable("dict", tb =>
            {
                tb.HasComment("словарные термины");
                tb.HasTrigger("dict_change");
                tb.HasTrigger("tr_dict_bidu");
            });

            entity.HasIndex(e => new { e.parent_id, e.lang_canonical, e.code }, "UC_DICT_ID")
            .IsUnique()
            .HasFillFactor(100);

            entity.Property(e => e.EXT_ID).HasComment("Внешний код");
            entity.Property(e => e.LANG).HasComment("язык (словарь 78)");
            entity.Property(e => e.change_dt).HasComment("дата изменения записи");
            entity.Property(e => e.code).HasComment("код термина");
            entity.Property(e => e.lang_canonical).HasComputedColumnSql("(coalesce([lang],(1)))", false);
            entity.Property(e => e.parent_id).HasComment("ссылка на code описателя слова");
            entity.Property(e => e.r_code).HasComment("ссылка на термин родительского");
            entity.Property(e => e.typ).HasComment("1 - системный, 2 - общий");

            entity.HasOne(d => d.parent).WithMany(p => p.dict)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dict_parent_id_dict_name");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Dict> entity);
    }

}
