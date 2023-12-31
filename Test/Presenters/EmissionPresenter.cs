﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Database;
using Test.Models;
using Test.Views;

namespace Test.Presenters
{
    public class EmissionPresenter : IEmissionPresenter
    {
        private  IEmissionView _view;
        private readonly DBConnector _dbConnector;

        public EmissionPresenter(DBConnector dBConnector)
        {
            _dbConnector = dBConnector;
        }
        //Obsługa eventow z View
        public void SetView(IEmissionView view)
        {
            _view = view;
            _view.AddButtonClicked += AddRecord;
            _view.AddButtonClicked += GetAll;
            _view.FormLoaded += GetAll;
            _view.EmissionChangeFormLoaded += ChangeEmission;
            _view.Activated += GetAll;
            _view.DeleteButtonClicked += DeleteRecord;
            
            
        }

        private void DeleteRecord(object? sender, EventArgs e)
        {
            var selectedRecordTuple = _view.GetRecord();
            int recordId = int.Parse(selectedRecordTuple.Col1);
            _dbConnector.DeleteRecord(recordId);
          
        }



        // Uruchomienie formy zmieniającej emisje
        private void ChangeEmission(object? sender, EventArgs e)
        {      
                // Przypisuje do zmiennej Tupla z zaznaczonym recordem
                var selectedRecordTuple = _view.GetRecord();

                // Biorę z tupla pojedyncze itemy i wrzucam je do konstruktora, który przypisze je do odpowiednich pól
                // Przekazuje dodatkowo formę 1, żeby z móc później wywołać na niej load przed zamknięciem formy Change
                EmissionChangeForm emissionChangeForm = new EmissionChangeForm(selectedRecordTuple.Col2, selectedRecordTuple.Col3, selectedRecordTuple.Col4, selectedRecordTuple.Col5, selectedRecordTuple.Col1, new Form1());
            
                emissionChangeForm.Show();
        
                

        }

        // Kliknięcie przycisku GetAll
        private void GetAll(object? sender, EventArgs e)
        {
            try
            {   //listę emisji z bazy muszę gdzieś zapisać -> tworze listę, interakcja z Widokiem
                List<EmissionModel> emissions = _dbConnector.GetAllEmissions();

                // Metoda DisplayData po swoim wykonaniu czyści również formę
                _view.DisplayData(emissions);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Błąd konwersji " + ex.Message);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Błąd rzutowania " + ex.Message);
            }
        }

        private void AddRecord(object? sender, EventArgs e)
        {
            try
            {
                // Do zadeklarowanych danych pobieram wartości z bazy
                string source = _view.Source;
                string unit = _view.Unit;
                double value = _view.Value;
                string location = _view.Location;

                // Tworzę obiekt i wrzucam go do metody dodającej record
                EmissionModel emission = new EmissionModel { Source = source, Unit = unit, Value = value, Location = location };
                _dbConnector.AddRecord(emission);

                // Wyświetl komunikat o sukcesie
                _view.ShowMessage("Rekord został dodany pomyślnie.");
            }
            catch (Exception ex)
            {
                // Obsłuż błąd i wyświetl komunikat
                _view.ShowMessage("Wystąpił błąd podczas dodawania rekordu: " + ex.Message);
            }
        }
    }
}
