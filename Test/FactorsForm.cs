
using Test.Database;
using Test.Models;
using Test.Views;

namespace Test
{
    public partial class FactorsForm : Form
    {
        public FactorsForm()
        {
            InitializeComponent();
            var db = new EmissionsRepository();
            var factors = db.GetAllFactors();
            factorModelBindingSource.DataSource = factors;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
