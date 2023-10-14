using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Database;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class EmissionChangeForm : Form, IEmissionChangeView
    {
        //Deklaruje sobie zmienną, do której przesyłam ID zaznaczonego rekordu
        private int _id;
        private string _temporaryId;
        private Form1 _form;
        private EmissionChangePresenter _presenter;
        private DBConnector _dbConnector;

        public EmissionChangeForm(string SourceFromDB, string UnitFromDB, string ValueFromDB, string LocationFromDB, string IdFromDB, Form1 parentForm)
        {
            InitializeComponent();

            // Przypisuje wartości z grida do textboxów
            _temporaryId = IdFromDB;
            _id = int.Parse(_temporaryId);
            ChangeSourceText.Text = SourceFromDB;
            ChangeUnitText.Text = UnitFromDB;
            ChangeValueText.Text = ValueFromDB;
            ChangeLocationText.Text = LocationFromDB;
            _form = parentForm;
            _presenter = new EmissionChangePresenter(new Database.DBConnector(), _form);
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
        public Form parentForm
        {
            get => _form;
            set => throw new NotImplementedException();
        }


        public event EventHandler SubmitButtonClicked;

        public void CloseParentForm()
        {
            throw new NotImplementedException();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {   
            SubmitButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
           
        }
    }


}
