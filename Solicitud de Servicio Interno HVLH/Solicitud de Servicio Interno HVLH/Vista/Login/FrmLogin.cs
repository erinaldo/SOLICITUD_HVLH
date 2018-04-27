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
using Solicitud_de_Servicio_Interno_HVLH.Vista.Admin;
using Solicitud_de_Servicio_Interno_HVLH.Vista.User;

namespace Solicitud_de_Servicio_Interno_HVLH.Vista.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
             if (e.KeyChar == (int)Keys.Enter)
                 {
                if (txtUserLogin.Text.Trim() == ""){
                    MessageBox.Show("Ingrese el Usuario","Mensaje al Usuario",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    txtUserLogin.Focus();
                 }
                   
                else if (txtPasswordLogin.Text.Trim() == ""){
                    MessageBox.Show("Ingrese la Contraseña", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPasswordLogin.Focus();
                }
                else
                {
                    //Verificar Login//
                    SolicitudDAO soliDao = new SolicitudDAO();
                    var userAccess = soliDao.ValidarAccesoUser(txtUserLogin.Text, txtPasswordLogin.Text);
                    if (userAccess != null)
                    {
                        VarGlobal.userAccesLogueado = userAccess;
                        if (userAccess.TipoAcceso.Equals("A"))
                        {
                            /*FrmRegistroDocs open = new FrmRegistroDocs();
                             open.Show();
                             this.Hide();*/
                          /*  MenuAdmin openMenuAdmin = new MenuAdmin();
                            openMenuAdmin.Show();
                            this.Hide();*/
                        }
                        else if (userAccess.TipoAcceso.Equals("U"))
                        {
                            /*FrmMisTareas openMisTareas = new FrmMisTareas();
                            openMisTareas.Show();
                            this.Hide();*/
                            MenuUser openMenuUser = new MenuUser();
                            openMenuUser.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrecta", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                    }

                 }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message,"Mensaje al Usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                                                              
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
