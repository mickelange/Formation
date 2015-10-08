using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Book
    {
        private Author[] authors = new Author[10];
        private int nbAuthors =0;

        public string Isbn
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
        public string Titre
        {
            get; set;
        }
        public int NbPages
        {
            get; set;
        }
        public string Lang
        {
            get; set;
        }

        public Publisher Publisher
        {
            get; set;
        }

        public void addAuthor(Author auteur)
        {
            authors[nbAuthors] = auteur;
            nbAuthors++;

        }

        public void displayAuthor()
        {
            Console.WriteLine("liste des auteurs de " + this.Titre + " : ");
            Console.WriteLine();
            for (int i = 0; i < this.nbAuthors; i++)
            {
                Console.WriteLine(this.authors[i].firstName + " " + this.authors[i].lastName);

            }
        }


    }
}
