using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var calculations = _db.GetAllCalculations();
            _view.DisplayData(calculations);
            _view.CloseCalculationsForm += CloseForm;
        }

        private void CloseForm(object? sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
