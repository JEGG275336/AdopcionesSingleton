using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adopcionsingleton
{
    class Datos
    {
        private static Datos instancia;
        public List<Perro> ListaPerros = new List<Perro>();

        private Datos()
        {
        }

        public static Datos GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Datos();
            }

            return instancia;
        }
    }
}