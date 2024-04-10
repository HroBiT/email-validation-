using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj maila do sprawdzenia");
        var mail = Console.ReadLine();

        var pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";

        var hej = Regex.IsMatch(mail, pattern);

        Console.WriteLine(hej);

    }
}