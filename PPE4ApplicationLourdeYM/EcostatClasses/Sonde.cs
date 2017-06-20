using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcostatClasses
{
    public class Sonde : Personne
    {
        public Sonde(string p, string m)
        {
            this.Pseudo = p;
            this.MDP = m;
        }
        public Sonde()
        {

        }
    }
}
