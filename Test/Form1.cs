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
        //Prezenter - ³¹cznik miêdzy widokiem a modelami
        private readonly IEmissionPresenter _presenter;

        //Eventy
        public event EventHandler AddButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler EmissionChangeFormLoaded;

        public Form1()
        {
            InitializeComponent();


            //Tworzê prezenter w konstruktorze -> wywo³uje metodê SetView: przypisuje Eventy do metod z prezentera
            _presenter = new EmissionPresenter(new Database.DBConnector());
            _presenter.SetView(this);


            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
            Load += (sender, e) => FormLoaded?.Invoke(sender, e);
            ChangeButton.Click += (sender, e) => EmissionChangeFormLoaded?.Invoke(sender, e);

        }




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



        // Wyœwietlanie Komunikatów o dodawaniu do grida na pierwszej formie
        public void ShowMessage(string message)
        {
            _ = MessageBox.Show(message);
        }

        //Metoda wykonuj¹ca siê przy otwarciu formy oraz przyciœniêciu Add
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

        // Manipulacja guziczkiem - zabawa joystickiem
        public bool isRecordSelected()
        {
            if (EmissionsGrid.SelectedRows.Count > 0)
            {
                ChangeButton.Enabled = true;
                return true;
            }
            else
            {
                ChangeButton.Enabled = false;
                return false;
            }
        }

        // Pobieranie danych o recordzie z grida
        public (string Col1, string Col2, string Col3, string Col4, string Col5) GetRecord()
        {
            string col1 = EmissionsGrid.SelectedRows[0].Cells["ID"].Value.ToString();
            string col2 = EmissionsGrid.SelectedRows[0].Cells["Source"].Value.ToString();
            string col3 = EmissionsGrid.SelectedRows[0].Cells["Unit"].Value.ToString();
            string col4 = EmissionsGrid.SelectedRows[0].Cells["Value"].Value.ToString();
            string col5 = EmissionsGrid.SelectedRows[0].Cells["Location"].Value.ToString();

            return (col1, col2, col3, col4, col5);
        }

        private void EmissionsGrid_SelectionChanged(object sender, EventArgs e)
        {
            _ = EmissionsGrid.SelectedRows.Count > 0 ? ChangeButton.Enabled = true : ChangeButton.Enabled = false;
            
        }
    }


}
