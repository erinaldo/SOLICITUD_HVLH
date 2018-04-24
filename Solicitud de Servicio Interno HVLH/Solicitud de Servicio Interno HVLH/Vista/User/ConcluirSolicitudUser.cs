using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class ConcluirSolicitudUser : Form
    {

        public string nroTicket = "";
        public string oficinaAreaSolicitante = "";
        public ConcluirSolicitudUser()
        {
            InitializeComponent();
          
        }

        private void ConcluirSolicitudUser_Load(object sender, EventArgs e)
        {
            txtNumTicket_.Text = nroTicket;
            txtOficinaAreaSolicita.Text = oficinaAreaSolicitante;
        }
    }
}
