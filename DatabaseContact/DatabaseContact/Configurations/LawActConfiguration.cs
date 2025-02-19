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
    public partial class LawActConfiguration : IEntityTypeConfiguration<LawAct>
    {
        public void Configure(EntityTypeBuilder<LawAct> entity)
        {
            entity.HasKey(e => e.id).HasName("law_act_PK");

            entity.ToTable("law_act", tb =>
            {
                tb.HasComment("информация о судебной работе");
                tb.HasTrigger("TR_LAW_ACT_AIU");
            });

            entity.Property(e => e.id).HasComment("");
            entity.Property(e => e.ACT_SUBJECT).HasComment("Предмет иска (словарь №327)");
            entity.Property(e => e.DT_VALUE_1).HasComment("Техническое поле типа дата 1");
            entity.Property(e => e.NUMBER_VALUE_1).HasComment("Техническое поле типа число 1");
            entity.Property(e => e.PRE_ACT_STATUS).HasComment("статус судебного дела (ссылка ");
            entity.Property(e => e.REFUSAL_REASON).HasComment("Основания отказа суда от полного удовлетворения иска (словарь №406)");
            entity.Property(e => e.R_COMMON_LAW_ACT_ID).HasComment("Ссылка на объединенное судебное дело");
            entity.Property(e => e.R_LAW_ACT_ID).HasComment("ссылка на родительский иск");
            entity.Property(e => e.STRING_VALUE_1).HasComment("Техническое поле типа строка 1");
            entity.Property(e => e.act_direct).HasComment("тип иска (0,null - исходящий, ");
            entity.Property(e => e.act_status).HasComment("статус иска (словарь №25)");
            entity.Property(e => e.contract).HasComment("номер договора");
            entity.Property(e => e.correct_period_date).HasComment("дата срока исполнения недостат");
            entity.Property(e => e.court_adres).HasComment("территориальность и адрес суда");
            entity.Property(e => e.court_date).HasComment("дата заседания (не используетс");
            entity.Property(e => e.court_def).HasComment("определение вынесенное на засе");
            entity.Property(e => e.court_exec_date).HasComment("дата вступления в силу (иска)");
            entity.Property(e => e.court_fio).HasComment("ФИИ судьи (не используется)");
            entity.Property(e => e.court_kind).HasComment("родовая подсудность (словарь №");
            entity.Property(e => e.court_name).HasComment("название суда (устар.)");
            entity.Property(e => e.court_order_date).HasComment("дата отправки судебного приказ");
            entity.Property(e => e.court_order_delivery).HasComment("способ доставки судебного прик");
            entity.Property(e => e.court_order_period).HasComment("период ожидания вынесения суде");
            entity.Property(e => e.court_pre_date).HasComment("дата предв. заседания (не испо");
            entity.Property(e => e.court_pre_def).HasComment("определение вынесенное на пред");
            entity.Property(e => e.court_pre_fio).HasComment("ФИО судьи (предв. заседание) (");
            entity.Property(e => e.court_sum).HasComment("Сумма по решению суда");
            entity.Property(e => e.court_typ).HasComment("тип суда (словарь №15)");
            entity.Property(e => e.currency).HasComment("валюта");
            entity.Property(e => e.deadline).HasComment("крайний срок подачи");
            entity.Property(e => e.delivery_typ).HasComment("способ доставки заявления в су");
            entity.Property(e => e.dict_value_1).HasComment("Примечание судебного дела (Словарь №247)");
            entity.Property(e => e.dsc).HasComment("комментарий");
            entity.Property(e => e.dt_to_archive).HasComment("дата перевода в архивный стату");
            entity.Property(e => e.due_conf_sum).HasComment("утвержденный размер пошлины");
            entity.Property(e => e.due_pay_date).HasComment("дата оплаты госпошлины");
            entity.Property(e => e.due_pay_num).HasComment("номер платежного поручения");
            entity.Property(e => e.due_sum).HasComment("размер пошлины");
            entity.Property(e => e.exec_date).HasComment("дата документа (приказа/иска)");
            entity.Property(e => e.exec_number).HasComment("номер документа (приказа/иска)");
            entity.Property(e => e.failure_date).HasComment("дата отказа");
            entity.Property(e => e.fd).HasComment("дата поступления дела");
            entity.Property(e => e.full_strength).HasComment("укомплектованность (словарь №1");
            entity.Property(e => e.inner_number).HasComment("входящий номер (используется д");
            entity.Property(e => e.instruct).HasComment("указания руководителя");
            entity.Property(e => e.int_color).HasComment("цвет");
            entity.Property(e => e.is_entire_amount).HasComment("УСТАРЕЛО, ВПОСЛЕДСВИИ БУДЕТ УД");
            entity.Property(e => e.is_obtain_contract).HasComment("УСТАРЕЛО, ВПОСЛЕДСВИИ БУДЕТ УД");
            entity.Property(e => e.load_dt).HasComment("дата загрузки\\формирования дел");
            entity.Property(e => e.name).HasComment("название продукта");
            entity.Property(e => e.r_address_id).HasComment("адрес, по которому на должника");
            entity.Property(e => e.r_court_id).HasComment("ссылка на law_court");
            entity.Property(e => e.r_debt_id).HasComment("ссылка на debt");
            entity.Property(e => e.r_judge_id).HasComment("судья (ссылка на law_r_judge_i");
            entity.Property(e => e.r_person_id).HasComment("ссылка на person");
            entity.Property(e => e.r_portfolio_id).HasComment("ссылка на portfolio");
            entity.Property(e => e.r_user_id).HasComment("ссылка на users");
            entity.Property(e => e.receipt_act_dt).HasComment("дата получения исп листа на об");
            entity.Property(e => e.receipt_date).HasComment("дата получения судебного прика");
            entity.Property(e => e.receipt_dt).HasComment("дата получения исп.листа");
            entity.Property(e => e.settlement_date).HasComment("дата мирового соглашения");
            entity.Property(e => e.settlement_sum).HasComment("сумма мирового соглашения");
            entity.Property(e => e.start_date).HasComment("дата подачи заявления в суд");
            entity.Property(e => e.status).HasComment("статус (словарь №18)");
            entity.Property(e => e.terminate_contract_dt).HasComment("дата расторжения договора");
            entity.Property(e => e.total_sum).HasComment("размер требования по заявлению");
            entity.Property(e => e.typ).HasComment("тип суд. работы (0 - неопределенное суд. дело, 1 - приказ, 2 - иск, 3 - правопреемство, 4 - банкротство, 5 – исполнительная надпись)");
            entity.Property(e => e.typ_name).HasComment("тип продукта (ссылка на словар");
            entity.Property(e => e.user_result).HasComment("результат длеа (ссылка на слов");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<LawAct> entity);
    }
}
