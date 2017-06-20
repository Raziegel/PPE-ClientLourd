using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class administateur
    {
        public void ajouterAdministateur(string n, string pr, string p, string mdp)
        {
            Administrateur a = new Administrateur(n, pr, p, mdp);
            using (var db = new Context())
            {
                db.Administrateurs.Add(a);
                db.SaveChanges();
            }
        }
        public bool connexion(string p, string mdp)
        {

            using (var db = new Context())
            {
                if (db.Administrateurs.Any(ut => ut.Pseudo == p && ut.MDP == mdp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
