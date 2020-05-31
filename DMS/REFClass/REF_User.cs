using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMS.REFClas
{
    public class REF_User
    {
        public int ID { get; set; }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string CONTACT_NO { get; set; }
        public int STATUS { get; set; }
        public int Role { get; set; }
    }
}