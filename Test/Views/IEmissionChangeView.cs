namespace Test.Views
{
    public interface IEmissionChangeView
    {
        int Id { get; set; }
        string Source { get; set; }
        string Unit { get; set; }   
        double Value { get; set; }
        string EmissionLocation { get; set; }

        event EventHandler SubmitButtonClicked;


    }
}
