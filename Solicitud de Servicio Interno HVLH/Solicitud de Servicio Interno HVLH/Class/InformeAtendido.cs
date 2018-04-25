using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solicitud_de_Servicio_Interno_HVLH.Class
{
    public class InformeAtendido
    {
        public string NombreSolicitante { get; set; }
        public string Oficina_Solicitante { get; set; }
        public string Area_Solicitante { get; set; }
        public string NumTicketString { get; set; }
        public DateTime FechaHoraRegistroReal { get; set; }
        public string Oficina_Destino { get; set; }
        public string Area_Destino { get; set; }
        public string EstadoSolicitud { get; set; }
        public string MotivoSolicitud { get; set; }
        public string PersonalDesignado { get; set; }
        public string DiagnosticoPersonal { get; set; }
        public DateTime FechaHoraMovimiento { get; set; }
        public bool ReqInsumo { get; set; }
        public string codSIGA { get; set; }
        public string ItemNombre { get; set; }
        public string Unidad_Medida { get; set; }
        public int cantidad { get; set; }
        public string estado { get; set; }
        
       
    }
}
