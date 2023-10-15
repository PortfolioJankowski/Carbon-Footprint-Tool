using Test.Database;
using Test.Models;
using Test.Views;

namespace Test.Presenters
{
    public class EmissionPresenter : IEmissionPresenter
    {
        private IEmissionView _view;
        private readonly EmissionsRepository _dbConnector;

        public EmissionPresenter(EmissionsRepository dBConnector)
        {
            _dbConnector = dBConnector;
        }
        //Obsługa eventow z View
        public void SetView(IEmissionView view)
        {
            _view = view;
            _view.AddButtonClicked += AddRecord;
            _view.FormLoaded += GetAllRecords;
            _view.EmissionChangeFormLoaded += ChangeEmission;
            _view.DeleteButtonClicked += DeleteRecord;
        }

        private void DeleteRecord(object? sender, EventArgs e)
        {
            var record = _view.CurrentRecord;
            _dbConnector.DeleteRecord(record.ID);
            GetAllRecords(sender, e);
        }

        // Uruchomienie formy zmieniającej emisje
        private void ChangeEmission(object? sender, EventArgs e)
        {
            // Biorę z tupla pojedyncze itemy i wrzucam je do konstruktora, który przypisze je do odpowiednich pól
            // Przekazuje dodatkowo formę 1, żeby z móc później wywołać na niej load przed zamknięciem formy Change
            EmissionChangeForm emissionChangeForm = new EmissionChangeForm(_view.CurrentRecord);


            // Ustawiam EmissionChangeForm -> DialogResult na ok. Jak zamknę to result będzie zawierał DialogResultOk
            var result = emissionChangeForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                GetAllRecords(sender, e);
            }
        }

        // Kliknięcie przycisku GetAll
        private void GetAllRecords(object? sender, EventArgs e)
        {
            //listę emisji z bazy muszę gdzieś zapisać -> tworze listę, interakcja z Widokiem
            List<EmissionModel> emissions = _dbConnector.GetAllEmissions();

            // Metoda DisplayData po swoim wykonaniu czyści również formę
            _view.DisplayData(emissions);
        }

        private void AddRecord(object? sender, EventArgs e)
        {         
                // Do zadeklarowanych danych pobieram wartości z bazy
                string source = _view.Source;
                string unit = _view.Unit;
                string location = _view.Location;

            try
            {
                double value = _view.Value;
                // Tworzę obiekt i wrzucam go do metody dodającej record
                EmissionModel emission = new EmissionModel { Source = source, Unit = unit, Value = value, Location = location };
                _dbConnector.AddRecord(emission);

                // Wyświetl komunikat o sukcesie
                _view.ShowMessage("Succesfully added.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllRecords(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value field is numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                

                

                
           
        }
    }
}
