using System.Collections.Generic;

namespace DocumentAdder.Models;

public class SettingsModel
{
    public string name;
    public int color;
    public bool exec_number;
    public bool fssp_doc_num;
    public bool court_doc_num;
    public bool court_order_date;
    public bool court_exec_date;
    public bool start_date;
    public bool finish_date;
    public bool receipt_date;
    public bool return_date;
    public bool restriction_to_leave_dt;
    public bool reject_date;
    public bool cancel_date;
    public bool correct_period_date;
    public bool session_date;
    public Dictionary<int, int> act_status;
    public int? exec_status;
    public Dictionary<int, List<int>> without_act_status;
    public List<int> without_exec_status;
    public bool barcode;
    public int? user_task;
    public string document_name = null;
    public bool with_court = false;
}