using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClas
{
    public class REF_Offers
    {
         public int ID { get; set; }
        public String Offer_ID { get; set; }
        public string OFFER_TYPE { get; set; }
        public string OFFER_NAME { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string MIN_PRICE { get; set; }
        public string MAX_PRICE { get; set; }
        public string DESCCRIPTION { get; set; }
        public int STATUS { get; set; }
    }
}