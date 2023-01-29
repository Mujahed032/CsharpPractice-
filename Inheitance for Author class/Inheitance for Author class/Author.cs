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
        public int id { get; set; }

        public Author(string firstName, string lastName, int id)
        {
            this._FirstName= firstName;
            this._LastName= lastName;
            this.id = id;

        }

        List<Book> Authors = new List<Book>();
        
           

           
    }
}
