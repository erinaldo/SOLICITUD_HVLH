using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Solicitud_de_Servicio_Interno_HVLH.Class;
using Solicitud_de_Servicio_Interno_HVLH.Vista.User.Informes;
using Solicitud_de_Servicio_Interno_HVLH.DAO;



namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class VERINFORMES_PRUEBA : Form
    {
        public VERINFORMES_PRUEBA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SolicitudDAO solidao = new SolicitudDAO();
             Frm_Inf_SolicitudAtendida openInforme = new Frm_Inf_SolicitudAtendida();
            openInforme.ListaSolicitudAtendida = solidao.verInformeAtendido("OEI-INF-00001");
            openInforme.ShowDialog();
        }
    }
}
