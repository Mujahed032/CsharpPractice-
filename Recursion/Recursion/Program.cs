namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to find the factorial for: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = RecursionFactorial(number);
            
            Console.WriteLine("Factorial of the number is " + factorial);   
        }

        private static int RecursionFactorial(int number)
        {
            int numberToReturn = 0;
            if (number == 2)
                return 2;
            if(number == 1)
                return  1;

            numberToReturn = number * RecursionFactorial(number - 1);
            return numberToReturn;
        }
    }
}