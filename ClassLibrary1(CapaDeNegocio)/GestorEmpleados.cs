using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class GestorEmpleados
    {
        
        public static void CalcularSueldoNeto(Empleado empleado)
        {
            double porcentajeAumento;

            // Calcular porcentaje de aumento según sueldo bruto
            if (empleado.SueldoBruto <= 1000)
                porcentajeAumento = 0.1; // 10%
            else if (empleado.SueldoBruto <= 2000)
                porcentajeAumento = 0.2; // 20%
            else if (empleado.SueldoBruto <= 4000)
                porcentajeAumento = 0.3; // 30%
            else
                porcentajeAumento = 0.4; // 40%

          
            empleado.MontoAumento = porcentajeAumento * empleado.SueldoBruto;
            empleado.SueldoNeto = empleado.SueldoBruto + empleado.MontoAumento;
        }
    }
}
