using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class EmissionModel
    {
        public int ID { get; set; }
        public string Source { get; set; }
        public string Unit { get; set; }

        [Range(0, 100, ErrorMessage = "Wprowadź wartość od 0 do 100")]
        public double Value { get; set; }
        public string Location { get; set; }
    }
}
