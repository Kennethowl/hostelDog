using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDogSettings
{
    public class Perro
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechadeIngreso { get; set; }

        [Display(Name ="imagen")]
        public string Imagen { get; set; }

        public Perro()
        {
            FechadeIngreso = DateTime.Now;
        }
    }
}
