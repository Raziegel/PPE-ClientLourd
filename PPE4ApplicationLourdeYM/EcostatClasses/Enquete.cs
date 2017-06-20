using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EcostatClasses
{

    public class Enquete
    {
        [Key]
        public int id { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateCloture { get; set; }
        public Sondeur Enqueteur { get; set; }

        public ICollection<Theme> Themes { get; set; }

        public ICollection<Sequence> Sequences { get; set; }

        public Enquete(string l, DateTime dcr, DateTime dcl, Sondeur E)
        {
            this.Libelle = l;
            this.DateCreation = dcr;
            this.DateCloture = dcl;
            this.Enqueteur = E;
        }
        public Enquete()
        {

        }
    }
}
