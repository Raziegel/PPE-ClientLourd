using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{
    public class Personne

    {
        [Key]
        public int id { get; set; }
        public string Pseudo { get; set; }

        public string MDP { get; set; }
    }
}
