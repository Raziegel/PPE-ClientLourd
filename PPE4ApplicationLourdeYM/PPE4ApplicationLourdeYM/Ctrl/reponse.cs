using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class reponse
    {
        public void ajouterReponse(ExempleReponse e, Sonde s)
        {
            Reponse r = new Reponse(e, s);
            using (var db = new Context())
            {
                db.Reponses.Add(r);
                db.SaveChanges();
            }
        }
    }
}
