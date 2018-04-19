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

        MovMateriales newItemMaterial = null;
        List<MovMateriales> lista_AddMateriales = new List<MovMateriales>();
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

        private void chk_RequiereInsumos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RequiereInsumos.Checked)
            {
                lblBuscarMt.Enabled = true; txtBuscarMateriales.Enabled = true;
                dgvItemsSIGA.Enabled = true;
                
            }
            else
            {
                lblBuscarMt.Enabled = false; txtBuscarMateriales.Enabled = false;
                dgvItemsSIGA.Enabled = false;
            }

        }

        private void desbloquearInfoMateriales()
        {
            btnAddMateriales.Visible = true;
            txtCantidadSelected.Enabled = true;
            txtCantidadSelected.Focus();
            
        }

        private void bloquearInfoMateriales()
        {
            btnAddMateriales.Visible = false;
            txtCantidadSelected.Enabled = false;            
        }


        //BUSCAR ITEMS SIGA:
        private void buscarItemsSIGA(string pBusqueda)
        {
            SolicitudDAO soliDAO = new SolicitudDAO();
            dgvItemsSIGA.DataSource = soliDAO.listarItemsSIGA(pBusqueda);

            dgvItemsSIGA.Columns.Clear();
            dgvItemsSIGA.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn CODSIGA = new DataGridViewTextBoxColumn();
            CODSIGA.HeaderText = "COD SIGA";
            CODSIGA.DataPropertyName = "CODSIGA";
            CODSIGA.Width = 150;
            dgvItemsSIGA.Columns.Add(CODSIGA);

            DataGridViewTextBoxColumn NOMBRE_ITEM = new DataGridViewTextBoxColumn();
            NOMBRE_ITEM.HeaderText = "ITEM";
            NOMBRE_ITEM.DataPropertyName = "NOMBRE_ITEM";
            NOMBRE_ITEM.Width = 450;
            dgvItemsSIGA.Columns.Add(NOMBRE_ITEM);

            DataGridViewTextBoxColumn NOMBRE_UNIDAD_MEDIDAD = new DataGridViewTextBoxColumn();
            NOMBRE_UNIDAD_MEDIDAD.HeaderText = "UNIDAD DE MEDIDA";
            NOMBRE_UNIDAD_MEDIDAD.DataPropertyName = "NOMBRE_UNIDAD_MEDIDAD";
            NOMBRE_UNIDAD_MEDIDAD.Width = 150;
            dgvItemsSIGA.Columns.Add(NOMBRE_UNIDAD_MEDIDAD);
        }


        private void txtBuscarMateriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                bloquearInfoMateriales();
                buscarItemsSIGA(txtBuscarMateriales.Text.Trim());
            }
        }

        private void dgvItemsSIGA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemSelected.Text = dgvItemsSIGA.CurrentRow.Cells[0].Value.ToString();
            txtUMSelected.Text = dgvItemsSIGA.CurrentRow.Cells[2].Value.ToString();
            desbloquearInfoMateriales();

        }

        private void btnAddMateriales_Click(object sender, EventArgs e)
        {


            newItemMaterial = new MovMateriales();
            newItemMaterial.numTicketString = NumTicketInicial;
            newItemMaterial.codSIGA = dgvItemsSIGA.CurrentRow.Cells[0].Value.ToString();
            newItemMaterial.Item_Nombre = dgvItemsSIGA.CurrentRow.Cells[1].Value.ToString();
            newItemMaterial.Unidad_Medida = dgvItemsSIGA.CurrentRow.Cells[2].Value.ToString();
            newItemMaterial.cantidad = Convert.ToInt32(txtCantidadSelected.Text);
            newItemMaterial.estado = "REQUERIDO";

            lista_AddMateriales.Add(newItemMaterial);

            dgvMaterialesAsignados.DataSource = lista_AddMateriales;
            dgvMaterialesAsignados.Columns.Clear();
            dgvMaterialesAsignados.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn numTicketString = new DataGridViewTextBoxColumn();
            numTicketString.HeaderText = "N° Atención";
            numTicketString.DataPropertyName = "numTicketString";
            numTicketString.Width = 150;
            dgvMaterialesAsignados.Columns.Add(numTicketString);


            DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
            codSIGA.HeaderText = "Cod SIGA";
            codSIGA.DataPropertyName = "codSIGA";
            codSIGA.Width = 150;
            dgvMaterialesAsignados.Columns.Add(codSIGA);

            DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
            Item_Nombre.HeaderText = "Item Nombre";
            Item_Nombre.DataPropertyName = "Item_Nombre";
            Item_Nombre.Width = 450;
            dgvMaterialesAsignados.Columns.Add(Item_Nombre);

            DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
            Unidad_Medida.HeaderText = "Unidad de Medida";
            Unidad_Medida.DataPropertyName = "Unidad_Medida";
            Unidad_Medida.Width = 120;
            dgvMaterialesAsignados.Columns.Add(Unidad_Medida);


            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
            cantidad.HeaderText = "cantidad";
            cantidad.DataPropertyName = "cantidad";
            cantidad.Width = 100;
            dgvMaterialesAsignados.Columns.Add(cantidad);
            
        }

        private void btnCerrarEvaluarSolicitud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
