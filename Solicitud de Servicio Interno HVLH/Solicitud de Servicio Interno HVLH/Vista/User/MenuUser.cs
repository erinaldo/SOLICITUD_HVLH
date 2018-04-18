using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Solicitud_de_Servicio_Interno_HVLH.Class;


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class MenuUser : Form
    {
        public MenuUser()
        {
            InitializeComponent();
            recuperarInfoLogin();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void recuperarInfoLogin()
        {
            btnUsername.Text = VarGlobal.userAccesLogueado.Nombre;
        }
        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            SubMiCuenta.Visible = true;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            subMenuSolicitud.Visible = true;
        }

        private void btnGenerarSolicitud_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new GenerarSolicitudUser());
        }


        private void AbrirFrmPanel(Object FrmHijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form frmAccs = FrmHijo as Form;
            frmAccs.TopLevel = false;
            frmAccs.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(frmAccs);
            this.Contenedor.Tag = frmAccs;
            frmAccs.Show();

        }

        private void btnVerMisSolicitudes_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel(new VerMisSolicitudesUser());
        }
    }
}
