using System.Configuration;
using Test.Database;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class Form1 : Form, IEmissionView
    {
        //Prezenter - ³¹cznik miêdzy widokiem a modelami
        private readonly IEmissionPresenter _presenter;

        //Eventy
        public event EventHandler AddButtonClicked;
        public event EventHandler FormLoaded;

        public Form1()
        {
            InitializeComponent();
            

            //Tworzê prezenter w konstruktorze -> wywo³uje metodê SetView: przypisuje Eventy do metod z prezentera
            _presenter = new EmissionPresenter(new Database.DBConnector());
            _presenter.SetView(this);


            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
            Load += (sender, e) => FormLoaded?.Invoke(sender, e);

        }



        //Metoda (chyba nie powinna tu byæ) -> pobieranie ConnectionStringa
       

        //Pobieranie danych z Textboxów z formy
        public string Source
        {
            get => SourceText.Text;
            set => SourceText.Text = value;
        }
        public string Unit
        {
            get => UnitText.Text;
            set => UnitText.Text = value;
        }

        public double Value
        {
            get => double.Parse(ValueText.Text);
            set => ValueText.Text = value.ToString();
        }
        public string Location
        {
            get => LocationText.Text;
            set => LocationText.Text = value;
        }




        public void ShowMessage(string message)
        {
            _ = MessageBox.Show(message);
        }

        public void DisplayData(List<EmissionModel> emissions)
        {
            EmissionsGrid.DataSource = emissions;
            EmissionsGrid.ReadOnly = true;
            EmissionsGrid.BackgroundColor = Color.Beige;
            EmissionsGrid.ForeColor = Color.Black;
            EmissionsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }


}
