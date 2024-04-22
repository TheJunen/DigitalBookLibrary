using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library : Book
    {
        //Book book = new Book();
        internal List<Book> ListOfBooksInLibrary = new List<Book>();
        internal void LoanOutBook(Book book)
        {
            book.IsLoaned = true;
        }

        internal void ReturnBook(Book book)
        {
            book.IsLoaned = false;
        }

        internal void AddToLibrary(Book book)
        {
            ListOfBooksInLibrary.Add(book);
        }

        internal void PrintOutListOfBooksInLibrary()
        {
            var message = "Her er listen av bøker i biblioteket:";
            Console.WriteLine(message);
            foreach (Book book in ListOfBooksInLibrary)
            {
                book.WriteOutBookInfoLibrary();
            }
        }

        internal void PrintOutListOfBooksInLibrary(List<Book> listofbooksinlibrary)
        {
            var message = "Her er listen av bøker i biblioteket:";
            Console.WriteLine(message);
            foreach (Book book in listofbooksinlibrary)
            {
                book.WriteOutBookInfoLibrary();
            }
        }

        internal void PrintOutListOfAvailableBooksInLibrary(List<Book> listofavailablebooksinlibrary)
        {
            var message = "Her er listen av tilgjengelige bøker i biblioteket:";
            Console.WriteLine(message);
            foreach (Book book in listofavailablebooksinlibrary)
            {
                book.WriteOutBookInfoLibrary();
            }
        }
    }
}