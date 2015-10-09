using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation.com.m2i.formation.media
{
    public abstract class Item : IItem
    {
       public int Id { get; set; }
       public double Prix { get; set; }
        public string Description { get; set; }
    }
}
