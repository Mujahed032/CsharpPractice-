namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number you want to find the factorial for: ");
                int number = int.Parse(Console.ReadLine());
                if(number <= 0)
                {
                    Console.WriteLine("This input cannot be accepted. It should be greater than zero.");
                    return;
                }
                int factorial = RecursionFactorial(number);

                Console.WriteLine("Factorial of the number is " + factorial);
            }
            
            catch (Exception ex1)
            {
                Console.WriteLine("The process was terminated prematurely. See the logs.");
            }
            
           
            
        }

        private static int RecursionFactorial(int number)
        {
            
            int numberToReturn = 0;
            if (number == 2)
                return 2;
            if(number == 1)
                return  1;

            numberToReturn = number + RecursionFactorial(number - 1);
            return numberToReturn;
        }
    }
}