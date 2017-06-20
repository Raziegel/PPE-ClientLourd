using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class SondeQuestionnaire
    {
        [Key]
        public int id { get; set; }
        public Sonde Sonde { get; set; }
        public Questionnaire Questionnaire { get; set; }

        public bool Valide { get; set; }
        public string Localisation { get; set; }

        public SondeQuestionnaire(Sonde s, Questionnaire q)
        {
            this.Sonde = s;
            this.Questionnaire = q;
        }
    }
}
