using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGitHubLeo1980
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Func<int, int, int> PrecioConGastos = (costo, gastos) => costo + gastos;

        private int EstablecerPrecioFinal(int pCostos, int pGastos, Func<int, int, int> f)
        {
            f = PrecioConGastos;
            MessageBox.Show("Cambio y actualizacones en GitHub");
            return f(pCostos, pGastos);
        }
    }
}
