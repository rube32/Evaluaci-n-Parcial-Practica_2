using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Empleado
    {
        // Propiedades de la clase Empleado
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public double SueldoBruto { get; set; }
        public string Categoria { get; set; }
        public double MontoAumento { get; set; }
        public double SueldoNeto { get; set; }

        
        public Empleado(string nombre, string apellidos, double sueldoBruto, string categoria)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            SueldoBruto = sueldoBruto;
            Categoria = categoria;
        }
    }
}
