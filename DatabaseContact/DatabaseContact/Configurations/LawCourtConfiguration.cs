using DatabaseContact.DatabaseContact;
using DatabaseContact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace DatabaseContact.DatabaseContact.Configurations
{
    public partial class LawCourtConfiguration : IEntityTypeConfiguration<LawCourt>
    {
        public void Configure(EntityTypeBuilder<LawCourt> entity)
        {
            entity.HasKey(e => e.id).HasName("law_court_PK");

            entity.ToTable("law_court", tb => tb.HasTrigger("tr_law_court_aiu"));

            entity.Property(e => e.ACCOUNT_NUMBER).HasComment("Номер лицевого счета в УФК (Заполняется только для ФССП)");
            entity.Property(e => e.COURT_CATEGORY).HasComment("Категория суда (Словарь №401)");
            entity.Property(e => e.EMAIL).HasComment("Email адрес");
            entity.Property(e => e.FILIAL).HasComment("Филиал (Словарь №61)");
            entity.Property(e => e.GAS_JUSTICE_CODE).HasComment("код суда в ГАС Правосудие");
            entity.Property(e => e.NOT_USED).HasComment("Признак \"Не используется\"");
            entity.Property(e => e.POWER_OF_ATTORNEY_TYPE).HasComment("Тип доверенности (Словарь №402)");
            entity.Property(e => e.RECIPIENT_CODE).HasComment("Код получателя");
            entity.Property(e => e.SITE).HasComment("Веб-сайт");
            entity.Property(e => e.SOURCE_CODE).HasComment("Источник (Словарь №403)");
            entity.Property(e => e.TREASURY_ACCOUNT).HasComment("казначейский счет");
            entity.Property(e => e.notarial_authority).HasComment("нотариальный орган");
            entity.Property(e => e.notary_typ).HasComment("тип нотариуса (словарь 342)");
            entity.Property(e => e.typ).HasComment("тип органа (1 - суд, 2 – исполнительный орган, 3 - нотариус)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LawCourt> entity);
    }

}
