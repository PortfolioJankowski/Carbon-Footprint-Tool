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
              try
            { EmissionModel emission = new EmissionModel();

                emission.Value = _view.Value;
                _dbConnector.UpdateRecord(_view.Id, _view.Source, _view.Unit, _view.Value, _view.EmissionLocation);
                _view.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Value field must be numeric", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



                    

               
            
        }

        public void SetView(IEmissionChangeView view)
        {
            _view = view;
            _view.SubmitButtonClicked += ChangeRecordAndCloseForm;
        }
    }
}
