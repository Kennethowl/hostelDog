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
        [Required(ErrorMessage="Este campo es requerido")]
        [MinLength(2, ErrorMessage="No menos de 2 caracteres")]
        [MaxLength(25, ErrorMessage="No más de 25 caracteres")]
        public string Nombre { get; set; }
        public DateTime FechadeIngreso { get; set; }
        [Display(Name ="imagen")]
        public string Imagen { get; set; }
        public int RazaID { get; set; }
        public Raza Raza { get; set; }

        public Perro()
        {
            FechadeIngreso = DateTime.Now;
        }
    }
}
