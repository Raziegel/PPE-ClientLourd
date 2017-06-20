using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class sequence
    {
        public void ajouterSequence(string t, List<Question> tab, DateTime d)
        {
            Sequence s = new Sequence(t, tab,d);
            using (var db = new Context())
            {
                db.Sequences.Add(s);
                db.SaveChanges();
            }
        }
        public List<Sequence> listeSequences()
        {
            List<Sequence> sequences = new List<Sequence>();
            using (var db = new Context())
            {
                foreach (Sequence q in db.Sequences.Include("Questions"))
                {
                    sequences.Add(q);
                }
            }
            return sequences;
        }

    }
}
