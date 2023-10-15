using OfficeOpenXml;
using System.Text;
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
            _view.ImportButtonClicked += OpenFolder;
        }

        //Pobieranie plików z folderu wybranego przez użytkownika
        private void OpenFolder(object? sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Choose folder with Excel files";
                folderDialog.ShowNewFolderButton = false;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string folderPath = folderDialog.SelectedPath;


                    // Przejdź przez pliki Excela w folderze i dodaj dane do bazy danych SQLite
                    string[] excelFiles = Directory.GetFiles(folderPath, "*.xlsx", SearchOption.TopDirectoryOnly)
                     .Concat(Directory.GetFiles(folderPath, "*.xlsm", SearchOption.TopDirectoryOnly))
                     .ToArray();

                    //Każdy plik excela dodaje do bazy
                    foreach (string filePath in excelFiles)
                    {
                        ReadExcelFile(filePath);
                    }

                    //Po całej operacji wyświetlam boxa i odświeżam grida
                    MessageBox.Show("Excel data has been added to the database.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllRecords(sender, e);
                }
            }
        }

        private void ReadExcelFile(string filePath)
        {
            StringBuilder errorMessages = new StringBuilder();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Załóżmy, że dane znajdują się w pierwszym arkuszu

                if (worksheet.Cells["G1"].Value?.ToString().Trim().ToLower() == "x")
                {
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++) // Iteracja od drugiego wiersza do ostatniego
                    {
                        if (worksheet.Cells[row, 1].Value != null) // Jeśli pierwsza komórka nie jest nullem to tworze z niej EmissionMocel
                        {
                            string source = worksheet.Cells[row, 1].Value?.ToString();
                            string unit = worksheet.Cells[row, 2].Value?.ToString();
                            string valueString = worksheet.Cells[row, 3].Value?.ToString();
                            double value;

                            if (double.TryParse(valueString, out value))
                            {
                                string location = worksheet.Cells[row, 4].Value?.ToString();

                                EmissionModel emissionModel = new EmissionModel
                                {
                                    Source = source,
                                    Unit = unit,
                                    Value = value,
                                    Location = location
                                };

                                // Dodaj emissionModel do bazy danych
                                _dbConnector.AddRecord(emissionModel);
                            }
                        }
                        else
                        {
                            errorMessages.AppendLine($"Błąd  w wierszu {row} w pliku: {filePath}");
                        }
                    }
                }
            }
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
            emissionChangeForm.ShowDialog();

            // Ustawiam EmissionChangeForm -> DialogResult na ok. Jak zamknę to result będzie zawierał DialogResultOk    
            if (emissionChangeForm.DialogResult == DialogResult.OK)
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
            
            //Walidacja na Source, Unit i Location
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(unit) || string.IsNullOrEmpty(location))
            {               
                MessageBox.Show("All fields must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);              
                return;
            }

            // Walidacja na polu Value
            try
            {
                double value = _view.Value;
                // Tworzę obiekt i wrzucam go do metody dodającej record
                EmissionModel emission = new EmissionModel { Source = source, Unit = unit, Value = value, Location = location };
                _dbConnector.AddRecord(emission);

                // Wyświetl komunikat o sukcesie
                MessageBox.Show("Succesfully added.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllRecords(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Value field is numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                

                

                
           
        }
    }
}
