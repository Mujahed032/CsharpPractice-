namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
            string userEntername = Console.ReadLine();
            int age = Recieveage(userEntername);
            Console.WriteLine(age);
        }

        private static int Recieveage(string? userEntername)
        {
            int returnage = 0;
            switch(userEntername)
            {
                
                case  "khizar":
                    returnage =28;
                    break;
                case "malik":
                    returnage = 24;
                    break;
                
            }
            return  returnage;
        }
    }
}