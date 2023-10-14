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

        //void ClearForm (po dodaniu recordu wyczyść pola)
    }
}
