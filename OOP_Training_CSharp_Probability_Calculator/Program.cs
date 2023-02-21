using OOP_Training_CSharp_Probability_Calculator;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main()
    {

        Hat testHat = new(new Dictionary<string, int>() { { "blue", 3 }, { "red", 2 }, { "green", 6 } });
        double probability = ProbCalculator.Experiment(testHat, new Dictionary<string, int>() { { "blue", 2 }, { "green", 1 } }, 4, 10000); 
        Console.WriteLine($"The probability is: {probability}"); 

    }
}
