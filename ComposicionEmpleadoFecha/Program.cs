using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionEmpleadoFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Uriel", "Vergara", new _fecha(06, 05, 2004), new _fecha(12, 08, 2023));
            Console.WriteLine(empleado.ToString());
            Console.ReadLine();
        }
    }
}
