using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcostatClasses
{
    public class Sondage : Questionnaire
    {
        public Sondage(string t, ICollection<Question> q)
        {
            this.Titre = t;
            this.Questions = q;
            
        }
        public Sondage()
        {

        }
    }
}
