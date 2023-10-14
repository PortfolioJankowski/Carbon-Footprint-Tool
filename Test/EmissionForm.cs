using System.Diagnostics;
using Test.Models;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class EmissionForm : Form, IEmissionView
    {
        //Prezenter - ³¹cznik miêdzy widokiem a modelami
        private readonly IEmissionPresenter _presenter;

        //Eventy
        public event EventHandler AddButtonClicked;
        public event EventHandler FormLoaded;
        public event EventHandler EmissionChangeFormLoaded;
        public event EventHandler DeleteButtonClicked;

        public EmissionForm()
        {
            InitializeComponent();

            //Tworzê prezenter w konstruktorze -> wywo³uje metodê SetView: przypisuje Eventy do metod z prezentera
            _presenter = new EmissionPresenter(new Database.EmissionsRepository());
            _presenter.SetView(this);

            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
            DeleteButton.Click += (sender, e) => DeleteButtonClicked?.Invoke(sender, e);
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
        public EmissionModel CurrentRecord
        {
            get => emissionModelBindingSource.Current as EmissionModel;
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
            MessageBox.Show("Super ch³op");
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
                Console.WriteLine("Wyst¹pi³ b³¹d: " + ex.Message);
            }
        }
    }
}
