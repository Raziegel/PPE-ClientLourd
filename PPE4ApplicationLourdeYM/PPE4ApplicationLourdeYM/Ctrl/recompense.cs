using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;
namespace PPE4ApplicationLourdeYM.Ctrl
{
    class recompense
    {
        public void ajouterRecompense(string l)
        {
            Recompense r = new Recompense(l);
            using (var db = new Context())
            {
                db.Recompenses.Add(r);
                db.SaveChanges();
            }
        }
    }
}
