using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class enquete
    {
        public void ajouterEnquete(string l, DateTime d1, DateTime d2, Sondeur s)
        {
            Enquete e = new Enquete(l, d1, d2, s);
            using (var db = new Context())
            {
                db.Enquetes.Add(e);
                db.SaveChanges();
            }
        }
        public void SupprimerEnquete(int id)
        {
            using (var db = new Context())
            {
                Enquete e = db.Enquetes.Single(x => x.id == id);
                db.Enquetes.Remove(e);
                db.SaveChanges();
            }
        }
        public List<Enquete> listeEnquetes()
        {
            List<Enquete> enquetes = new List<Enquete>();
            using (var db = new Context())
            {
                foreach (Enquete e in db.Enquetes.Include("Enqueteur").Include("Sequences")) 
                {
                    enquetes.Add(e);
                }
            }
            return enquetes;
        }


    }
}
