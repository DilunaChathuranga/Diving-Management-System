using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClass
{
    public class REF_Rent
    {
        public string ID { get; set; }
        public string CusID { get; set; }
        public string ItemID { get; set; }
        public string Qty { get; set; }
        public string Deposit { get; set; }
        public string DaliyRate { get; set; }
        public string TotalCost { get; set; }
        public string NumberOfDay { get; set; }
        public string Status{ get; set; }
    }
}