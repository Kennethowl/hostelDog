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

namespace HostelDogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var perrosBL = new PerroBL();
            var listaDePerros = perrosBL.ObtenerPerro();

            perroBindingSource1.DataSource = listaDePerros;
        }
    }
}
