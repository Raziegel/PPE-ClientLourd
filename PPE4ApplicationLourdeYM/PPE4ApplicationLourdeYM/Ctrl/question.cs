using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class question
    {
        public void ajouterQuestion(string l, List<ExempleReponse> tab)
        {
            Question q = new Question(l, tab);
            using (var db = new Context())
            {
                db.Questions.Add(q);
                db.SaveChanges();
            }
        }
    }
}
