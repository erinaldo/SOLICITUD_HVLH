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
    public partial class VerMaterialesUser : Form
    {

        public string nroTicketMat = "";
        public string estadoReq = "";
        public VerMaterialesUser()
        {
            InitializeComponent();
        }

        private void btnCerrarVerMateriales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerMaterialesUser_Load(object sender, EventArgs e)
        {           
            llenarInsumosAsginados(nroTicketMat);
        }

        private void llenarInsumosAsginados(string numTickeTStr)
        {
            if (estadoReq.Equals("En curso") || estadoReq.Equals("Evaluado"))
            {
                SolicitudDAO solDAO = new SolicitudDAO();

                var lista = solDAO.listarMaterialesAsginado(numTickeTStr);

                dgvMaterialesAsignados.DataSource = lista;

                dgvMaterialesAsignados.Columns.Clear();
                dgvMaterialesAsignados.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn idMovMateriales = new DataGridViewTextBoxColumn();
                idMovMateriales.HeaderText = "idMovMateriales";
                idMovMateriales.DataPropertyName = "idMovMateriales";
                idMovMateriales.Width = 80;
                //idMovMateriales.Visible = false;
                dgvMaterialesAsignados.Columns.Add(idMovMateriales);



                DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
                codSIGA.HeaderText = "codSIGA";
                codSIGA.DataPropertyName = "codSIGA";
                codSIGA.Width = 150;
                dgvMaterialesAsignados.Columns.Add(codSIGA);

                DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
                Item_Nombre.HeaderText = "Item_Nombre";
                Item_Nombre.DataPropertyName = "Item_Nombre";
                Item_Nombre.Width = 500;
                dgvMaterialesAsignados.Columns.Add(Item_Nombre);

                DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
                Unidad_Medida.HeaderText = "Unidad_Medida";
                Unidad_Medida.DataPropertyName = "Unidad_Medida";
                Unidad_Medida.Width = 150;
                dgvMaterialesAsignados.Columns.Add(Unidad_Medida);

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "cantidad";
                cantidad.DataPropertyName = "cantidad";
                cantidad.Width = 80;
                dgvMaterialesAsignados.Columns.Add(cantidad);

                dgvMaterialesAsignados.Columns[0].Visible = false;
            }
            else if (estadoReq.Equals("Atendido"))
            {
                SolicitudDAO solDAO = new SolicitudDAO();

                var lista = solDAO.listarMaterialesUtilizados(numTickeTStr);

                dgvMaterialesAsignados.DataSource = lista;

                dgvMaterialesAsignados.Columns.Clear();
                dgvMaterialesAsignados.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn idMovMateriales = new DataGridViewTextBoxColumn();
                idMovMateriales.HeaderText = "idMovMateriales";
                idMovMateriales.DataPropertyName = "idMovMateriales";
                idMovMateriales.Width = 80;
                //idMovMateriales.Visible = false;
                dgvMaterialesAsignados.Columns.Add(idMovMateriales);



                DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
                codSIGA.HeaderText = "codSIGA";
                codSIGA.DataPropertyName = "codSIGA";
                codSIGA.Width = 150;
                dgvMaterialesAsignados.Columns.Add(codSIGA);

                DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
                Item_Nombre.HeaderText = "Item_Nombre";
                Item_Nombre.DataPropertyName = "Item_Nombre";
                Item_Nombre.Width = 500;
                dgvMaterialesAsignados.Columns.Add(Item_Nombre);

                DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
                Unidad_Medida.HeaderText = "Unidad_Medida";
                Unidad_Medida.DataPropertyName = "Unidad_Medida";
                Unidad_Medida.Width = 150;
                dgvMaterialesAsignados.Columns.Add(Unidad_Medida);

                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "cantidad";
                cantidad.DataPropertyName = "cantidad";
                cantidad.Width = 80;
                dgvMaterialesAsignados.Columns.Add(cantidad);

                dgvMaterialesAsignados.Columns[0].Visible = false;
            }
            else
                MessageBox.Show("Error de Lectura","Mensaje al usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }


    }
}
