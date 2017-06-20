using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Administrateur : Personne
    {
      

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Administrateur(string n, string pn, string ps, string mdp)
        {
            this.Nom = n;
            this.Prenom = pn;
            this.Pseudo = ps;
            this.MDP = mdp;
        }
        public Administrateur()
        {

        }
    }
}
