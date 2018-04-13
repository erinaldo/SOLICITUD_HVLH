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
    class TrabajadorPLHDAO
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["AccessPersonal"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);


        public List<TrabajadorPLH> ListarTrabajador( string PBusqueda)
        {

            List<TrabajadorPLH> listaTrabajador = new List<TrabajadorPLH>();
            using (SqlCommand oComando = new SqlCommand("SP_BUSQUEDA_TRABJADOR", oConexion))
            {

                oComando.CommandType = CommandType.StoredProcedure;
                oComando.Parameters.AddWithValue("@PBusqueda", PBusqueda);
                TrabajadorPLH trabajador;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        trabajador = new TrabajadorPLH();
                        trabajador.Codigo_Trabajador = Convert.ToInt32(dr[0]);
                        trabajador.NombreCompleto = dr[1].ToString();
                        trabajador.DNI = dr[2].ToString();                        
                        trabajador.Direccion_Oficina = dr[3].ToString();                        
                        listaTrabajador.Add(trabajador);
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception)
                {
                    oConexion.Close();
                }
                return listaTrabajador;
            }
        }

        public List<String> listaDireccionOficiString()
        {
            List<String> listita = new List<String>();
            using (SqlCommand oComando = new SqlCommand("SP_LISTAR_DIRECCIONOFICINA", oConexion))
            {
                oComando.CommandType = CommandType.StoredProcedure;
                //   oComando.Parameters.AddWithValue("@Usuario", usuario);              
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        listita.Add(dr[1].ToString());
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception)
                {
                    oConexion.Close();
                }
                return listita;
            }
        }

        public List<DireccionOficina> ListarDireccionOficina()
        {
            List<DireccionOficina> listaDirOficina = new List<DireccionOficina>();
            using (SqlCommand oComando = new SqlCommand("SP_LISTAR_DIRECCIONOFICINA", oConexion))
            {
                oComando.CommandType = CommandType.StoredProcedure;
                //   oComando.Parameters.AddWithValue("@Usuario", usuario);
                DireccionOficina direccOficina;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = oComando.ExecuteReader(CommandBehavior.SingleResult);
                    while (dr.Read())
                    {
                        direccOficina = new DireccionOficina();
                        direccOficina.CODIGO_DIRECCIONOFICINA = Convert.ToInt32(dr[0]);
                        direccOficina.NOMBRE_DIRECCIONOFICINA = dr[1].ToString();
                        direccOficina.DESCRIPCION_DIRECCIONOFICINA = dr[2].ToString();
                        direccOficina.ESTADO = dr[3].ToString();
                        listaDirOficina.Add(direccOficina);
                    }
                    dr.Close();
                    oConexion.Close();
                }
                catch (Exception)
                {
                    oConexion.Close();
                }
                return listaDirOficina;
            }
        }
    }
}
