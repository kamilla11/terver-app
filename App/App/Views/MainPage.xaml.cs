namespace App.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPermWithoutRepClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("PermutationsWithoutRepPage");
	}
    private void OnPermWithRepClicked(object sender, EventArgs e)
    {
	    Shell.Current.GoToAsync("PermutationsWithRepPage");
    }
    private void OnCombWithoutRepClicked(object sender, EventArgs e)
    {
	    Shell.Current.GoToAsync("CombinationsWithoutRepPage");
    }
    private void OnCombWithRepClicked(object sender, EventArgs e)
    {
	    Shell.Current.GoToAsync("CombinationsWithRepPage");
    }
    private void OnPlcmntWithoutRepClicked(object sender, EventArgs e)
    {
	    Shell.Current.GoToAsync("PlacementsWithoutRepPage");
    }
    private void OnPlcmntWithRepClicked(object sender, EventArgs e)
    {
	    Shell.Current.GoToAsync("PlacementsWithRepPage");
    }
}