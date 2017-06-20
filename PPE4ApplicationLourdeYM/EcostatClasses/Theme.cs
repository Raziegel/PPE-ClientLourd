using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Theme
    {
        [Key]
        public int id { get; set; }
        public string Libelle { get; set; }

        public Theme(string l)
        {
            this.Libelle = l;
        }
        public Theme()
        {

        }
    }
}