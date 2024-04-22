using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class ActionBook : Book, IBook
    {
        private string TimePeriod;
        private string WeaponTypes;

        public ActionBook(string title, string author, int releaseyear, int id, string timeperiod, string weapontypes)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseyear;
            Id = id;
            IsLoaned = false;
            TimePeriod = timeperiod;
            WeaponTypes = weapontypes;
        }

        public override void WriteOutBookInfoLibrary()
        {
            string message = $"Tittel: {Title}, Forfatter {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, TimePeriod: {TimePeriod}, Våpentyper: {WeaponTypes}, lånt ut: {IsLoaned}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoTemplateBookstore()
        {
            string message = $"Tittel: {Title}, Forfatter {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, TimePeriod: {TimePeriod}, Våpentyper: {WeaponTypes}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoLender()
        {
            string message = $"Tittel: {Title}, Forfatter {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, TimePeriod: {TimePeriod}, Våpentyper: {WeaponTypes}";
            Console.WriteLine(message);
        }

    }
}
