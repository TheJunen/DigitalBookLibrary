using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Lag en applikasjon som simulerer et bibliotek. Applikasjonen skal ha klasser for bøker, utlånere og biblioteket selv. Utlånere kan låne bøker,
//levere tilbake bøker og sjekke tilgjengeligheten til bøker. Biblioteket kan administrere bøkene sine,
//føre oversikt over utlån og tilgjengelighet, og tilby tjenester som fornyelse av lån.

namespace Library
{
    internal class Book
    {
        public int Id { get;  set; }
        public string _title { get;  protected set; }
        public string Author { get;  protected set; }
        public int ReleaseYear { get;  protected set; }
        protected internal bool IsLoaned { get;  set; }
        
        public string Title
        {
            get { return _title; }
            protected set
            {
                if (value != null && value.Length > 0)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException("Tittel må ikke være null eller tom");
                }
            }
        }

        public Book(string title, string author, int releaseyear, int id)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseyear;
            Id = id;
            IsLoaned = false;
        }

        public Book()
        {

        }

        public virtual void WriteOutBookInfoLibrary() //polymorfi, definisjonen på at forskjellige objekter reagerer annerledes på logikken.
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, lånt ut: {IsLoaned}";
            Console.WriteLine(message);
        }

        public virtual void WriteOutBookInfoTemplateBookstore()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}";
            Console.WriteLine(message);
        }

        public virtual void WriteOutBookInfoLender()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}";
            Console.WriteLine(message);
        }

        internal void ChangeTitle(string title)
        {
            Title = title;
        }
    }
}
