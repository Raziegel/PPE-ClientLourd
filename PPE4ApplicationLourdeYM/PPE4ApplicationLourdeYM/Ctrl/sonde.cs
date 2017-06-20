using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;
namespace PPE4ApplicationLourdeYM.Ctrl
{
    class sonde
    {
        public void ajouterSonde(string p, string mdp)
        {
            Sonde a = new Sonde( p, mdp);
            using (var db = new Context())
            {
                db.Sondes.Add(a);
                db.SaveChanges();
            }
        }
    }
}
