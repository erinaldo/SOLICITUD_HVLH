using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Solicitud_de_Servicio_Interno_HVLH.Class;
using Solicitud_de_Servicio_Interno_HVLH.DAO;


//Config:
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Management;
using System.Net;
using System.Net.Sockets;


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class GenerarSolicitudUser : Form
    {
        public string RefTicket = "";
        public int numTicketBD = 0;
        public string numTicketStringBD = "";

        public GenerarSolicitudUser()
        {
            InitializeComponent();
            llenarInfoSolicitante();            
            generarStringTicket();
            //  generarNumTicket();
            generarTicketFinal();
            LlenarDirOficina();            
        }
        private void llenarInfoSolicitante(){
            txtUsuarioSolicitante.Text = VarGlobal.userAccesLogueado.Nombre;
            txtOficinaSolicitante.Text = VarGlobal.userAccesLogueado.DireccionOficina;
            txtAreaSolicitante.Text = VarGlobal.userAccesLogueado.AreaEspec;

        }
        private void generarStringTicket()
        {
            if (VarGlobal.userAccesLogueado.DireccionOficina.Equals("OFICINA DE ESTADISTICA E INFORMATICA"))
                RefTicket = "OEI-INF";
            else if (VarGlobal.userAccesLogueado.DireccionOficina.Equals("OFICINA DE SERVICIOS GENERALES Y MANTENIMIENTO"))
                RefTicket = "OSGYM";
            else if (VarGlobal.userAccesLogueado.DireccionOficina.Equals("OFICINA DE LOGISTICA"))
                RefTicket = "OL";
        }
        /* private void generarNumTicket()
        {
            
            int Cod_Pa;
            int codPrueba;
            //numeroFactura = 1999999;
            Cod_Pa = 1000001;
            codPrueba = 1521;
            string idFactura = Cod_Pa.ToString("T000-000000");
            string concatCadena = String.Concat(RefTicket, "-000000");
            string idTicket = Cod_Pa.ToString(RefTicket+"-000000");

            string idTicketPrueba = codPrueba.ToString(RefTicket+"-00000");
            MessageBox.Show(concatCadena);
            txtNumTicket.Text = idTicketPrueba;
        }*/

        private int generarNumTicket(string oficinaSolicitante, string areaSolicitante)
        {
            SolicitudDAO soliDao = new SolicitudDAO();

           numTicketBD = soliDao.generarNumTicket(oficinaSolicitante, areaSolicitante);

           return numTicketBD;
        }
        private void generarTicketFinal()
        {
            int numTicket = generarNumTicket(txtOficinaSolicitante.Text, txtAreaSolicitante.Text);
           numTicketStringBD = numTicket.ToString(RefTicket + "-00000");
           txtNumTicket.Text = numTicketStringBD;
        }
        private void btnCerrarGenSolicitud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LlenarDirOficina()
        {
            TrabajadorPLHDAO TrabajadorDao = new TrabajadorPLHDAO();

            var listadoDireccionOfi = TrabajadorDao.ListarDireccionOficina();
            this.cboOficinaDestino.DataSource = listadoDireccionOfi;
            this.cboOficinaDestino.ValueMember = "CODIGO_DIRECCIONOFICINA";
            this.cboOficinaDestino.DisplayMember = "NOMBRE_DIRECCIONOFICINA";
            this.cboOficinaDestino.Text = "OFICINA DE ESTADISTICA E INFORMATICA";

            /*this.cboOficinaAccess.AutoCompleteCustomSource.AddRange(new TrabajadorPLHDAO().listaDireccionOficiString().ToArray());
            this.cboOficinaAccess.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cboOficinaAccess.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cboOficinaAccess.SelectedIndex = -1;*/

            llenarAreaEspecXOficina(Convert.ToInt32(cboOficinaDestino.SelectedValue));

        }
        private void llenarAreaEspecXOficina(int codOficina)
        {
            TrabajadorPLHDAO areaEspecDao = new TrabajadorPLHDAO();
            cboAreaDestino.DataSource = areaEspecDao.ListarAreaEspecifica(codOficina);
            this.cboAreaDestino.DisplayMember = "NOMBRE_AREA";
            this.cboAreaDestino.ValueMember = "CODIGO_AREAESPECIFICA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string localIP;
            string localMAC="";
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("190.12.72.226", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }*/

            MessageBox.Show(obtenerIP());
            MessageBox.Show(obtenerMAC());
        }

        public static string obtenerIP()
        {
            string localIP;           
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("190.12.72.226", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }
        public static string obtenerMAC()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            string mac = (from o in objects orderby o["IPConnectionMetric"] select o["MACAddress"].ToString()).FirstOrDefault();
            //string descrip = (from o in objects orderby o["IPConnectionMetric"] select o["Description"].ToString()).FirstOrDefault();
            return mac;
        }

        private void btnGenerarSolicitud_Click(object sender, EventArgs e)
        {
            //FALTA VALIDAR:
            Solicitud solicitudGen = new Solicitud();
            solicitudGen.idAcceso = VarGlobal.userAccesLogueado;
            solicitudGen.Oficina_Solicitante = txtOficinaSolicitante.Text.Trim();
            solicitudGen.Area_Solicitante = txtAreaSolicitante.Text.Trim();
            solicitudGen.IP_Solicitante = obtenerIP();
            solicitudGen.MAC_Solicitante = obtenerMAC();
            solicitudGen.NomPC_Solicitante = Environment.MachineName;
            solicitudGen.NumTicket = numTicketBD;
            solicitudGen.NumTicketString = numTicketStringBD;
            solicitudGen.Oficina_Destino = cboOficinaDestino.Text;
            solicitudGen.Area_Destino = cboAreaDestino.Text;
            solicitudGen.Prioridad = "B";
            solicitudGen.Estado = "Solicitado";

            SolicitudDAO soliDao = new SolicitudDAO();

            if (soliDao.generarSolicitud(solicitudGen)){

                MovimientoSolicitud moviSolicitudGen = new MovimientoSolicitud();

                moviSolicitudGen.Solicitud = solicitudGen;
                moviSolicitudGen.Estado = solicitudGen.Estado;
                moviSolicitudGen.MotivoSolicitud = txtMotivoSolicitud.Text.Trim();
                moviSolicitudGen.PersonalDesignado = String.Empty;
                moviSolicitudGen.DiagnosticoPersonal = String.Empty;


                if (soliDao.generarMovimientoSolicitud(moviSolicitudGen))
                {
                    MessageBox.Show("La Solicitud " + numTicketStringBD + " ha sido generada", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al generar el movimiento de la Solicitud", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
            }
                
            else
            {
                MessageBox.Show("Ocurrió un error al generar la Solicitud", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Close();
        }

        private void cboOficinaDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            llenarAreaEspecXOficina(Convert.ToInt32(cboOficinaDestino.SelectedValue));
        }


    }
}
