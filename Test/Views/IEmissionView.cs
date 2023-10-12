using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool isRecordSelected();

        event EventHandler AddButtonClicked;
        event EventHandler FormLoaded;
        event EventHandler EmissionChangeFormLoaded;

        (string Col1, string Col2, string Col3, string Col4, string Col5) GetRecord();

        void DisplayData(List<EmissionModel> emissions);

        void ShowMessage(string message);

        //void ClearForm (po dodaniu recordu wyczyść pola)
    }
}
