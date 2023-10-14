using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public class EmissionChangePresenter : IEmissionChangePresenter
    {
        private IEmissionChangeView _view;
        private readonly EmissionsRepository _dbConnector;
        private EmissionForm _parent;

        public EmissionChangePresenter(EmissionsRepository connector, EmissionForm parentForm)
        {
            _dbConnector = connector;
            _parent = parentForm;     
        }
   

        private void ChangeRecordAndCloseForm(object? sender, EventArgs e)
        {
            _dbConnector.UpdateRecord(_view.Id, _view.Source, _view.Unit, _view.Value, _view.EmissionLocation);
            Console.WriteLine("Dodano");
            _view.Close();
            _parent.Activate();
        }

        public void SetView(IEmissionChangeView view)
        {
            _view = view;
            _view.SubmitButtonClicked += ChangeRecordAndCloseForm;
        }
    }
       
   
}
