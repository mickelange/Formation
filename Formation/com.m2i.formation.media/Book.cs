using Formation.com.m2i.formation.media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public class Book : Media
    {


        public string Isbn
        {
            get; set;
        }
        public int Id
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

       

        public BookCategory Category
        {
            get; set;
        }

        public override double getVAPrice()
        {
            return 1.05 * Prix;
        }

    }
}
