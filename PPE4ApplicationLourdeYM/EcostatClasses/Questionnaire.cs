using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Questionnaire
    {
        [Key]
        public int id { get; set; }
        public string Titre { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}