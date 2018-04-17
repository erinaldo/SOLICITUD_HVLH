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

        #region Acceso
        //Método para registrar un nuevo acceso al sistema:
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
                oComando.Parameters.AddWithValue("@AreaEspec", accesoCls.AreaEspec);

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
        //Método para verificar el Login al Sistema:
        public AccesoClass ValidarAccesoUser(string usuario, string clave)
        {

            AccesoClass access = null;
            using (SqlCommand oComando = new SqlCommand("SP_ACCESO_VALIDAR", oConexion))
            {
                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@Usuario", usuario);
                oComando.Parameters.AddWithValue("@Contrasena", clave);
               
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        access = new AccesoClass();
                        access.idAcceso = Convert.ToInt32(dr[0]);
                        access.Nombre = dr[1].ToString();
                        access.Usuario = dr[2].ToString();
                        access.DireccionOficina = dr[4].ToString();
                        access.TipoAcceso = dr[6].ToString();
                        access.AreaEspec = dr[7].ToString();      
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception ex)
                {
                    oConexion.Close();
                    throw ex;
                }
                return access;
            }
        }
        



        #endregion







    }
}
