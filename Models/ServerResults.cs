using System;
using System.Collections.Generic;

namespace DocumentAdder.Models
{
    public class ClientDoc
    {
        public int doc { get; set; }
        public bool barcode { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public string date { get; set; }
    }
    public class ServerResults
    {
        public int id { get; set; }
        public DateTime date_post { get; set; }
        public bool convert { get; set; }
        public bool pristavi { get; set; }
        public string adr_otp { get; set; }
        public string otprav { get; set; }
        public string reestr { get; set; }
        public string doc_name { get; set; }
        public string doc_name_arhive { get; set; }
        public string doc_name_arhive_id { get; set; }
        public int id_doc_name { get; set; }
        public int id_dela { get; set; }
        public int id_dolga { get; set; }
        public int id_dolgnika { get; set; }
        public string st_pnkt { get; set; }
        public string gd { get; set; }
        public string fio_dol { get; set; }
        public string kd { get; set; }
        public string ispol_zadach { get; set; }
        public int id_ispol_zadach { get; set; }
        public string vsisk { get; set; }
        public int id_vsisk { get; set; }
        public DateTime kogda_otdano { get; set; }
        public string kto_obrabotal { get; set; }
        public int id_kto_obrabotal { get; set; }
        public bool nal_skan { get; set; }
        public int id_zadach { get; set; }
        public bool arhive { get; set; }
        public bool arhive_id { get; set; }
        public int korob_arhive { get; set; }
        public int korob_arhive_id { get; set; }
        public DateTime data_obrabotki_arhive { get; set; }
        public DateTime data_obrabotki_arhive_id { get; set; }
        public string kto_obrabotal_arhive { get; set; }
        public string kto_obrabotal_arhive_id { get; set; }
        public int id_bitrix_arhive { get; set; }
        public int id_bitrix_arhive_id { get; set; }
        public bool check_vsisk { get; set; }
        public string check_vsisk_name { get; set; }
        public int mode { get; set; }
        public string ist { get; set; }
        public DateTime dateDoc { get; set; }
        public string ecp { get; set; }
        public string adres { get; set; }
        public string mail { get; set; }
        public List<ServerDoc> Docs { get; set; }
        public List<ServerBarcode> Barcodes { get; set; }

    }
    public class ServerUser
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }
    public class ServerTemplate
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }
    public class ServerDoc
    {
        public int id { get; set; }
        public int result_id { get; set; }
        public string Result { get; set; }
        public int doc_id { get; set; }
        public bool sender { get; set; }
        public bool sended { get; set; }
        public string barcode { get; set; }
    }
    public class ServerBarcode
    {
        public int doc { get; set; }
        public string barcode { get; set; }
    }
}
