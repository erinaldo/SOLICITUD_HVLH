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
    class DireccionOficinaDAO
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["AccessPersonal"].ConnectionString;
        private static SqlConnection oConexion = new SqlConnection(Cadena);
    }
}
