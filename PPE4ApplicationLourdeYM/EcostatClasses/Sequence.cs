using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcostatClasses
{
    public class Sequence : Questionnaire
    {
       
        public DateTime DateCreation { get; set; }
        
        public Sequence(string t, ICollection<Question> q, DateTime d)
        {
            this.Titre = t;
            this.Questions = q;
            this.DateCreation = d;
        }
        public Sequence()
        {

        }
    }
}
