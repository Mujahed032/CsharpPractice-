namespace Mul_programme_using_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 10");
            int number = int.Parse(Console.ReadLine());

            int Mul = FunctiontogetMul(number);
            Console.WriteLine($"Mul result is {Mul}");
            Console.ReadLine();
        }

        private static int FunctiontogetMul(int number)
        {
            int mul = 1;
            for(int i=1; i<=number;i++)
            {
                mul= mul*i;
            }
            return mul;
        }
    }
}