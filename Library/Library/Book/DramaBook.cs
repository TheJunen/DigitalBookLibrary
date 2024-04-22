using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class DramaBook : Book, IBook
    {
        private string DramaType;

        public DramaBook(string title, string author, int releaseyear, int id, string dramatype)
        {
            Title = title;
            Author = author;
            ReleaseYear = releaseyear;
            Id = id;
            DramaType = dramatype;
        }
        public override void WriteOutBookInfoLibrary()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Dramatype: {DramaType}, lånt ut: {IsLoaned}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoTemplateBookstore()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Dramatype: {DramaType}";
            Console.WriteLine(message);
        }

        public override void WriteOutBookInfoLender()
        {
            string message = $"Tittel: {Title}, Forfatter: {Author}, Lanseringsår: {ReleaseYear}, Id: {Id}, Dramatype: {DramaType}";
            Console.WriteLine(message);
        }
    }

}
