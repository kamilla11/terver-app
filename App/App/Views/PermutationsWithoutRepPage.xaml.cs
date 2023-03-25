using App.Services;

namespace App.Views;

public partial class PermutationsWithoutRepPage : ContentPage
{

	public PermutationsWithoutRepPage()
	{
		InitializeComponent();
	}

	private void OnCalculateClicked(object sender, EventArgs e)
	{
		var n = EntryN.Text;

		if (n.Length == 0)
		{
			AnswerLabel.Text = "Заполните поле!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}

		else if (!int.TryParse(n, out var intN))
		{
			AnswerLabel.Text = "Введите числа!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}
		else
		{
			var result = MathHelper.Factorial(intN);
			AnswerLabel.Text = "Ответ: "+result;
			AnswerLabel.TextColor = Color.FromRgb(81, 43, 212);
		}
	}
	
}


