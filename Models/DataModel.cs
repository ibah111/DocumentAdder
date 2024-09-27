#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DocumentAdder.Forms;

namespace DocumentAdder.Models;

public partial class DataModel : ObservableObject
{
    public DataModel(ActDataModel? data = null, DateTime? date_post = null)
    {
        if (date_post != null)
            this.date_post = date_post.Value;
        if (data != null)
        {
            Data = data;
            Id = data.id;
            Typ = data.typ;
            Exec_number = data.LawAct?.exec_number;
            Court_order_date = data.LawAct?.court_order_date;
            Court_exec_date = data.LawAct?.court_exec_date;
            //Надо создавать новую дату
            //if (data.LawAct.typ > 1)
            //{
            //    Receipt_date = data.LawAct.receipt_dt;
            //}
            //else
            //    Receipt_date = data.LawAct.receipt_date;
            //receipt_date = data.LawAct.receipt_act_dt;
            Correct_period_date = data.LawAct?.correct_period_date;
            DscRead = data.LawAct?.dsc;
            if (data.typ == LawTyp.LawExec)
            {
                Fssp_doc_num = data.LawExec.fssp_doc_num;
                Court_doc_num = data.LawExec.court_doc_num;
                Start_date = data.LawExec.start_date;
                Finish_date = data.LawExec.finish_date;
                Restriction_to_leave_dt = data.LawExec.restriction_to_leave_dt;
                //Надо создавать новую дату
                //Receipt_date = data.LawExec.receipt_act_dt;
                DscRead = data.LawExec.dsc;
            }
            Receipt_date = DateTime.Now;
            Post_name = data.LawCourt?.name;
            Post_address = data.LawCourt?.address;
        }
    }
    //ID дела
    [ObservableProperty]
    private int? id;
    //Тип дела
    [ObservableProperty]
    private LawTyp typ;
    public ActDataModel Data { get; set; } = null!;
    //Номер дела
    [ObservableProperty]
    private string? exec_number;
    // Номер исполнительного производства
    [ObservableProperty]
    private string? fssp_doc_num;
    // Номер исполнительного документа
    [ObservableProperty]
    private string? court_doc_num;
    // Дата вынесения решения
    [ObservableProperty]
    private DateTime? court_order_date;

    // Дата вступления в силу
    [ObservableProperty]
    private DateTime? court_exec_date;
    // Дата возбуждения
    [ObservableProperty]
    private DateTime? start_date;

    //Дата постановления об окончании
    [ObservableProperty]
    private DateTime? finish_date;

    //Получен агенством
    [ObservableProperty]
    private DateTime? receipt_date;

    //Дата ограничения выезда
    [ObservableProperty]
    private DateTime? restriction_to_leave_dt;

    //Дата отказа в возбуждении
    [ObservableProperty]
    private DateTime? reject_date;
    //Дата возврата заявления (Протокол)
    [ObservableProperty]
    private DateTime? return_date;
    //Дата отмены приказа (Протокол)
    [ObservableProperty]
    private DateTime? cancel_date;

    //Дата исправления недостатков
    [ObservableProperty]
    private DateTime? correct_period_date;

    //Дата заседания
    [ObservableProperty]
    private DateTime? session_date;
    //Статус дела
    [ObservableProperty]
    private int? status = null;
    //Дата поступления
    [ObservableProperty]
    private DateTime date_post = DateTime.Now;
    //Статья и пункт
    [ObservableProperty]
    private string? article_and_paragraph;

    //Название документа
    [ObservableProperty]
    private string? document_name;

    //Комментарий
    [ObservableProperty]
    private string? dsc;

    [ObservableProperty]
    public string? dscRead;

    //Исполнитель
    [ObservableProperty]
    private int? user_task;
    //Шаблон
    [ObservableProperty]
    private int? task_id;
    //Отправитель
    [ObservableProperty]
    private string? post_name;
    //Адрес отправителя
    [ObservableProperty]
    private string? post_address;

    //На какой документ распечатать штрих код
    [ObservableProperty]
    private FileData? doc_barcode;

    //Сканы
    [ObservableProperty]
    private bool scan = false;
    //Пристав
    [ObservableProperty]
    private bool fssp = false;
    // Задача
    [ObservableProperty]
    private bool task = false;
    //Учет
    [ObservableProperty]
    private bool check = false;
    [ObservableProperty]
    private int mode = 1;


    [ObservableProperty]
    private bool have_kd = false;
    [ObservableProperty]
    private bool scan_copy_kd = false;

    [ObservableProperty]
    private string? return_reason = "";

    [ObservableProperty]
    private int? typ_doc = null;

    public ObservableCollection<FileData> Files = new();
}
