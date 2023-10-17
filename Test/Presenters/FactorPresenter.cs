using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public class FactorPresenter : IFactorPresenter
    {
        private IFactorView _view;
        private EmissionsRepository _db;

        public FactorPresenter(IFactorView view)
        {
            var factors = _db.GetAllFactors;
            _view = view;
            _view.DisplayData(factors);
        }
        
    }
}
