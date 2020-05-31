using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS.REFClass
{

    public class REF_Employee 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string jobtype { get; set; }
        public string basicsal { get; set; }
        public string othours { get; set; }
        public string bonous { get; set; }
        public string salary { get; set; }
        public string salaryID { get; set; }

    }
}
