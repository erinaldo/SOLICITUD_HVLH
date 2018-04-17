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


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class GenerarSolicitudUser : Form
    {
        public string RefTicket = "";
        public GenerarSolicitudUser()
        {
            InitializeComponent();
            llenarInfoSolicitante();
            
            generarStringTicket();
            generarNumTicket();

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
        }
        private void generarNumTicket()
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



    }
}
