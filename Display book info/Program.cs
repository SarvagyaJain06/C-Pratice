using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_book_info
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("BASIC", "S.TROELSTRA");
            Book book2 = new Book("C+", "G.RTRTG");
            book1.DisplayBook();
            book2.DisplayBook();
            Console.ReadLine();

        }


        struct Book
        {
            string _bookName;
            string _authorName;

            public Book(string bookName, string authorName)
            {
                _bookName = bookName;
                _authorName = authorName;
            }
            public void DisplayBook()
            {
                Console.WriteLine("Book name : {0}, Author name : {1}", _bookName, _authorName);

            }
        }
    }
}
