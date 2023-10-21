using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using System.Windows.Forms.DataVisualization.Charting;
using Test.Models;
using Test.Presenters;
using Test.Services;
using Test.Views;


namespace Test
{
    public partial class CalculationsForm : Form, ICalculationView
    {
        private CalculationPresenter _presenter;
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
            LocationChart.ChartAreas.Add(chartarea);
            LocationChart.Series["Series1"].ChartType = SeriesChartType.Pie;
            LocationChart.Size = new System.Drawing.Size(311, 300);

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
            SourceChart.ChartAreas.Add(chartarea2); // Użyj chartarea2 zamiast chartarea
            SourceChart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            SourceChart.Size = new System.Drawing.Size(554, 300);

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
    }
}
