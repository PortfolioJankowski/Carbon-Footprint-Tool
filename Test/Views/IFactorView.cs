

using Test.Models;

namespace Test.Views
{
    public interface IFactorView
    {
        
        void DisplayData(Func<List<FactorModel>> factors);
    }
}
