using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public class EmissionChangePresenter : IEmissionChangePresenter
    {
        private IEmissionChangeView _view;
        private readonly EmissionsRepository _dbConnector;

        public EmissionChangePresenter(EmissionsRepository connector)
        {
            _dbConnector = connector;
        }

        private void ChangeRecordAndCloseForm(object? sender, EventArgs e)
        {
            _dbConnector.UpdateRecord(_view.Id, _view.Source, _view.Unit, _view.Value, _view.EmissionLocation);
            Console.WriteLine("Dodano");
            _view.Close();
        }

        public void SetView(IEmissionChangeView view)
        {
            _view = view;
            _view.SubmitButtonClicked += ChangeRecordAndCloseForm;
        }
    }
}
