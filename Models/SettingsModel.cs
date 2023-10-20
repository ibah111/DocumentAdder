#nullable enable
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace DocumentAdder.Models;

public partial class SettingsModel : ObservableObject
{

    [ObservableProperty]
    private int id;
    public string name { get; init; }
    [ObservableProperty]
    private int color;
    [ObservableProperty]
    private bool exec_number;
    [ObservableProperty]
    private bool fssp_doc_num;
    [ObservableProperty]
    private bool court_doc_num;
    [ObservableProperty]
    private bool court_order_date;
    [ObservableProperty]
    private bool court_exec_date;
    [ObservableProperty]
    private bool start_date;
    [ObservableProperty]
    private bool finish_date;
    [ObservableProperty]
    private bool receipt_date;
    [ObservableProperty]
    private bool return_date;
    [ObservableProperty]
    private bool restriction_to_leave_dt;
    [ObservableProperty]
    private bool reject_date;
    [ObservableProperty]
    private bool cancel_date;
    [ObservableProperty]
    private bool correct_period_date;
    [ObservableProperty]
    private bool session_date;
    public Dictionary<int, int> act_status { get; init; } = new();
    public int? exec_status { get; init; }
    public Dictionary<int, List<int>> without_act_status { get; init; } = new();
    public List<int> without_exec_status { get; init; } = new();
    [ObservableProperty]
    private bool barcode = false;
    public int? user_task { get; init; }
    public string? document_name { get; init; } = null;
    [ObservableProperty]
    private bool with_court = false;
}