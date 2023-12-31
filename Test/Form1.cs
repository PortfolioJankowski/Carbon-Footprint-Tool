using System.Configuration;
using System.Diagnostics;
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
        public event EventHandler DeleteButtonClicked;

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
            EmissionsGrid.Columns["Id"].Visible = false;
            EmissionsGrid.Columns["Source"].Width = 180;
            EmissionsGrid.Columns["Unit"].Width = 50;
            EmissionsGrid.Columns["Value"].Width = 130;
            EmissionsGrid.Columns["Location"].Width = 170;
            EmissionsGrid.RowHeadersWidth = 50;

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
            _ = EmissionsGrid.SelectedRows.Count == 1 ? ChangeButton.Enabled = true : ChangeButton.Enabled = false;
            _ = EmissionsGrid.SelectedRows.Count == 1 ? DeleteButton.Enabled = true : DeleteButton.Enabled = false;

        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Super ch�op");
        }

        private void methodologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://ghgprotocol.org/corporate-standard";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wyst�pi� b��d: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(sender, e);
            this.Activate();
        }
    }


}
