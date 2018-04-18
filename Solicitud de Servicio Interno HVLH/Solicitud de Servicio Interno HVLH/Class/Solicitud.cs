using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solicitud_de_Servicio_Interno_HVLH.Class
{
    public class Solicitud
    {
        public int idSolicitud { get; set; }
        public AccesoClass idAcceso { get; set; }
        public string Oficina_Solicitante { get; set; }
        public string Area_Solicitante { get; set; }
        public string IP_Solicitante { get; set; }
        public string MAC_Solicitante { get; set; }
        public string NomPC_Solicitante { get; set; }
        public int NumTicket { get; set; }
        public string NumTicketString { get; set; }
        public DateTime FechaHoraRegistroReal { get; set; }
        public string Oficina_Destino { get; set; }
        public string Area_Destino { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
    }
}
