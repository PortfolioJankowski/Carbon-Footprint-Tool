using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Database;
using Test.Views;

namespace Test.Presenters
{
    public class EmissionChangePresenter : IEmissionChangePresenter
    {
        private IEmissionChangeView _view;
        private readonly DBConnector _dbConnector;
        private Form1 _parent;
       

        public EmissionChangePresenter(DBConnector connector, Form1 parentForm)
        {
            _dbConnector = connector;
            _parent = parentForm;
        }

        public void SetView(IEmissionChangeView view)
        {
            _view = view;
            _view.SubmitButtonClicked += ChangeRecordAndCloseForm;

        }

        private void ChangeRecordAndCloseForm(object? sender, EventArgs e)
        {
            
            _parent.Activate();
        }
    }
       
   
}
