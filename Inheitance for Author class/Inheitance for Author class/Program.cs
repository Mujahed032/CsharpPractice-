using Newtonsoft.Json;

namespace Inheitance_for_Author_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Book physicsBook = new Book("Physics", 222, 750, DateTime.Now);
            Book Book2 = new Book("Book2", 2, 750, DateTime.Now);
            Book Book3 = new Book("Book3", 3, 750, DateTime.Now);
            Book Book4 = new Book("Book4", 4, 750, DateTime.Now);
            Book Book5 = new Book("Book5", 5, 750, DateTime.Now);
            Book Book6 = new Book("Book6", 6, 750, DateTime.Now);
            Book Book7 = new Book("Book7", 7, 750, DateTime.Now);
            physicsBook.Display();

            Author arifAuthor = new Author("Arif", "Ali", 111);
           
            arifAuthor.Books.Add(physicsBook);
            arifAuthor.Books.Add(Book2);

            Author gatesAuthor = new Author("Gates", "ali", 111);
            gatesAuthor.Books.Add(Book3);
            gatesAuthor.Books.Add(Book4);
            gatesAuthor.Books.Add(Book5);

            arifAuthor.DisplayBooks();

            gatesAuthor.DisplayBooks();

            Console.WriteLine(physicsBook.ToString());

            //string arifAuthorInstanceString = JsonConvert.SerializeObject(arifAuthor);

            //string gatesAuthorInstanceString = JsonConvert.SerializeObject(gatesAuthor);

            //Author arifAuthorFromJson = JsonConvert.DeserializeObject<Author>(arifAuthorInstanceString);

            //List<Author> authors = new List<Author>();
            //authors.Add(arifAuthor);
            //authors.Add(gatesAuthor);

            List<Author> authors = new List<Author>() { arifAuthor, gatesAuthor };

            File.WriteAllText("C:\\Users\\azeem\\Desktop\\authors.json", JsonConvert.SerializeObject(authors));

            string fileContents = File.ReadAllText("C:\\Users\\azeem\\Desktop\\authors.json");

            var authorsRead = JsonConvert.DeserializeObject<List<Author>>(fileContents);
        }
    }
}