using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class exemplereponse
    {
        public void ajouterExempleReponse(string c)
        {
            ExempleReponse e = new ExempleReponse(c);
            using (var db = new Context())
            {
                db.ExempleReponses.Add(e);
                db.SaveChanges();
            }
        }
    }
}
