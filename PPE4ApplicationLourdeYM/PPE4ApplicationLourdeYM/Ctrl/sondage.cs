using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class sondage
    {
        public void ajouterSondage(string t, List<Question> tab)
        {
            Sondage s = new Sondage(t, tab);
            using (var db = new Context())
            {
                db.Sondages.Add(s);
                db.SaveChanges();
            }
        }
        public void SupprimerSondage(int id)
        {
            using (var db = new Context())
            {
                Sondage e = db.Sondages.Single(x => x.id == id);
                db.Sondages.Remove(e);
                db.SaveChanges();
            }
        }
        public List<Sondage> listeSondages()
        {
            List<Sondage> sondages = new List<Sondage>();
            using (var db = new Context())
            {
                foreach (Sondage s in db.Sondages.Include("Questions"))
                {
                    sondages.Add(s);
                }
            }
            return sondages;
        }
    }
}
