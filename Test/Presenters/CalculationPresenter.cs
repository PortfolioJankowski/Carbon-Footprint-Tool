
using Test.Database;
using Test.Views;


namespace Test.Presenters
{
    public class CalculationPresenter : ICalculationPresenter
    {
        private ICalculationView _view;
        private EmissionsRepository _db;

        public CalculationPresenter(EmissionsRepository db)
        {
            _db = db;
        }

        public void SetView(ICalculationView view)
        {
            _view = view;
            _view.CloseCalculationsForm += CloseForm;
            _view.FormLoad += LoadCharts;
        }

        private void LoadCharts(object? sender, EventArgs e)
        {
            //Suma emisji do labela
            //Wszystkie kalkulacje do grida
            var calculations = _db.GetAllCalculations();
            var total = _db.GetTotalEmissions();
            var roundedTotal = Math.Round(total, 2);

            //Dane do wykresu
            var PieChartData = _db.GetPieChartData();
            var LineChartData = _db.GetLineChartData();

            //Przekazuje dane do widoku
            _view.DisplayData(calculations, roundedTotal, PieChartData, LineChartData);
        }

        private void CloseForm(object? sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
