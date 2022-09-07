using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentAdder.Models
{
    public class ServerResults
    {
        public int id;
        public DateTime date_post;
        public bool convert;
        public bool pristavi;
        public string adr_otp;
        public string otprav;
        public string reestr;
        public string doc_name;
        public string doc_name_arhive;
        public string doc_name_arhive_id;
        public int id_doc_name;
        public int id_dela;
        public int id_dolga;
        public int id_dolgnika;
        public string st_pnkt;
        public string gd;
        public string fio_dol;
        public string kd;
        public string ispol_zadach;
        public int id_ispol_zadach;
        public string vsisk;
        public int id_vsisk;
        public DateTime kogda_otdano;
        public string kto_obrabotal;
        public int id_kto_obrabotal;
        public bool nal_skan;
        public int id_zadach;
        public bool arhive;
        public bool arhive_id;
        public int korob_arhive;
        public int korob_arhive_id;
        public DateTime data_obrabotki_arhive;
        public DateTime data_obrabotki_arhive_id;
        public string kto_obrabotal_arhive;
        public string kto_obrabotal_arhive_id;
        public int id_bitrix_arhive;
        public int id_bitrix_arhive_id;
        public bool check_vsisk;
        public string check_vsisk_name;
        public int mode;
        public string ist;
        public DateTime dateDoc;
        public string ecp;
        public string adres;
        public string mail;
        public List<ServerDoc> Docs;
        public List<ServerBarcode> Barcodes;

    }
    public class ServerUser
    {
        public int ID;
        public int NAME;
    }
    public class ServerTemplate
    {
        public int ID;
        public int NAME;
    }
    public class ServerDoc
    {
        public int id;
        public int result_id;
        public string Result;
        public int doc_id;
        public bool sender;
        public bool sended;
        public string barcode;
    }
    public class ServerBarcode
    {
        public int doc;
        public string barcode;
    }
}
