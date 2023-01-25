namespace Inheritance_testing_file
{
    internal class Program
    {
        private static employee thisPerson;

        static void Main(string[] args)
        {
            employee obj1 = new employee("khizar", 111, 1000,"lecturer");
            obj1.DescribeMe();
            employee obj2=new employee("azhar",222,2000,"H.O.D");
            obj2.DescribeMe();

            Student value1 = new Student("zaki", 145, "EEE");
            value1.DescribeMe();
            Student value2 = new Student("rafi", 135, "EcE");
            value2.DescribeMe();


           Console.ReadLine();
        }
    }
}