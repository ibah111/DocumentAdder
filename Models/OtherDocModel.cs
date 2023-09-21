using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class OtherDocModel
{
    public DataModel data { get; set; }
    public OtherDocModel(DataModel data)
    {
        this.data = data;
    }
    public string Portfolio { get; set; }
    public string User_task { get; set; }
    public string From_mail { get; set; }
    public string To_mail { get; set; }
}
public class OtherDocModelEnabled
{
    public bool Portfolio { get; set; }
    public bool User_task { get; set; }
    public bool From_mail { get; set; }
    public bool To_mail { get; set; }
}
