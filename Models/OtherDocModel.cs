#nullable enable

using CommunityToolkit.Mvvm.ComponentModel;

namespace DocumentAdder.Models;

public partial class OtherDocModel : ObservableObject
{
    public DataModel data { get; set; }
    public OtherDocModel(DataModel data)
    {
        this.data = data;
    }
    [ObservableProperty]
    private string? fio;
    [ObservableProperty]
    private string? portfolio;
    [ObservableProperty]
    private string? user_task;
    [ObservableProperty]
    private string? from_mail;
    [ObservableProperty]
    private string? to_mail;
}
public partial class OtherDocModelEnabled : ObservableObject
{
    [ObservableProperty]
    private bool fio;
    [ObservableProperty]
    private bool portfolio;
    [ObservableProperty]
    private bool user_task;
    [ObservableProperty]
    private bool from_mail;
    [ObservableProperty]
    private bool to_mail;
}
