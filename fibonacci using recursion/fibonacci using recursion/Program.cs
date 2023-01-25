namespace fibonacci_using_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());

            int fibonacci = Functionoffibonaaci(number);

            Console.WriteLine(fibonacci);
            Console.ReadLine();
        }

        private static int Functionoffibonaaci(int number)
        {
            int returnnumber = 0;
            if (number == 2)
                return 2;
            if(number ==1)
                return 1;

            returnnumber = Functionoffibonaaci(number - 2) + Functionoffibonaaci(number - 1);
            return returnnumber;

        }
    }
}