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
            Console.WriteLine(b.Titre);
            Console.ReadKey();


        }
    }
}
