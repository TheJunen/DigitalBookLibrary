namespace Library
{
    internal class TemplateBookstore
    {
        internal List<Book> ListOfBooksInTemplateBookstore = new List<Book>();

        internal Book BuyFromTemplateBookstore()
        {
            string WelcomeMessage = "Hei og velkommen til Template Bookstore.";
            Console.WriteLine(WelcomeMessage);
            PrintOutListOfBooksInTemplateBookstore();
            string WhichBook = "Hvilken bok ønsker du å kjøpe? Trykk 1 for å kjøpe første bok i listen, 2 for nr2 også videre.";
            Console.WriteLine(WhichBook);
            string Answer = Console.ReadLine();
            int ConvertedToInt = Int32.Parse(Answer);
            int Input = ConvertedToInt - 1;
            //if (answer == "1")
            //{
            //    ListOfBooksInTemplateBookstore[0];
            //}
            //var library = new Library();
            var TransferToLibrary = ListOfBooksInTemplateBookstore[Input];
            //Console.WriteLine(TransferToLibrary);
            //library.AddToLibrary(TransferToLibrary);
            
            ListOfBooksInTemplateBookstore.RemoveAt(Input);
            return TransferToLibrary;
        }

        internal void AddToTemplateBookstore(Book book)
        {
            ListOfBooksInTemplateBookstore.Add(book);
        }

        internal void PrintOutListOfBooksInTemplateBookstore()
        {
            string message1 = "Her er listen av bøker tilgjengelig for salg:";
            Console.WriteLine(message1);
            foreach (Book book in ListOfBooksInTemplateBookstore) 
            {
                book.WriteOutBookInfoTemplateBookstore();
            }

        }
    }
}
