using System.
    Reflection.Metadata.Ecma335;
using System.Text;

namespace Testing_for_fibonacci
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string outputfilepath = "C:\\Users\\hp\\OneDrive\\Desktop\\khizar.txt";
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            StringBuilder Filepath = new StringBuilder();
            Filepath.AppendLine("ask user to input a number"+ number);

            int recursion = Functiontogetvalue(number);
             Console.WriteLine(recursion);
            Filepath.AppendLine("recursion is calculated using recoursion" + "recousrion answer is" + recursion);
             File.WriteAllText(outputfilepath, Filepath.ToString());

            Console.ReadLine();
            
        }

        private static int Functiontogetvalue(int number)
        {
            int returnnumber = 0;
            if (number == 2)
                return 2;
            if (number == 1)
                return 1;
            return number  = number * Functiontogetvalue(number -1);
            return returnnumber;

        }
    }
    
}