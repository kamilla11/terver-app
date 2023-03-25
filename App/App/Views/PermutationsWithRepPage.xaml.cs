using App.Services;

namespace App.Views;

public partial class PermutationsWithRepPage : ContentPage
{

	public PermutationsWithRepPage()
	{
		InitializeComponent();
	}

	private void OnCalculateClicked(object sender, EventArgs e)
	{
		var n = EntryN.Text;
		var nk = EntryNk.Text;
		IEnumerable<int> numbersN;
		
		try
		{
			numbersN = nk.Split(' ').Select(x => MathHelper.Factorial(int.Parse(x)));
		}
		catch
		{
			AnswerLabel.Text = "Введите числа!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
			return;
		}
		
		
		if (n.Length == 0 ||  nk.Length == 0)
		{
			AnswerLabel.Text = "Заполните все поля!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}

		else if (!int.TryParse(n, out var intN))
		{
			AnswerLabel.Text = "Введите числа!";
			AnswerLabel.TextColor = Color.FromRgb(256,0,0);
		}
		else
		{
			var result = MathHelper.Factorial(intN) / MathHelper.MultiplyNumbers(numbersN);
			AnswerLabel.Text = "Ответ: "+result;
			AnswerLabel.TextColor = Color.FromRgb(81, 43, 212);
        }
	}

}


