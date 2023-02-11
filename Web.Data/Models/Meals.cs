using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Models
{
    public class Meals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public Boolean IsHalyal  { get; set; }
    }
}
