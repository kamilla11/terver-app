using App.Services;
namespace App.Views;

public partial class PlacementsWithoutRepPage : ContentPage
{
    public PlacementsWithoutRepPage()
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
            AnswerLabel.TextColor = Color.FromRgb(256, 0, 0);
        }

        else if (!int.TryParse(n, out var intN) || !int.TryParse(k, out var intK))
        {
            AnswerLabel.Text = "Введите числа!";
            AnswerLabel.TextColor = Color.FromRgb(256, 0, 0);
        }
        else if (intN<intK)
        {
            AnswerLabel.Text = "n должен быть больше или равен k!";
            AnswerLabel.TextColor = Color.FromRgb(256,0,0);
        }
        else
        {
            var result = MathHelper.Factorial(intN) / MathHelper.Factorial(intN - intK);
            AnswerLabel.Text = "Ответ: " + result;
            AnswerLabel.TextColor = Color.FromRgb(81, 43, 212);
        }
    }


}