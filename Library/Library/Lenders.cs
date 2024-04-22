using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Lender
    {
        private string _name;
        private int Age { get; }
        private int HowManyBooksLoaned { get; set; }
        internal List<Book> ListOfBooksToLenders;
        Library library = new Library();
        public List<Book> AvailableBooks { get; set; }
        public List<Book> LenderList { get; set; }

        public Lender(string name, int age)
        {
            _name = name;
            Age = age;
            HowManyBooksLoaned = 0;
            ListOfBooksToLenders = new List<Book>();
        }

        public Lender(List<Book> availablebooks, List<Book> lenderlist)
        {
            AvailableBooks = availablebooks;
            LenderList = lenderlist;
        }
        internal string Name
        {
            get { return _name; }
            private set
            {
                if (value != null && value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Navn må ikke være null eller tom");
                }
            }
        }

        internal void ChangeName(string name)
        {
            Name = name;
        }

        internal void LenderSimulation(List<Book> listofavailablebooksinlibrary, List<Book> listofbooksinlibrary, List<Book> lenderlist)
        {
            bool Running = true;
            while (Running)
            {
                string LendersMessage = "Hei og velkommen til vårt bibliotek. Her kan du låne mange interessante bøker. Skriv 1 for å se listen av tilgjengelige bok og låne bok, 2 for å levere, noe annet for å avslutte.";
                Console.WriteLine(LendersMessage);

                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    (listofavailablebooksinlibrary, lenderlist) = LoanBookFromLibrary(listofavailablebooksinlibrary, lenderlist);
                }

                else if (answer == "2") //den ville bare kjørt en gang hvis jeg brukte 2 if, da while loop kan bare kjøre en if logikk.
                {
                    ReturnBookToLibrary(listofavailablebooksinlibrary, lenderlist);
                }

                else
                {
                    Running = false;
                    string Message = "Låner har nå avsluttet biblioteket.";
                    Console.WriteLine(Message);
                }
            }

        }

        private (List<Book>, List<Book>) LoanBookFromLibrary(List<Book> listofavailablebooksinlibrary, List<Book> lenderlist)
        {
            HowManyBooksLoaned++;
            library.PrintOutListOfAvailableBooksInLibrary(listofavailablebooksinlibrary);
            var Message = "Skriv 1 for å låne bok nr 1, 2 for å låne bok nr 2 også videre.";
            Console.WriteLine(Message);
            string LendersDecision = Console.ReadLine();
            int LendersDecisionInInt = Convert.ToInt32(LendersDecision) - 1;
            Console.WriteLine();
            lenderlist.Add(listofavailablebooksinlibrary[LendersDecisionInInt]);
            listofavailablebooksinlibrary.RemoveAt(LendersDecisionInInt);
            PrintOutLenderListOfBooks(lenderlist);
            string repeatLoanBookSimulation = "Ønsker du å låne en ny bok, skriv 1, skriv noe annet for å avslutte";
            Console.WriteLine(repeatLoanBookSimulation);
            string NewSimulationOrNot = Console.ReadLine();
            if (NewSimulationOrNot == "1")
            {
                if (listofavailablebooksinlibrary.Count > 0)
                {
                    return LoanBookFromLibrary(listofavailablebooksinlibrary, lenderlist);
                }
                else
                {
                    string MessageError = "Error. Det er ingen tilgjenglige bøker for utlån";
                    Console.WriteLine(MessageError);
                    LoanBookFromLibrary(listofavailablebooksinlibrary, lenderlist);
                }
            }

            return (listofavailablebooksinlibrary, lenderlist);
        }

        private void ReturnBookToLibrary(List<Book> listofavailablebooksinlibrary, List<Book> lenderlist)
        {
            HowManyBooksLoaned--;
            string LenderBookList = "Her er din liste av bøker for levering";
            Console.WriteLine(LenderBookList);
            PrintOutLenderListOfBooks(lenderlist);
            string LenderReturnMessage = "Skriv 1 for å levere bok nr 1, 2 for å levere bok nr 2 også videre.";
            Console.WriteLine(LenderReturnMessage);
            string Answer = Console.ReadLine();
            int AnswerToInt = Convert.ToInt32(Answer) - 1;
            listofavailablebooksinlibrary.Add(lenderlist[AnswerToInt]);
            lenderlist.RemoveAt(AnswerToInt);
            string UpdatedListOfBooksInLibraryMessage = "Her er den oppdaterte listen av tilgjengelige bøker i library";
            Console.WriteLine(UpdatedListOfBooksInLibraryMessage);
            library.PrintOutListOfBooksInLibrary(listofavailablebooksinlibrary);
            string repeatReturnBookSimulation = "Ønsker du å levere en annen bok, skriv 1, skriv noe annet for å avslutte.";
            Console.WriteLine(repeatReturnBookSimulation);
            string NewSimulationOrNot = Console.ReadLine();
            if (NewSimulationOrNot == "1")
            {
                ReturnBookToLibrary(listofavailablebooksinlibrary, lenderlist);
            }
            else
            {
            PrintOutLenderListOfBooks(lenderlist);
                //return;
            }
        }

        internal void PrintOutLenderListOfBooks(List<Book> lenderlist)
        {
            var message = "her er din liste av lånte bøker:";
            Console.WriteLine(message);
            foreach (Book book in lenderlist)
            {
                book.WriteOutBookInfoLender();
            }
        }
    }
}
