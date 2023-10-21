using Test.Database;
using Test.Services;
using Test.Views;


namespace Test.Presenters
{
    public class CalculationPresenter : ICalculationPresenter
    {
        private ICalculationView _view;
        private ICalculationService _service;
        private EmissionsRepository _db;

        public CalculationPresenter(EmissionsRepository db, ICalculationService service)
        {
            _db = db;
            _service = service;
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
            //Wszystkie kalkulacje do grida,
            var emissions = _db.GetAllEmissions();
            var factors = _db.GetAllFactors();

            var calculations = _service.GetCalculationModels(emissions, factors);
            var total = _service.GetTotalEmissions(calculations);

            //Dane do wykresu
            var PieChartData = _service.GetPieChartDataModels(calculations);
            var LineChartData = _service.GetLineChartDataModels(calculations);

            //Przekazuje dane do widoku
            _view.DisplayData(calculations, total, PieChartData, LineChartData);
        }

        private void CloseForm(object? sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
