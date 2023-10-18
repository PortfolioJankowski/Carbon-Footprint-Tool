
using Test.Database;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class FactorsForm : Form, IFactorView
    {
        private IFactorPresenter _presenter;
        private EmissionsRepository _db;
        public FactorsForm()
        {
            InitializeComponent();
            _presenter = new FactorPresenter(new Database.EmissionsRepository());
            _presenter.SetView(this);
            CloseButton.Click += (sender, e) => CloseFactorForm?.Invoke(sender, e);
        }

        public event EventHandler CloseFactorForm;

        public void DisplayData(List<FactorModel> factors)
        {
            factorModelBindingSource.DataSource = factors;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
