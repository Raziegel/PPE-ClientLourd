using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Reponse
    {
        [Key]
        public int id { get; set; }
        public ExempleReponse Contenu { get; set; }
        public DateTime HeureReponse { get; set; }

        public Sonde Sonde { get; set; }

        public Reponse(ExempleReponse c, Sonde s)
        {
            this.Contenu = c;
            this.Sonde = s;
        }
        public Reponse()
        {

        }
    }
}
