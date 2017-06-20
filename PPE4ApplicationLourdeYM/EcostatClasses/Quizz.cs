using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcostatClasses
{
    public class Quizz : Questionnaire
    {
        public ICollection<Recompense> Recompenses { get; set; }
        public Quizz(string t, ICollection<Question> q, ICollection<Recompense> r)
        {
            this.Titre = t;
            this.Questions = q;
            this.Recompenses = r;
        }
        public Quizz()
        {

        }
    }
}
