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
            Console.ReadKey();

        }
    }
}
