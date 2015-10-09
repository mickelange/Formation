using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation.com.m2i.formation.media
{
    class CD : Media
    {
        int nbTracks;

        public override double getVAPrice()
        {
            return Prix + 1.2;
        }
    }
}
