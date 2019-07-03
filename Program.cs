using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adopcionsingleton
{
    class Adopcion
    {
        public Persona PersonaAdoptada { set; get; }
        public Perro PerroAdoptado { get; set; }
        public DateTime FechaAdopcion { get { return DateTime.Now; } }
    }
}