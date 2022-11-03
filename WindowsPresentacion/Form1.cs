using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPruebaStatic;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(0, "Juan", "Perez");

            MessageBox.Show("Comisión: " + Empleado.Comision);

            Empleado empleado2 = new Empleado(1, "Lucas", "Gonzalez");
            Empleado.Comision = 2030;

            MessageBox.Show("Comisión: " + Empleado.Comision);

            Empleado empleado3 = new Empleado(2, "Andy", "Gallardo");
            Empleado.Comision = 530;

            MessageBox.Show("Comisión: " + Empleado.Comision);

            Empleado empleado4 = new Empleado(1, "Franco", "Gimenez");
            Empleado.Comision = 5728;

            MessageBox.Show("Comisión: " + Empleado.Comision);

        }
    }
}
