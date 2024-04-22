using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class AdventureBook : Book, IBook
    {
        private string DoesItHaveMagic;
        private string IsItInAnotherWorld;

        public AdventureBook(string title, string author, int releaseyear, int id, string doesithavemagic, string isitinanotherworld)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseyear;
            Id = id;
            DoesItHaveMagic = doesithavemagic;
            IsItInAnotherWorld = isitinanotherworld;
        }

        public override void WriteOutBookInfoLibrary()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Magi?: {DoesItHaveMagic}, I annen verden?: {IsItInAnotherWorld}, lånt ut: {IsLoaned}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoTemplateBookstore()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Magi?: {DoesItHaveMagic}, I annen verden?: {IsItInAnotherWorld}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoLender()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Magi?: {DoesItHaveMagic}, I annen verden?: {IsItInAnotherWorld}";
            Console.WriteLine(message);
        }
    }
}
