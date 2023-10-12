using System.Configuration;
using System.Windows.Forms;
using Test.Database;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class Form1 : Form, IEmissionView
    {
        //Prezenter - ��cznik mi�dzy widokiem a modelami
        private readonly IEmissionPresenter _presenter;

        //Eventy
        public event EventHandler AddButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler EmissionChangeFormLoaded;

        public Form1()
        {
            InitializeComponent();


            //Tworz� prezenter w konstruktorze -> wywo�uje metod� SetView: przypisuje Eventy do metod z prezentera
            _presenter = new EmissionPresenter(new Database.DBConnector());
            _presenter.SetView(this);


            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
            Load += (sender, e) => FormLoaded?.Invoke(sender, e);
            ChangeButton.Click += (sender, e) => EmissionChangeFormLoaded?.Invoke(sender, e);

        }



        //Metoda (chyba nie powinna tu by�) -> pobieranie ConnectionStringa


        //Pobieranie danych z Textbox�w z formy
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



        // Wy�wietlanie Komunikat�w o dodawaniu do grida na pierwszej formie
        public void ShowMessage(string message)
        {
            _ = MessageBox.Show(message);
        }

        //Metoda wykonuj�ca si� przy otwarciu formy oraz przyci�ni�ciu Add
        public void DisplayData(List<EmissionModel> emissions)
        {
            //Czyszczenie formy
            SourceText.Text = "";
            UnitText.Text = "";
            ValueText.Text = "";
            LocationText.Text = "";

            //Ustawienia grida
            EmissionsGrid.DataSource = emissions;
            EmissionsGrid.ReadOnly = true;
            EmissionsGrid.BackgroundColor = Color.Beige;
            EmissionsGrid.ForeColor = Color.Black;
            EmissionsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void EmissionsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (EmissionsGrid.SelectedRows.Count > 0)
            {
                ChangeButton.Enabled = true;
            }
            else
            {
                // Dezaktywuj przycisk, poniewa� nie ma zaznaczonego wiersza
                ChangeButton.Enabled = false;
            }
        }
    }


}
