using System.Collections.Generic;

namespace DocumentAdder.Models;

public class SettingsModel
{
    public int id { get; init; }
    public string name { get; init; }
    public int color { get; init; }
    public bool exec_number { get; init; }
    public bool fssp_doc_num { get; init; }
    public bool court_doc_num { get; init; }
    public bool court_order_date { get; init; }
    public bool court_exec_date { get; init; }
    public bool start_date { get; init; }
    public bool finish_date { get; init; }
    public bool receipt_date { get; init; }
    public bool return_date { get; init; }
    public bool restriction_to_leave_dt { get; init; }
    public bool reject_date { get; init; }
    public bool cancel_date { get; init; }
    public bool correct_period_date { get; init; }
    public bool session_date { get; init; }
    public Dictionary<int, int> act_status { get; init; }
    public int? exec_status { get; init; }
    public Dictionary<int, List<int>> without_act_status { get; init; }
    public List<int> without_exec_status { get; init; }
    public bool barcode { get; init; }
    public int? user_task { get; init; }
    public string document_name { get; init; } = null;
    public bool with_court { get; init; } = false;
}