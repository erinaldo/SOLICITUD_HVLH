using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using Solicitud_de_Servicio_Interno_HVLH.Class;


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User.Informes
{

     
    public partial class Frm_Inf_SolicitudAtendida : Form
    {
        public List<InformeAtendido> ListaSolicitudAtendida = new List<InformeAtendido>();
        public Frm_Inf_SolicitudAtendida()
        {
            InitializeComponent();
        }

        private void Frm_Inf_SolicitudAtendida_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsInformeAtendido", ListaSolicitudAtendida));
            this.reportViewer1.RefreshReport();
        }

        private void btnCerrarGenSolicitud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
