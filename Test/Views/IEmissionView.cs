using System.ComponentModel.DataAnnotations;
using Test.Models;

namespace Test.Views
{
    public interface IEmissionView
    {
        //Z Tego interfejsu będzie dziedzyczyła forma
        //Znajduje się tutaj właściwości dla pól do wprowadzenia (dane z nich pobieram w formie)
        //I deklaracja eventów oraz metod, które coś robią na Formie
        public string Source { get; set; }
        public string Unit { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Wprowadź wartość od 0 do 100")]
        public double Value { get; set; }
        public string Location { get; set; }
        public EmissionModel CurrentRecord { get; }
        
        event EventHandler AddButtonClicked;
        event EventHandler FormLoaded;
        event EventHandler EmissionChangeFormLoaded;
        event EventHandler Activated;
        event EventHandler DeleteButtonClicked;

        void DisplayData(List<EmissionModel> emissions);

        void ShowMessage(string message);

        
    }
}
