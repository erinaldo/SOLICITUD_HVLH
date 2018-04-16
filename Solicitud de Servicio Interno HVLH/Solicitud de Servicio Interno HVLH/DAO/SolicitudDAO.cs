using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Solicitud_de_Servicio_Interno_HVLH.Class;


namespace Solicitud_de_Servicio_Interno_HVLH.DAO
{
    public class SolicitudDAO
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["AccessSolicitud"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);

        public bool registrarAcceso(AccesoClass accesoCls)
        {

            try
            {
                bool resul = false;
                SqlCommand oComando = new SqlCommand("SP_SOLICITUD_REGISTRAR_ACCESO", oConexion);
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@Nombre", accesoCls.Nombre);
                oComando.Parameters.AddWithValue("@Usuario", accesoCls.Usuario);
                oComando.Parameters.AddWithValue("@Contrasena", accesoCls.Contrasena);
                oComando.Parameters.AddWithValue("@DireccionOficina", accesoCls.DireccionOficina);
                oComando.Parameters.AddWithValue("@Estado", "A");
                oComando.Parameters.AddWithValue("@TipoAcceso", accesoCls.TipoAcceso);

                oConexion.Open();
                resul = oComando.ExecuteNonQuery() > 0;
                oConexion.Close();
                return resul;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
