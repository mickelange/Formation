using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    class Publisher

    {

        public int Id
        {
            get; set;
        }
        public string Nom
        {
            get; set;
        }

        public string Telephone
        {
            get; set;

        }

        public int NumSiret
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
