using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.Admin
{
    public partial class FrmMenuPr : Form
    {
        public FrmMenuPr()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width ==200)
            {
                menuVertical.Width = 61;
            }
            else
            {
                menuVertical.Width = 200;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximinizar.Visible = false;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximinizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
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

        private void btnAccesos_Click(object sender, EventArgs e)
        {
            AbrirFrmPanel( new FrmAccesosPr());
            SubMenuAcceso.Visible = true;
        }

        private void btnCrearAcceso_Click(object sender, EventArgs e)
        {
            SubMenuAcceso.Visible = false;
        }

        private void btnVerAccesos_Click(object sender, EventArgs e)
        {
            SubMenuAcceso.Visible = false;
        }
    }
}
