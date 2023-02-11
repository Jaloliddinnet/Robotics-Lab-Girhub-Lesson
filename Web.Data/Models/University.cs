using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Models
{
    public class University
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string Director_name { get; set; }
        public int Students_number { get; set; }
    }
}
