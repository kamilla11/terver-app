using App.Services;

namespace App.Views;

public partial class CombinationsWithRepPage : ContentPage
{

	public CombinationsWithRepPage()
	{
		InitializeComponent();
	}

	private void OnCalculateClicked(object sender, EventArgs e)
	{
		var n = EntryN.Text;
		var k = EntryK.Text;

		if (n.Length == 0 || k.Length == 0)
		{
			AnswerLabel.Text = "Заполните оба поля!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}

		else if (!int.TryParse(n, out var intN) || !int.TryParse(k, out var intK))
		{
			AnswerLabel.Text = "Введите числа!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}
		else
		{
			var result = MathHelper.Factorial(intN + intK - 1) /
			             (MathHelper.Factorial(intK) * MathHelper.Factorial(intN - 1));
			AnswerLabel.Text = "Ответ: "+result;
			AnswerLabel.TextColor = Color.FromRgb(81, 43, 212);
        }
	}

}


