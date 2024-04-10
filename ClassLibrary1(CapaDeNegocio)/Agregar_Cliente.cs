using System;
using CapaEntidades; 
using CapaDatos;    

namespace CapaNegocio
{
    public class AgregarEmpleado
    {
        
        public static void Agregar(string nombre, string apellidos, double sueldoBruto, string categoria)
        {
            
            Empleado empleado = new Empleado(nombre, apellidos, sueldoBruto, categoria);

            
            GestorEmpleados.CalcularSueldoNeto(empleado);

            
            if (DatosEmpleado.Insertar(empleado))
            {
                Console.WriteLine("Empleado agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error al agregar empleado. Por favor, inténtelo de nuevo.");
            }
        }
    }
}
