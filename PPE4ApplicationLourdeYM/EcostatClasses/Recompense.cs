using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Recompense
    {
        [Key]
        public int id { get; set; }
        public string Libelle { get; set; }
        public Recompense(string l)
        {
            this.Libelle = l;
        }
        public Recompense()
        {

        }
    }
}