using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPruebaStatic
{
    public class Empleado
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static int comision;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }


        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;

        }
    }
}
