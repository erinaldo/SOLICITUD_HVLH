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
    public partial class EvaluarSolicitudUser : Form
    {

        public string NumTicketInicial;
        public string MotivoSolicitudInicial;
        public EvaluarSolicitudUser()
        {
            InitializeComponent();
          
        }



        private void llenarInfoIncial()
        {
            txtNumTicket_.Text = NumTicketInicial;
            txtMotivoSolicitud_ .Text= MotivoSolicitudInicial;



        }

        private void EvaluarSolicitudUser_Load(object sender, EventArgs e)
        {
            llenarInfoIncial();
        }

        private void txtBuscarPersonal__TextChanged(object sender, EventArgs e)
        {
            BuscarTrabajadorPorOficinaPBusqueda(txtBuscarPersonal_.Text.Trim(), VarGlobal.userAccesLogueado.DireccionOficina); 
        }

        private void BuscarTrabajadorPorOficinaPBusqueda(string pBusqueda_, string pOficina)
        {
            TrabajadorPLHDAO trabDAo = new TrabajadorPLHDAO();
            dgvTrabajadorDesig.DataSource = trabDAo.ListarTrabajadorXOficina(pBusqueda_,pOficina);

            dgvTrabajadorDesig.Columns.Clear();
            dgvTrabajadorDesig.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
            Name.HeaderText = "Nombres Completos";
            Name.DataPropertyName = "NombreCompleto";
            Name.Width = 300;
            dgvTrabajadorDesig.Columns.Add(Name);

            DataGridViewTextBoxColumn DNI = new DataGridViewTextBoxColumn();
            DNI.HeaderText = "Nº DNI";
            DNI.DataPropertyName = "DNI";
            DNI.Width = 110;
            dgvTrabajadorDesig.Columns.Add(DNI);

            DataGridViewTextBoxColumn DireccionOficina = new DataGridViewTextBoxColumn();
            DireccionOficina.HeaderText = "Oficina";
            DireccionOficina.DataPropertyName = "Direccion_Oficina";
            DireccionOficina.Width = 300;
            dgvTrabajadorDesig.Columns.Add(DireccionOficina);           
        }

        private void dgvTrabajadorDesig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddLista.Visible = true;
        }

        private void btnAddLista_Click(object sender, EventArgs e)
        {

            if (txtListaPersonal.Text.Trim().Contains(dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString()))
                return;

            txtListaPersonal.Text += "· "+ dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString();
            txtListaPersonal.Text += Environment.NewLine;

        }
    }
}
