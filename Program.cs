namespace SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            float secondNum = float.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of numbers = {firstNum + secondNum}");
        }
    }
}

