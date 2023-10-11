using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class EmissionModel
    {
        public int ID { get; set; }
        public string Source { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string Location { get; set; }
    }
}
