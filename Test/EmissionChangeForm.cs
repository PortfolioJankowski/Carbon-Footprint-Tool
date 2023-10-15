﻿using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class EmissionChangeForm : Form, IEmissionChangeView
    {
        public event EventHandler SubmitButtonClicked;

        //Deklaruje sobie zmienną, do której przesyłam ID zaznaczonego rekordu
        private int _id;
        private EmissionChangePresenter _presenter;

        public EmissionChangeForm(EmissionModel model)
        {
            InitializeComponent();

            // Przypisuje wartości z grida do textboxów
            _id = model.ID;
            Source = model.Source;
            Unit = model.Unit;
            Value = model.Value;
            EmissionLocation = model.Location;

            _presenter = new EmissionChangePresenter(new Database.EmissionsRepository());
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
            get
            {
                if (double.TryParse(ChangeValueText.Text, out double result))
                {
                    return result;
                }
                else
                {
                    return -1.0;
                }
            }
            set => ChangeValueText.Text = value.ToString();
        }

        public string EmissionLocation
        {
            get => ChangeLocationText.Text;
            set => ChangeLocationText.Text = value;
        }

        public int Id
        {
            get => _id;
            set => throw new NotImplementedException();
        }

    }
}
