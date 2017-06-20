using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class ExempleReponse
    {
        [Key]
        public int id { get; set; }
        public string Contenu { get; set; }
        public ExempleReponse(string c)
        {
            this.Contenu = c;

        }
        public ExempleReponse()
        {

        }
    }
}