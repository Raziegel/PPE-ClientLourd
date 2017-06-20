using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcostatClasses
{
    public class Sondeur : Personne
    {
        public string RaisonSociale { get; set; }
        public Sondeur(string p, string m, string r)
        {;
            this.Pseudo = p;
            this.MDP = m;
            this.RaisonSociale = r;
        }
        public Sondeur()
        {

        }
    }
}
