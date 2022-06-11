using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDogSettings
{
    public class Contexto:DbContext
    {
        public Contexto():base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\hosteldogs.mdf")
        {
            
        }

        public DbSet<Perro> Perros { get; set; }
    }
}
