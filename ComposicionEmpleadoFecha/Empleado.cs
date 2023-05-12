using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ComposicionEmpleadoFecha
{
    internal class Empleado
    {
        private string apellido;
        private _fecha fechaContratacion;
        private _fecha fechaNacimiento;
        private string primerNombre;

        public Empleado(string nombre, string Apellido,_fecha fechaNac, _fecha fechaCon)
        {
            primerNombre = nombre;
            apellido = Apellido;
            fechaNacimiento = fechaNac;
            fechaContratacion = fechaCon;
        }

        public override string ToString()
        {
            return "Nombre: " + primerNombre + "\n" + "Apellido: " + apellido + "\n" + "Fecha de Cumpleaños: " + fechaNacimiento + "\n" + "Fecha de Contratación: " + fechaContratacion + "\n";

        }

    }
}