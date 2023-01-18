namespace ReadFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileContents = File.ReadAllLines("C:\\Windows\\Logs\\CBS\\CbsPersist_20230112171928.log");

            foreach(string eachLine in fileContents)
                Console.WriteLine(eachLine);
        }
    }
}