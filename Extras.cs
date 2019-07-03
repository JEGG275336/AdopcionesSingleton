using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adopcionsingleton
{
    class Extras
    {
        static void Main(string[] args)
        {
            Datos dato1 = Datos.GetInstancia();
            dato1.ListaPerros.Add(new Perro() { Id = 1, Nombre = "perro #1", Edad = 9 });
            dato1.ListaPerros.Add(new Perro() { Id = 2, Nombre = "perro #2", Edad = 9 });
            dato1.ListaPerros.Add(new Perro() { Id = 3, Nombre = "perro #3", Edad = 9 });
            dato1.ListaPerros.Add(new Perro() { Id = 4, Nombre = "perro #4", Edad = 9 });
            dato1.ListaPerros.Add(new Perro() { Id = 5, Nombre = "perro #5", Edad = 9 });


            cargarDatos();

            foreach (Perro perro in dato1.ListaPerros)
            {
                Console.WriteLine("ID: " + perro.Id + " Nombre: " + perro.Nombre + " Edad: " + perro.Edad);
            }

            Console.ReadLine();
        }

        static void cargarDatos()
        {
            Datos dato = Datos.GetInstancia();
            dato.ListaPerros.Add(new Perro() { Id = 6, Nombre = "segundo perro #1", Edad = 9 });
            dato.ListaPerros.Add(new Perro() { Id = 7, Nombre = "segundo perro #2", Edad = 9 });
            dato.ListaPerros.Add(new Perro() { Id = 8, Nombre = "segundo perro #3", Edad = 9 });
            dato.ListaPerros.Add(new Perro() { Id = 9, Nombre = "segundo perro #4", Edad = 9 });
            dato.ListaPerros.Add(new Perro() { Id = 10, Nombre = "segundo perro #5", Edad = 9 });
        }
    }
}
