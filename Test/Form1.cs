using System.Configuration;
using Test.Presenters;
using Test.Views;

namespace Test
{
    public partial class Form1 : Form, IEmissionView
    {
        private readonly IEmissionPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new EmissionPresenter(new Database.DBConnector(LoadConnectionString()));
            _presenter.SetView(this);

            AddButton.Click += (sender, e) => AddButtonClicked?.Invoke(sender, e);
        }

        public string LoadConnectionString (string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
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


        public event EventHandler AddButtonClicked;

        public void ShowMessage(string message)
        {
            _ = MessageBox.Show(message);
        }
    }


}
