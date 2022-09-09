using bpac;

namespace DocumentAdder.Utils
{
    static public class Printer
    {
        static public void PrintBarCode(string text)
        {
            if (CheckCom())
            {
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
        static public bool CheckCom()
        {
            try
            {
                bpac.Document doc = new bpac.Document();
                var printerName = doc.GetPrinterName();
                var printer = doc.Printer;
                if (printerName != "Brother QL-800") return false;
                var is_online = printer.IsPrinterOnline(printerName);
                return is_online;
            }
            catch { return false; }
        }
    }
}
