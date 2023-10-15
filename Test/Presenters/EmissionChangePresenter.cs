using System.ComponentModel.DataAnnotations;
using Test.Database;
using Test.Models;
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
            if (_view.Value == -1.0)
            {
                MessageBox.Show("Value field must be numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                _dbConnector.UpdateRecord(_view.Id, _view.Source, _view.Unit, _view.Value, _view.EmissionLocation);
                
            }          
        }

        public void SetView(IEmissionChangeView view)
        {
            _view = view;
            _view.SubmitButtonClicked += ChangeRecordAndCloseForm;
        }
    }
}
