#nullable enable
using DocumentAdder.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAdder.Models;

public class ActDataModel
{
    public int id { get; set; }
    public LawTyp typ { get; set; }
    public LawActModel LawAct { get; set; } = null!;
    public LawExecModel? LawExec { get; set; }
    public DebtModel Debt { get; set; } = null!;
    public PersonModel Person { get; set; } = null!;
    public LawCourtModel LawCourt { get; set; } = null!;
}
