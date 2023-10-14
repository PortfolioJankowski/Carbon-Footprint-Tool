using Test.Database;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class EmissionChangeForm : Form, IEmissionChangeView
    {
        //Deklaruje sobie zmienną, do której przesyłam ID zaznaczonego rekordu
        private int _id;
        private EmissionForm _form;
        private EmissionChangePresenter _presenter;
        private EmissionsRepository _dbConnector;

        public EmissionChangeForm(EmissionModel model, EmissionForm parentForm)
        {
            InitializeComponent();

            // Przypisuje wartości z grida do textboxów
            _id = model.ID;
            Source = model.Source;
            Unit = model.Unit;
            Value = model.Value;
            EmissionLocation = model.Location;

            _form = parentForm;
            _presenter = new EmissionChangePresenter(new Database.EmissionsRepository(), _form);
            _presenter.SetView(this);

            SubmitButton.Click += (sender, e) => SubmitButtonClicked?.Invoke(sender, e);
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
        public string EmissionLocation
        {
            get => ChangeLocationText.Text;
            set => ChangeLocationText.Text = value;
        }
        public Form parentForm
        {
            get => _form;
            set => throw new NotImplementedException();
        }

        public int Id
        {
            get => _id;
            set => throw new NotImplementedException();
        }


        public event EventHandler SubmitButtonClicked;

        public void CloseParentForm()
        {
            throw new NotImplementedException();
        }
    }
}
