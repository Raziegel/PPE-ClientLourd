using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class sondequestionnaire
    {
        public void ajouterSondeQuestionnaire(Sonde s, Questionnaire q)
        {
            SondeQuestionnaire sq = new SondeQuestionnaire(s, q);
            using (var db = new Context())
            {
                db.SondeQuestionnaires.Add(sq);
                db.SaveChanges();
            }
        }
    }
}
