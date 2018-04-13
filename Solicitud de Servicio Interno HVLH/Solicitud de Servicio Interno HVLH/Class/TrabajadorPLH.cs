using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solicitud_de_Servicio_Interno_HVLH.Class
{
    public class TrabajadorPLH
    {

        public int Codigo_Trabajador { get; set; }

        //nombre completo:
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; }
        public string Nivel { get; set; }
        public string Direccion_Oficina { get; set; }
        public string Condicion_Trabajador { get; set; }
        public string Tipo { get; set; }
        public string Estado_Trabajador { get; set; }

        public DateTime fechaNAC { get; set; }
        public DateTime fechaALTA { get; set; }
    }
}
