using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComposicionEmpleadoFecha
{
    internal class _fecha
    {
        private int anio;
        private int dia;
        private int mes;

        public int Anio
        {
            get { return anio; }
            set
            {
                if (value > 1920 && value <= DateTime.Now.Year)
                {
                    anio= value;
                }
            }
        }

        public int Dia
        {
            get { return dia; }
            set
            {
                if (value > 0 && value < 32)
                {
                    dia= value;
                }
            }
        }

        public int Mes
        {
            get { return mes; }
            set 
            {if(value>0 && value < 13)
                {
                    mes= value;
                } 
            }
        }

        public _fecha(int eldia, int elmes, int elanio)
        {
           dia= eldia;
           mes= elmes;
            anio= elanio;
        }

        public override string ToString()
        {
            return  Dia + "/" + Mes + "/" + Anio;
        }
    }
}