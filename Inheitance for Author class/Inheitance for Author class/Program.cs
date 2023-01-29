namespace Inheitance_for_Author_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Author obj = new Author("arif","ali",111);
            obj.Describe();

            Book author = new Book("physics", 222, 750, 2012);
            author.Display();



        }
    }
}