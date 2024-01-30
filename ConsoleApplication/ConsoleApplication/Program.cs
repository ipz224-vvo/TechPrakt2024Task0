namespace ConsoleApplication;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 2 numbers, delimeted by Enter:");
        double firstNumber, secondNumber;
        string firstNumberInput  = Console.ReadLine();

        if(!double.TryParse(firstNumberInput, out firstNumber))
        {
            Console.WriteLine("First number is not valid!");
            return;
        }
        string secondNumberInput = Console.ReadLine();
        if (!double.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("Second number is not valid!");
            return;
        }
        Console.WriteLine($"Sum of numbers: {firstNumber + secondNumber}");
    }
}
