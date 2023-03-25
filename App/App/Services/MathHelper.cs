namespace App.Services;

public static class MathHelper
{
    public static int Factorial(int n)
    {
        if (n == 1) return 1;

        return n * Factorial(n - 1);
    }

    public static long MultiplyNumbers(IEnumerable<int> numbers)
    {
        long result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }
        return result;
    }
}