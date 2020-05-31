using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClass
{
    public class REF_BookServices
    {
        public int ID { get; set; }
        public int CusID { get; set; }
        public int ServiceID { get; set; }
        public int Status { get; set; }
        public int OfferID { get; set; }
        public string ServicePrice { get; set; }
        public string OfferPrice { get; set; }
        public string TotalPrice { get; set; }
    
    }
}