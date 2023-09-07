#nullable enable
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using DocumentAdder.Forms;

namespace DocumentAdder.Models;

public partial class DataModel : ObservableObject
{
    //ID дела
    [ObservableProperty]
    private int id;
    //Тип дела
    [ObservableProperty]
    private LawTyp typ;
    public object Data { get; set; } = null!;
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

    // Дата вынесения ИД
    [ObservableProperty]
    private DateTime? court_date;

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

    //Дата отказа
    [ObservableProperty]
    private DateTime? failure_date;

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
    private int status = -1;
    //Дата поступления
    [ObservableProperty]
    private DateTime date_post = DateTime.Now;
    //Статья и пункт
    [ObservableProperty]
    private string? article_and_paragraph;

    //Название документа
    [ObservableProperty]
    private string? document_name;

    //Исполнитель
    [ObservableProperty]
    private int? user_task;
    //Отправитель
    [ObservableProperty]
    private string? post_name;
    //Адрес отправителя
    [ObservableProperty]
    private string? post_address;

    //На какой документ распечатать штрих код
    [ObservableProperty]
    private int? doc_barcode;

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
    private int typ_doc = 1;
}
