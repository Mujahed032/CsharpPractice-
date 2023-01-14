namespace intTostring_by_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age=int.Parse(Console.ReadLine());
            string name = reversename(age);
            Console.WriteLine(name);
        }

        private static string reversename(int age)
        {
            string returnnames = null;
            switch(age)
             {
                case 28:
                    returnnames = "khizar";
                    break;
                case 24:
                    returnnames = "malik";
                    break;

            }
            return returnnames;
        }
    }
}