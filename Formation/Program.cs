using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.m2i.formation.media;
using com.m2i.formation.geometry;

namespace Formation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Titre = "java";
            Publisher editeur = new Publisher { Nom = "hachette", Id = 12345 };
            b.Publisher = editeur;
            Console.WriteLine(b.Titre);
            Console.WriteLine(b.Publisher.Nom);
            

            Author auteur1 = new Author();
            auteur1.FirstName = "Elizabeth";
            auteur1.LastName = "George";

            Author auteur2 = new Author();
            auteur2.FirstName = "Tom";
            auteur2.LastName = "Clancy";

            b.addAuthor(auteur2);
            b.addAuthor(auteur1);
            b.Category = BookCategory.Novel;
            b.displayAuthor();
            Console.ReadKey();

            ////test static
            Counter c1 = new Counter();
            Counter c2 = new Counter();

          
            Console.WriteLine(Counter.increment());//marche car statique!


        }
    }
}
