using Test.Models;

namespace Test.Services
{
    public class CalculationService : ICalculationService
    {
        
        
        public List<CalculationModel> GetCalculationModels(List<EmissionModel> emissions, List<FactorModel> factors)
        {
            var result = new List<CalculationModel>();

            foreach (var emission in emissions)
            {
                var factor = factors.FirstOrDefault(x => x.Unit == emission.Unit && x.Source == emission.Source);

                var calculation = new CalculationModel
                {
                    Source = emission.Source,
                    Unit = emission.Unit,
                    Location = emission.Location,
                    Value = (decimal)emission.Value,
                    Result = factor != null ? factor.Value * (decimal)emission.Value : 0
                };

                result.Add(calculation);
            }

            return result;
        }

        public List<LineChartDataModel> GetLineChartDataModels(List<CalculationModel> calculations)
        {
            var result = new List<LineChartDataModel>();

            var grouped = calculations.GroupBy(x => x.Source);

            foreach (var group in grouped)
            {
                var lineModel = new LineChartDataModel
                {
                    Source = group.Key,
                    TotalResult = group.Sum(x => x.Result)
                };

                result.Add(lineModel);
            }

            return result;
        }

        public List<PieChartDataModel> GetPieChartDataModels(List<CalculationModel> calculations)
        {
            var result = new List<PieChartDataModel>();

            var grouped = calculations.GroupBy(x => x.Location);

            foreach (var group in grouped)
            {
                var pieModel = new PieChartDataModel
                {
                    Location = group.Key,
                    TotalResult = group.Sum(x => x.Result)
                };

                result.Add(pieModel);
            }

            return result;
        }

        public decimal GetTotalEmissions(List<CalculationModel> calculations)
        {
            var result = calculations.Sum(x => x.Result);

            return Math.Round(result, 2);
        }
    }
}
