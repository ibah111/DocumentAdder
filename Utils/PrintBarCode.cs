using bpac;

namespace DocumentAdder.Utils
{
    static public class Printer
    {
        static public void PrintBarCode(string text) {
            bpac.Document doc = new bpac.Document();
            doc.Open("Resources/barcode.lbx");
            var barcode = doc.GetObject("barcode");
            barcode.Text = text;
            doc.StartPrint("", PrintOptionConstants.bpoDefault);
            doc.PrintOut(1, PrintOptionConstants.bpoDefault);
            doc.EndPrint();
            doc.Close();
        }
    }
}
