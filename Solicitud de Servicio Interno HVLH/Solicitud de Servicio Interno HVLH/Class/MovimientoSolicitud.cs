using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solicitud_de_Servicio_Interno_HVLH.Class
{
    public class MovimientoSolicitud
    {

        public int idMovimiento { get; set; }
        public Solicitud Solicitud { get; set; }
        public string NumTicketString { get; set; }
        public string Estado { get; set; }
        public string MotivoSolicitud { get; set; }
        public string PersonalDesignado { get; set; }
        public string DiagnosticoPersonal { get; set; }
        public DateTime FechaHoraMovimiento { get; set; }
        public bool ReqInsumo { get; set; }

        public string ReqInsumoString { get; set; }
    }
}
