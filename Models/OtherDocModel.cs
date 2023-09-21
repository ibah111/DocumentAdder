#nullable enable

namespace DocumentAdder.Models;

public class OtherDocModel
{
    public DataModel data { get; set; }
    public OtherDocModel(DataModel data)
    {
        this.data = data;
    }
    public string? Fio { get; set; }
    public string? Portfolio { get; set; }
    public string? User_task { get; set; }
    public string? From_mail { get; set; }
    public string? To_mail { get; set; }
}
public class OtherDocModelEnabled
{
    public bool Fio { get; set; }
    public bool Portfolio { get; set; }
    public bool User_task { get; set; }
    public bool From_mail { get; set; }
    public bool To_mail { get; set; }
}
