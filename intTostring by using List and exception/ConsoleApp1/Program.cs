namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter number between 2 to 9");
                int number = int.Parse(Console.ReadLine());
                List<char> keypardletters = functionforkeypardletter(number);
                if (keypardletters.Count == 0)
                {
                    foreach (char c in keypardletters)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("we encountered a problem please reachout to me");
                Console.ReadLine();
            }
        }

        private static List<char> functionforkeypardletter(int number)
        {
            List<char> returnletters= new List<char>();
            switch(number)
            {
                case 2:
                returnletters.Add('a');
                    returnletters.Add('b');
                        returnletters.Add('c');
                       break;
            }
            return returnletters;
        }
    }
}