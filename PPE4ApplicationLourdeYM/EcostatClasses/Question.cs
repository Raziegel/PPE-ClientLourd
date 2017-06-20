using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Question
    {
        [Key]
        public int id { get; set; }
        public string Intitule { get; set; }
        public string media { get; set; }
        public ICollection<ExempleReponse> ExempleReponses { get; set; }
        public Question(string i, ICollection<ExempleReponse> tab)
        {
            this.Intitule = i;
            this.ExempleReponses = tab;
        }
        public Question()
        {

        }
    }
}