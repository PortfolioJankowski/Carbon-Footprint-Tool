using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Views;

namespace Test
{
    public partial class EmissionChangeForm : Form, IEmissionChangeView
    {
        public EmissionChangeForm()
        {
            InitializeComponent();
        }

        public string Source
        {
            get => ChangeSourceText.Text;
            set => ChangeSourceText.Text = value;
        }
        public string Unit
        {
            get => ChangeUnitText.Text;
            set => ChangeUnitText.Text = value;
        }

        public double Value
        {
            get => double.Parse(ChangeValueText.Text);
            set => ChangeValueText.Text = value.ToString();
        }
        public string Location
        {
            get => ChangeLocationText.Text;
            set => ChangeLocationText.Text = value;
        }

        public event EventHandler SubmitButtonClicked;
    }

    
}
