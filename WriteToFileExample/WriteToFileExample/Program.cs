using System.Text;

namespace WriteToFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outPutFilePath = "C:\\Users\\azeem\\Desktop\\RecursionOutput.log";
            Console.WriteLine("Enter a number you want to find the factorial for: ");

            int number = int.Parse(Console.ReadLine());

            StringBuilder fileLogContents = new StringBuilder();
            fileLogContents.AppendLine("We've asked the user to enter a number and he entered : " + number);
               
            

            int factorial = RecursionFactorial(number);

            Console.WriteLine("Factorial of the number is " + factorial);

            fileLogContents.AppendLine($"Factorial is calculated using Recursion. Factorial of {number} is : {factorial}" );

            File.WriteAllText(outPutFilePath, fileLogContents.ToString());

        }

        private static int RecursionFactorial(int number)
        {
            int numberToReturn = 0;
            if (number == 2)
                return 2;
            if (number == 1)
                return 1;

            numberToReturn = number * RecursionFactorial(number - 1);
            return numberToReturn;
        }
    }

   
}