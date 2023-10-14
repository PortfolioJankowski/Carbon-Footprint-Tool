using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public  interface IEmissionChangePresenter
    {
       

        void SetView(IEmissionChangeView view);
    }
}
