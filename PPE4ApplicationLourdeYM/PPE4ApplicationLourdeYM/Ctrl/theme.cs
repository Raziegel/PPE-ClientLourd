using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcostatClasses;

namespace PPE4ApplicationLourdeYM.Ctrl
{
    class theme
    {
        public void ajouterTheme(string l)
        {
            Theme t = new Theme(l);
            using (var db = new Context())
            {
                db.Themes.Add(t);
                db.SaveChanges();
            }
        }
    }
}
