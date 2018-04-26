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
            if (SubMiCuenta.Visible == true)
                SubMiCuenta.Visible = false;
            else
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
            if (subMenuSolicitud.Visible == true)
                subMenuSolicitud.Visible = false;
            else
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

        private void btnVerMiInfoUser_Click(object sender, EventArgs e)
        {
            string miInformacion = "";

            miInformacion = "Nombre:  " + VarGlobal.userAccesLogueado.Nombre;
            miInformacion += Environment.NewLine;
            miInformacion += Environment.NewLine;
            miInformacion += "Usuario:   " + VarGlobal.userAccesLogueado.Usuario;
            miInformacion += Environment.NewLine; miInformacion += Environment.NewLine;
            miInformacion += "Oficina:   " + VarGlobal.userAccesLogueado.DireccionOficina;
            miInformacion += Environment.NewLine; miInformacion += Environment.NewLine;
            miInformacion += "Área:        " + VarGlobal.userAccesLogueado.AreaEspec;

            MessageBox.Show(miInformacion,"Mi Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            if (btnOffline.Visible == true)
                btnOffline.Visible = false;
            else
                btnOffline.Visible = true;
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 115;
            }
            else
            {
                menuVertical.Width = 250;
            }

            if (pictureBox1.Width == 246)
            {
                pictureBox1.Width = 125;
            }
            else
            {
                pictureBox1.Width = 246;
            }

        }
    }
}
