using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClas
{
    public class REF_Course
    {
        public int ID { get; set; }
        public string COURSENAME{ get; set; }
        public string COURSEDURATION { get; set; }
        public string COURSEPRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public int STATUS { get; set; }
        public string COURSECODE { get; set; }
    }
}