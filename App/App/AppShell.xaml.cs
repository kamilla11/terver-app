namespace App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Views.PlacementsWithRepPage), typeof(Views.PlacementsWithRepPage));
		Routing.RegisterRoute(nameof(Views.PlacementsWithoutRepPage), typeof(Views.PlacementsWithoutRepPage));
		Routing.RegisterRoute(nameof(Views.PermutationsWithRepPage), typeof(Views.PermutationsWithRepPage));
		Routing.RegisterRoute(nameof(Views.PermutationsWithoutRepPage), typeof(Views.PermutationsWithoutRepPage));
		Routing.RegisterRoute(nameof(Views.CombinationsWithRepPage), typeof(Views.CombinationsWithRepPage));
		Routing.RegisterRoute(nameof(Views.CombinationsWithoutRepPage), typeof(Views.CombinationsWithoutRepPage));
	}
}