using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class sondeur
    {
        public void ajouterSondeur( string p, string mdp, string r)
        {
            Sondeur a = new Sondeur( p, mdp, r);
            using (var db = new Context())
            {
                db.Sondeurs.Add(a);
                db.SaveChanges();
            }
        }
        public List<Sondeur> listeSondeurs()
        {
            List<Sondeur> sondeurs = new List<Sondeur>();
            using (var db = new Context())
            {
                foreach (Sondeur e in db.Sondeurs)
                {
                    sondeurs.Add(e);
                }
            }
            return sondeurs;
        }
    }
}
