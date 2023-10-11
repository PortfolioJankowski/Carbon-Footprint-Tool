using System;
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
        public void SetView(IEmissionView view)
        {
            _view = view;
            _view.AddButtonClicked += AddRecord;
            _view.DisplayButtonClicked += GetAll;
        }

        private void GetAll(object? sender, EventArgs e)
        {
            try
            {
                List<EmissionModel> emissions = _dbConnector.GetAllEmissions();
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
                // Przygotuj dane do zapisu
                string source = _view.Source;
                string unit = _view.Unit;
                double value = _view.Value;
                string location = _view.Location;

                // Dodaj rekord do bazy danych
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
