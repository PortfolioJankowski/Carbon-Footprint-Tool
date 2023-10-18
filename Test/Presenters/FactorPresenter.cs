using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public class FactorPresenter : IFactorPresenter
    {
        private IFactorView _view;
        private EmissionsRepository _db;

        public FactorPresenter(EmissionsRepository db)
        {
            _db = db;                
        }

        public void SetView(IFactorView view)
        {
            _view = view;
            _view.CloseFactorForm += CloseForm;

            //Wyświetlam na gridzie
            var factors = _db.GetAllFactors();
            _view.DisplayData(factors);
            
        }

        private void CloseForm(object? sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
