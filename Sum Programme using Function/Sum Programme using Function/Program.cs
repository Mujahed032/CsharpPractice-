namespace Sum_Programme_using_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 10");
            int number = int.Parse(Console.ReadLine());

            int Sum = FunctiontogetSum(number);
            Console.WriteLine($"your sum result is {Sum}");
            Console.ReadLine();
        }

        private static int FunctiontogetSum(int number)
        {
            int sum = 0;
            for(int i=1; i<=number; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}