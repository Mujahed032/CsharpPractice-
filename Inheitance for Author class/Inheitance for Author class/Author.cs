using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheitance_for_Author_class
{
    internal  class Author
    {
        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    throw new ArgumentNullException("First Name cant be empty");
                else
                { _FirstName = value; }

            }

        }
        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Last Name cant be emplty");
                else { _LastName = value; }
            }
        }
        public int Id { get; set; }

        public Author(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName= lastName;
            Id = id;
            Books = new List<Book>();

        }



        public List<Book> Books { get; set; }

        public void DisplayBooks()
        {
            Console.WriteLine($"The author {FirstName} {LastName} wrote the following books.");
            foreach(Book xyzBook in Books)
            {
                Console.WriteLine(xyzBook.ToString());
            }
        }

        public void Describe()
        {
            Console.WriteLine($"Author FirstName is {FirstName}");
            Console.WriteLine($"Author LastName is {LastName}");
            Console.WriteLine($"Author id is {Id}");
        }





    }
}
