using com.m2i.formation.media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation.com.m2i.formation.media
{
    public abstract class Media : Item
    {
        public Author[] Authors { get; private set; } = new Author[10];
        private int nbAuthors = 0;

        public DateTime Date
        {
            get; set;
        }
        public string Titre
        {
            get; set;
        }

        public Publisher Publisher
        {
            get; set;
        }
        public void addAuthor(Author auteur)
        {
            Authors[nbAuthors] = auteur;
            nbAuthors++;

        }

        public void displayAuthor()
        {
            Console.WriteLine("liste des auteurs de " + this.Titre + " : ");
            Console.WriteLine();
            for (int i = 0; i < this.nbAuthors; i++)
            {
                Console.WriteLine(this.Authors[i].FirstName + " " + this.Authors[i].LastName);

            }
        }

        public abstract double getVAPrice();

    }

}
