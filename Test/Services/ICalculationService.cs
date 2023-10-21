using Test.Models;

namespace Test.Services
{
    public interface ICalculationService
    {
        List<CalculationModel> GetCalculationModels(List<EmissionModel> emissions, List<FactorModel> factors);
        List<PieChartDataModel> GetPieChartDataModels(List<CalculationModel> calculations);
        List<LineChartDataModel> GetLineChartDataModels(List<CalculationModel> calculations);
        decimal GetTotalEmissions(List<CalculationModel> calculations);
    }
}
