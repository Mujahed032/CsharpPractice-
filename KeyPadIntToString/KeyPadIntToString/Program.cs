namespace KeyPadIntToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //Given a number, Return the letters for that number
            //Dictionary
            //Function with switch statements.

            Dictionary<int, Char[]> keyValuePairs = new Dictionary<int, Char[]>();
            keyValuePairs.Add(2, new Char[] { 'a', 'b', 'c' });
            keyValuePairs.Add(3, new Char[] { 'd', 'e', 'f' });
            keyValuePairs.Add(4, new Char[] { 'g', 'h', 'i' });
            keyValuePairs.Add(5, new Char[] { 'j', 'k', 'l' });
            keyValuePairs.Add(6, new Char[] { 'm', 'n', 'o' });
            keyValuePairs.Add(7, new Char[] { 'p', 'q', 'r', 's' });
            keyValuePairs.Add(8, new Char[] { 't', 'u', 'v' });
            keyValuePairs.Add(9, new Char[] { 'w', 'x', 'y', 'z' });

            Console.WriteLine("Enter a number between 2 and 9: ");
                int numberEntered = int.Parse(Console.ReadLine());

            Char[] valueAtUserEnteredNumber;
            bool DoesValueExist = keyValuePairs.TryGetValue(numberEntered, out valueAtUserEnteredNumber);

            if (DoesValueExist)
            {
                foreach (char x in valueAtUserEnteredNumber)
                {
                    Console.WriteLine(x);

                }
            }
            else { Console.WriteLine("You entered an invalid number."); }
        }

       
    }
}