using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module_Calculator.Models
{
    public class Modules
    {
        public string id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public int Weeks { get; set; }
        public DateTime Startdate { get; set; }
            
    }
}