using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Models;
using Test.Presenters;
using Test.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Test
{
    public partial class CalculationsForm : Form, ICalculationView
    {
        private CalculationPresenter _presenter;
        public CalculationsForm()
        {
            InitializeComponent();
            _presenter = new CalculationPresenter(new Database.EmissionsRepository());
            _presenter.SetView(this);
            CloseButton.Click += (sender, e) => CloseCalculationsForm?.Invoke(sender, e);
        }

        public event EventHandler CloseCalculationsForm;

        public void DisplayData(List<CalculationModel> factors)
        {
            calculationModelBindingSource.DataSource = factors;
        }
    }
}
