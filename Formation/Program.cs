using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Program
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
            auteur1.firstName = "Elizabeth";
            auteur1.lastName = "George";

            Author auteur2 = new Author();
            auteur2.firstName = "Tom";
            auteur2.lastName = "Clancy";

            b.addAuthor(auteur2);
            b.addAuthor(auteur1);
            b.displayAuthor();

            Console.ReadKey();

        }
    }
}
