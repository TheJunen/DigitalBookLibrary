//Lag en applikasjon som simulerer et bibliotek. Applikasjonen skal ha klasser for bøker, utlånere og biblioteket selv. Utlånere kan låne bøker,
//levere tilbake bøker og sjekke tilgjengeligheten til bøker. Biblioteket kan administrere bøkene sine,
//føre oversikt over utlån og tilgjengelighet, og tilby tjenester som fornyelse av lån.
namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var templatebookstore = new TemplateBookstore();
            var book1 = new Book("New Zealand Nature", "Zealand Works", 2022, 1);
            var book2 = new AdventureBook("Narnia 1", "Tolkien", 2015, 2, "Nei", "Ja");
            templatebookstore.ListOfBooksInTemplateBookstore.AddRange(new List<Book>
            {
                new DramaBook("Dagboken", "Copenhagen Ent", 2010, 3, "Romance"),
                new ActionBook("James Bond 1", "Jan Wilshere", 2008, 4, "Moderne tid", "Skytevåpen"),
                new Book ("På landstur", "Copenhagen Ent", 2020, 5),
                new AdventureBook("Ringenes Herre 1", "Tolkien", 2012, 6, "Ja", "Ja")
            });

            library.AddToLibrary(book1);
            library.AddToLibrary(book2);
            library.LoanOutBook(book1);
            library.PrintOutListOfBooksInLibrary();
            Console.WriteLine();
            var TripToTemplateBookStore = templatebookstore.BuyFromTemplateBookstore();
            Console.WriteLine();
            library.AddToLibrary(TripToTemplateBookStore);
            bool Shopping = true;
            while (Shopping)
            {
                string BuyAgain = "Ønsker du å kjøpe på nytt, skriv 1, skriv noe annet for å avslutte.";
                Console.WriteLine(BuyAgain);
                string BuyAgainAnswer = Console.ReadLine();
                if (BuyAgainAnswer == "1")
                {
                    Book ShoppingResult = templatebookstore.BuyFromTemplateBookstore();
                    library.AddToLibrary(ShoppingResult);
                }
                else
                {
                    Shopping = false;
                }
            }
            library.PrintOutListOfBooksInLibrary();

            //her skal være sortert liste av library basert på tilgjengelige bøker
            var ListOfAvailbleBooksInLibrary = library.ListOfBooksInLibrary.Where(x => x.IsLoaned == false).ToList();
            var lender1 = new Lender("Arne", 22);
            lender1.LenderSimulation(ListOfAvailbleBooksInLibrary, library.ListOfBooksInLibrary, lender1.ListOfBooksToLenders);

        }
    }
}


