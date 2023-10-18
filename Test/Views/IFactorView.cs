

using Test.Models;

namespace Test.Views
{
    public interface IFactorView
    {
        
        void DisplayData(List<FactorModel> factors);
        void Close();

        event EventHandler CloseFactorForm;
    }
}
