using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDogSettings
{
    public class PerroBL
    {
        Contexto contexto;
        public List<Perro> ListaDePerros { get; set; }

        public PerroBL()
        {
            contexto = new Contexto();
            ListaDePerros = new List<Perro>();
        }

        public List<Perro> ObtenerPerro()
        {
            ListaDePerros = contexto.Perros.ToList();

            return ListaDePerros;
        }

        public void GuardarPerros(Perro perro)
        {
            if (perro.ID == 0)
            {
                contexto.Perros.Add(perro);
            }
            else
            {
                var perrosExistentes = contexto.Perros.Find(perro.ID);
                perrosExistentes.Nombre = perro.Nombre;
                perrosExistentes.FechadeIngreso = perro.FechadeIngreso;
            }

            contexto.SaveChanges();
        }

        public Perro ObtenerPerros(int id)
        {
            var perro = contexto.Perros.Find(id);

            return perro;
        }

        public void EliminarPerros(int id)
        {
            var perro = contexto.Perros.Find(id);

            contexto.Perros.Remove(perro);

            contexto.SaveChanges();
        }
    }
}
