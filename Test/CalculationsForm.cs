using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using OfficeOpenXml;
using System.Windows.Forms.DataVisualization.Charting;
using Test.Database;
using Test.Models;
using Test.Presenters;
using Test.Services;
using Test.Views;


namespace Test
{
    public partial class CalculationsForm : Form, ICalculationView
    {
        private CalculationPresenter _presenter;
        private CalculationService _service;
        private EmissionsRepository _db;

        public CalculationsForm()
        {
            InitializeComponent();
            _presenter = new CalculationPresenter(new Database.EmissionsRepository(), new CalculationService());
            _presenter.SetView(this);
            CloseButton.Click += (sender, e) => CloseCalculationsForm?.Invoke(sender, e);
            Load += (sender, e) => FormLoad?.Invoke(sender, e);
        }

        public event EventHandler CloseCalculationsForm;
        public event EventHandler FormLoad;


        public void DisplayData(List<CalculationModel> calculations, decimal total, List<PieChartDataModel> data, List<LineChartDataModel> dataModels)
        {
            // Przypisuje dane do grida i do labela 
            calculationModelBindingSource.DataSource = calculations;
            pieChartDataModelBindingSource.DataSource = data;
            lineChartDataModelBindingSource.DataSource = dataModels;

            TotalLabel.Text = string.Format("{0:N0}", total);

            // Wykres kołowy
            CreatePieChart(data);

            // Wykres liniowy
            CreateLineChart(dataModels);
        }

        private void CreatePieChart(List<PieChartDataModel> data)
        {
            var chartarea = new ChartArea();
            chartarea.BackColor = Color.Transparent;
            chartarea.Position.Width = 99; // Ustaw szerokość obszaru wykresu
            chartarea.Position.Height = 99;
            LocationChart.ChartAreas.Add(chartarea);
            LocationChart.Series["Series1"].ChartType = SeriesChartType.Pie;


            foreach (var result in data)
            {
                var dataPoint = LocationChart.Series["Series1"].Points.AddXY(result.Location, result.TotalResult);
            }
            LocationChart.Legends["Legend1"].BackColor = Color.Transparent;
            LocationChart.BackColor = Color.Transparent;
        }

        private void CreateLineChart(List<LineChartDataModel> dataModels)
        {
            var chartarea2 = new ChartArea();
            chartarea2.BackColor = Color.Transparent;
            chartarea2.Position.Width = 99; // Ustaw szerokość obszaru wykresu
            chartarea2.Position.Height = 99;
            SourceChart.ChartAreas.Add(chartarea2); // Użyj chartarea2 zamiast chartarea
            SourceChart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;


            int position = 0; // Unikalna pozycja dla każdego źródła na osi X

            foreach (var result in dataModels)
            {
                // Zmień wysokość słupka na podstawie wartości TotalResult
                double height = Convert.ToDouble(result.TotalResult);

                // Dodaj punkty danych dla każdego źródła obok siebie, nadając unikalne pozycje na osi X
                var dataPoint = new DataPoint(position, height);
                dataPoint.AxisLabel = result.Source; // Ustaw etykietę na osi X jako źródło

                // Przypisz różne kolory dla każdego punktu danych
                dataPoint.Color = Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));

                SourceChart.Series["Series1"].Points.Add(dataPoint);

                // Zwiększ pozycję, aby następny punkt danych był obok poprzedniego
                position++;
            }

            SourceChart.Legends["Legend1"].Enabled = false;
            SourceChart.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculationService _service = new CalculationService();
            EmissionsRepository _db = new EmissionsRepository();

            var calculations = _service.GetCalculationModels(_db.GetAllEmissions(), _db.GetAllFactors());
            // Inicjalizuj SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Zapisz jako plik Excel";
            saveFileDialog.FileName = "Calculations.xlsx"; // Domyślna nazwa pliku

            // Jeśli użytkownik wybierze lokalizację i kliknie OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Reszta kodu pozostaje bez zmian

                // Utwórz plik Excel i zapisz dane
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Calculations");

                    // Nagłówki kolumn
                    worksheet.Cells[1, 1].Value = "Source";
                    worksheet.Cells[1, 2].Value = "Value";
                    worksheet.Cells[1, 3].Value = "Unit";
                    worksheet.Cells[1, 4].Value = "Result";
                    worksheet.Cells[1, 5].Value = "Location";

                    int row = 2;
                    foreach (var calculation in calculations)
                    {
                        worksheet.Cells[row, 1].Value = calculation.Source;
                        worksheet.Cells[row, 2].Value = calculation.Value;
                        worksheet.Cells[row, 3].Value = calculation.Unit;
                        worksheet.Cells[row, 4].Value = calculation.Result;
                        worksheet.Cells[row, 5].Value = calculation.Location;

                        row++;
                    }

                    FileInfo excelFile = new FileInfo(filePath);
                    package.SaveAs(excelFile);
                }

                MessageBox.Show("Dane zostały pomyślnie wyeksportowane do pliku Excel.");
            }
        }
    }
    
 }
