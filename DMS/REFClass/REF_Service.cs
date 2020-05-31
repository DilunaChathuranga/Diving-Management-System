using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClas
{
    public class REF_Service
    {
        public int ID { get; set; }
        public string ServiceiD { get; set; }
        public string Service_Name { get; set; }
        public string Service_Duration { get; set; }
        public string Price_Per_Hour { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }


    }
}