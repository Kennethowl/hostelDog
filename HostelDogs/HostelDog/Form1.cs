using HostelDogSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PerroBL perroBl = new PerroBL();
            var listaDePerros = perroBl.ObtenerPerro();

            listaDePerrosBindingSource.DataSource = listaDePerros;
        }
    }
}
