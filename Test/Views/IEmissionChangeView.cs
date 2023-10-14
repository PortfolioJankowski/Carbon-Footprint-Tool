using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Views
{
    public interface IEmissionChangeView
    {

        int Id { get; set; }
        string Source { get; set; }
        string Unit { get; set; }   
        double Value { get; set; }
        string Location { get; set; }
       

        event EventHandler SubmitButtonClicked;
    }
}
