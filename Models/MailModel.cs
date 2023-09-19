#nullable enable

using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace DocumentAdder.Models;

public partial class MailModel : ObservableObject
{
    //Истец, взыскатель
    [ObservableProperty]
    private string? debtor;
    //Подпись
    [ObservableProperty]
    private string? cert;
    //Дата вынесения документа
    [ObservableProperty]
    private DateTime? court_date;
    // Откуда пришло письмо
    [ObservableProperty]
    private string? from_mail;
    // Куда пришло письмо
    [ObservableProperty]
    private string? to_mail;
}
public partial class MailModelEnabled : ObservableObject
{
    //Истец, взыскатель
    [ObservableProperty]
    private bool debtor;
    //Подпись
    [ObservableProperty]
    private bool cert;
    //Дата вынесения документа
    [ObservableProperty]
    private bool court_date;
    // Откуда пришло письмо
    [ObservableProperty]
    private bool from_mail;
    [ObservableProperty]
    // Куда пришло письмо
    private bool to_mail;
}
