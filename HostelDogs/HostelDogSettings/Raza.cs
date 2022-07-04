using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDogSettings
{
    public class Raza
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Agregue la raza")]
        [MinLength(3, ErrorMessage="Agruege al menos 3 caracteres")]
        [MaxLength(25, ErrorMessage="No puede pasar de 25 caracteres")]
        public string Descripcion { get; set; }
        [MaxLength(500, ErrorMessage="La descripción no debe ser mayor de 500 caracteres")]
        public string Detalle { get; set; }
    }
}
