using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibrary1_CAPADATOS_
{
    class conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static conexion con = null;

        public conexion ()
        {
            this.Base = "EmpresaDB";
            this.Servidor = "DESKTOP-VIITSAH\RUBE";
            this.Usuario = "sa";
            this.Clave = "12345678";
            this.Seguridad = true;

            
        }
        public SqlConnection creaConexion();
        {
        SqlConnection cadena = new SqlConnection();
        try
        {
        cadena.ConnectionString = "server" + this.servidor + "; Database" +this.base+ ";";
         }
        catch(Exception ex)
}
}
