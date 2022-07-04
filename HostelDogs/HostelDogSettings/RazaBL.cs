using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDogSettings
{
    public class RazaBL
    {
        Contexto contexto;
        public List<Raza> ListadoDeRazas { get; set; }

        public RazaBL()
        {
            contexto = new Contexto();
            ListadoDeRazas = new List<Raza>();
        }

        public List<Raza> ObtenerRaza()
        {
            ListadoDeRazas = contexto.Razas.ToList();

            return ListadoDeRazas;
        }

        public void GuardarRaza(Raza raza)
        {
            if (raza.ID == 0)
            {
                contexto.Razas.Add(raza);
            }
            else
            {
                var razasExistentes = contexto.Razas.Find(raza.ID);
                razasExistentes.Descripcion = raza.Descripcion;
                razasExistentes.Detalle = raza.Detalle;
            }

            contexto.SaveChanges();
        }

        public Raza ObtenerRazas(int id)
        {
            var raza = contexto.Razas.Find(id);

            return raza;
        }

        public void EliminarRazas(int id)
        {
            var raza = contexto.Razas.Find(id);

            contexto.Razas.Remove(raza);

            contexto.SaveChanges();
        }
    }
}
