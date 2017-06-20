using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class quizz
    {
        public void ajouterQuizz(string t, List<Question> tab, List<Recompense> rab)
        {
            Quizz q = new Quizz(t, tab, rab);
            using (var db = new Context())
            {
                db.Quizzs.Add(q);
                db.SaveChanges();
            }
        }
        public void SupprimerQuizz(int id)
        {
            using (var db = new Context())
            {
                Quizz e = db.Quizzs.Single(x => x.id == id);
                db.Quizzs.Remove(e);
                db.SaveChanges();
            }
        }
        public List<Quizz> listeQuizz()
        {
            List<Quizz> quizzs = new List<Quizz>();
            using (var db = new Context())
            {
                foreach (Quizz q in db.Quizzs.Include("Recompenses").Include("Questions"))
                {
                    quizzs.Add(q);
                }
            }
            return quizzs;
        }
    }
}
