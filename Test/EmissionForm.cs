using System.Diagnostics;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class EmissionForm : Form, IEmissionView
    {
        //Prezenter - ��cznik mi�dzy widokiem a modelami
        private readonly IEmissionPresenter _presenter;

        //Eventy
        public event EventHandler AddButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler EmissionChangeFormLoaded;
        public event EventHandler DeleteButtonClicked;

        public EmissionForm()
        {
            InitializeComponent();

            //Tworz� prezenter w konstruktorze -> wywo�uje metod� SetView: przypisuje Eventy do metod z prezentera
            _presenter = new EmissionPresenter(new Database.EmissionsRepository());
            _presenter.SetView(this);

            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
            DeleteButton.Click += (sender, e) => DeleteButtonClicked?.Invoke(sender, e);
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
        public EmissionModel CurrentRecord
        {
            get => emissionModelBindingSource.Current as EmissionModel;
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
            //EmissionsGrid.DataSource = emissions;
            emissionModelBindingSource.DataSource = emissions;
        }

        private void EmissionsGrid_SelectionChanged(object sender, EventArgs e)
        {
            var isSelected = emissionModelBindingSource.Current != null;

            ChangeButton.Enabled = isSelected;
            DeleteButton.Enabled = isSelected;
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
    }
}
