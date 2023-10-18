using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Views
{
   public interface ICalculationView
    {
        void DisplayData(List<CalculationModel> factors);
        void Close();

        event EventHandler CloseCalculationsForm;
    }
}
