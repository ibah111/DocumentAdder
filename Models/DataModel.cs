#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentAdder.Forms;
using DocumentAdder.Utils;

namespace DocumentAdder.Models;

public class DataModel
{
    //ID дела
    private int id;
    //Тип дела
    private LawTyp typ;
    public object Data { get; set; } = null!;

    //Номер договора
    private string? contract;
    //Номер дела
    private string? exec_number;
    // Номер исполнительного производства
    private string? fssp_doc_num;
    // Номер исполнительного документа
    private string? court_doc_num;

    //Дата исполнительного документа
    private DateTime? receipt_act_dt;
    // Дата вынесения решения
    private DateTime? court_order_date;

    // Дата вступления в силу
    private DateTime? court_exec_date;
    // Дата возбуждения
    private DateTime? start_date;

    //Дата постановления об окончании
    private DateTime? finish_date;

    //Получен агенством
    private DateTime? receipt_date;

    //Дата возврата заявления
    private DateTime? failure_date;
    //Дата отмены приказа (Протокол)
    private DateTime? cancel_date;

    //Дата исправления недостатков
    private DateTime? correct_period_date;

    //Дата заседания
    private DateTime? session_date;
    //Статус дела
    private int status = -1;
    //Дата поступления
    private DateTime date_post = DateTime.Now;
    //Статья и пункт
    private string? article_and_paragraph;

    //Название документа
    private string? document_name;

    //Исполнитель
    private int? user_task;
    //Отправитель
    private string? post_name;
    //Адрес отправителя
    private string? post_address;

    //На какой документ распечатать штрих код
    private int? doc_barcode;

    //Сканы
    private bool scan = false;
    //Пристав
    private bool fssp = false;
    // Задача
    private bool task = false;
    //Учет
    private bool check = false;
    private int mode = 1;
}
