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
        public string prioridadSolicitudInicial; 

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
            cboPrioridadSoliEvaluar.Text = prioridadSolicitudInicial;

        }

        private void EvaluarSolicitudUser_Load(object sender, EventArgs e)
        {
            llenarInfoIncial();
            this.ActiveControl = txtDiagnosticoPerso_;
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


        private void chk_RequiereInsumos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RequiereInsumos.Checked)
            {
                lblBuscarMt.Enabled = true; txtBuscarMateriales.Enabled = true;
                dgvItemsSIGA.Enabled = true; txtCantidadSelected.Enabled = true;
                this.ActiveControl = txtBuscarMateriales;
               
                
            }
            else
            {
                lblBuscarMt.Enabled = false; txtBuscarMateriales.Enabled = false;
                dgvItemsSIGA.Enabled = false; txtCantidadSelected.Enabled = false;
                lblMaterialesUtilziar.Visible = false; btnAddMaterial.Visible = false;
                txtItemSelected.Text = ""; txtCantidadSelected.Text = ""; txtUMSelected.Text = "";
                dgvMaterialesAsignados.Columns.Clear();
                lista_AddMateriales = new List<MovMateriales>();
            }

        }

        private void desbloquearInfoMateriales()
        {            
            btnAddMaterial.Visible = true;
            txtCantidadSelected.Enabled = true;
            txtCantidadSelected.Text = "";
            txtCantidadSelected.Focus();
            
        }

        private void bloquearInfoMateriales()
        {
            btnAddMaterial.Visible = false;
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
            CODSIGA.HeaderText = "COD. SIGA";
            CODSIGA.DataPropertyName = "CODSIGA";
            CODSIGA.Width = 90;
            dgvItemsSIGA.Columns.Add(CODSIGA);

            DataGridViewTextBoxColumn NOMBRE_ITEM = new DataGridViewTextBoxColumn();
            NOMBRE_ITEM.HeaderText = "ITEM";
            NOMBRE_ITEM.DataPropertyName = "NOMBRE_ITEM";
            NOMBRE_ITEM.Width = 550;
            dgvItemsSIGA.Columns.Add(NOMBRE_ITEM);

            DataGridViewTextBoxColumn NOMBRE_UNIDAD_MEDIDAD = new DataGridViewTextBoxColumn();
            NOMBRE_UNIDAD_MEDIDAD.HeaderText = "U. MEDIDA";
            NOMBRE_UNIDAD_MEDIDAD.DataPropertyName = "NOMBRE_UNIDAD_MEDIDAD";
            NOMBRE_UNIDAD_MEDIDAD.Width = 85;
            dgvItemsSIGA.Columns.Add(NOMBRE_UNIDAD_MEDIDAD);
        }
        private void txtBuscarMateriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (txtBuscarMateriales.Text.Trim() == "")
                    return;

                bloquearInfoMateriales();
                buscarItemsSIGA(txtBuscarMateriales.Text.Trim());
            }
        }       
        private void btnCerrarEvaluarSolicitud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEvaluarSolicituD_Click(object sender, EventArgs e)
        {            
            MovimientoSolicitud nuevoMovSolici = new MovimientoSolicitud();
            Solicitud solicitudClass = new Solicitud();
            SolicitudDAO solidao = new SolicitudDAO();
            bool banderaMateriales = false;
            string prioridad = "";
            solicitudClass.NumTicketString = NumTicketInicial;
            nuevoMovSolici.Solicitud = solicitudClass;
            nuevoMovSolici.Estado = "Evaluado";
            nuevoMovSolici.MotivoSolicitud = txtMotivoSolicitud_.Text.Trim();
            nuevoMovSolici.PersonalDesignado = txtListaPersonal.Text.Trim();
            nuevoMovSolici.DiagnosticoPersonal = txtDiagnosticoPerso_.Text.Trim();
            nuevoMovSolici.ReqInsumo = chk_RequiereInsumos.Checked;
            //prioridad:
            prioridad = cboPrioridadSoliEvaluar.Text;
            if (solidao.generarMovimientoSolicitud(nuevoMovSolici))
            {

                if (chk_RequiereInsumos.Checked)
                {
                    foreach (var item in lista_AddMateriales)
                    {
                        if (solidao.agregarMateriales(item))
                        {
                            banderaMateriales = true;
                        }
                        else
                        {
                            banderaMateriales = false;

                        }
                    }

                }

                MessageBox.Show("SE EVALUÓ ESTA SOLICITUD");
            }
            else
            {
                MessageBox.Show("ocurriò un error al evaluar la solicitud");
            }
            if(banderaMateriales)
                MessageBox.Show("se agregaron los materiales correctamente");
            else
                MessageBox.Show("no se agregaron los materiales correctamente");

            if (solidao.actualizarEstadoSolicitud(nuevoMovSolici.Estado,prioridad, NumTicketInicial))
                MessageBox.Show("se actualizó la solicitud.....");
            else
                MessageBox.Show("no se pudo actualizar el estado");

          /*  MessageBox.Show(NumTicketInicial);
            MessageBox.Show(txtMotivoSolicitud_.Text.Trim());
            MessageBox.Show(txtListaPersonal.Text.Trim());
            MessageBox.Show(txtDiagnosticoPerso_.Text.Trim());

            MessageBox.Show(chk_RequiereInsumos.Checked.ToString());*/
        }
        private void txtBuscarPersonal__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (dgvTrabajadorDesig.Rows.Count <= 0)
                    return;

                if (txtListaPersonal.Text.Trim().Contains(dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString()))
                    return;

                txtListaPersonal.Text += "· " + dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString();
                txtListaPersonal.Text += Environment.NewLine;
            }
        }
        private void btnAddLista_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadorDesig.Rows.Count <= 0)
                return;

            if (txtListaPersonal.Text.Trim().Contains(dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString()))
                return;

            txtListaPersonal.Text += "· " + dgvTrabajadorDesig.CurrentRow.Cells[0].Value.ToString();
            txtListaPersonal.Text += Environment.NewLine;

        }
        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            txtListaPersonal.Text = "";
            txtBuscarPersonal_.Text = "";
            txtBuscarPersonal_.Focus();
        }
        private void dgvItemsSIGA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemsSIGA.Rows.Count <= 0)
                return;


            txtItemSelected.Text = dgvItemsSIGA.CurrentRow.Cells[0].Value.ToString();
            txtUMSelected.Text = dgvItemsSIGA.CurrentRow.Cells[2].Value.ToString();
            desbloquearInfoMateriales();
        
        }
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (txtCantidadSelected.Text.Trim() == "")
                return;
            dgvMaterialesAsignados.Enabled = true;

            newItemMaterial = new MovMateriales();
            newItemMaterial.numTicketString = NumTicketInicial;
            newItemMaterial.codSIGA = dgvItemsSIGA.CurrentRow.Cells[0].Value.ToString();
            newItemMaterial.Item_Nombre = dgvItemsSIGA.CurrentRow.Cells[1].Value.ToString();
            newItemMaterial.Unidad_Medida = dgvItemsSIGA.CurrentRow.Cells[2].Value.ToString();
            newItemMaterial.cantidad = Convert.ToInt32(txtCantidadSelected.Text);
            newItemMaterial.estado = "REQUERIDO";

            foreach (var item in lista_AddMateriales)
            {
                if (item.Item_Nombre.Equals(newItemMaterial.Item_Nombre) || item.codSIGA.Equals(newItemMaterial.codSIGA))
                    return;
            }

            lista_AddMateriales.Add(newItemMaterial);
            dgvMaterialesAsignados.DataSource = lista_AddMateriales;
            dgvMaterialesAsignados.Columns.Clear();
            dgvMaterialesAsignados.AutoGenerateColumns = false;
            /*DataGridViewTextBoxColumn numTicketString = new DataGridViewTextBoxColumn();
             numTicketString.HeaderText = "N° Atención";
             numTicketString.DataPropertyName = "numTicketString";
             numTicketString.Width = 150;
             dgvMaterialesAsignados.Columns.Add(numTicketString);*/


            DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
            codSIGA.HeaderText = "COD. SIGA";
            codSIGA.DataPropertyName = "codSIGA";
            codSIGA.Width = 90;
            dgvMaterialesAsignados.Columns.Add(codSIGA);

            DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
            Item_Nombre.HeaderText = "ITEM";
            Item_Nombre.DataPropertyName = "Item_Nombre";
            Item_Nombre.Width = 550;
            dgvMaterialesAsignados.Columns.Add(Item_Nombre);

            DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
            Unidad_Medida.HeaderText = "U. MEDIDA";
            Unidad_Medida.DataPropertyName = "Unidad_Medida";
            Unidad_Medida.Width = 85;
            dgvMaterialesAsignados.Columns.Add(Unidad_Medida);


            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
            cantidad.HeaderText = "CANTIDAD";
            cantidad.DataPropertyName = "cantidad";
            cantidad.Width = 80;
            dgvMaterialesAsignados.Columns.Add(cantidad);

            DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
            colBotones.Name = "colBtnDelete";
            colBotones.HeaderText = "Eliminar Material";
            colBotones.Width = 100;
            this.dgvMaterialesAsignados.Columns.Add(colBotones);

            lblMaterialesUtilziar.Visible = true;
        }
        private void txtCantidadSelected_KeyPress(object sender, KeyPressEventArgs e)        
        {

            if (txtCantidadSelected.Text.Trim() == "")
                return;

            if (e.KeyChar == (int)Keys.Enter)
            {
                dgvMaterialesAsignados.Enabled = true;



                newItemMaterial = new MovMateriales();
                newItemMaterial.numTicketString = NumTicketInicial;
                newItemMaterial.codSIGA = dgvItemsSIGA.CurrentRow.Cells[0].Value.ToString();
                newItemMaterial.Item_Nombre = dgvItemsSIGA.CurrentRow.Cells[1].Value.ToString();
                newItemMaterial.Unidad_Medida = dgvItemsSIGA.CurrentRow.Cells[2].Value.ToString();
                newItemMaterial.cantidad = Convert.ToInt32(txtCantidadSelected.Text);
                newItemMaterial.estado = "REQUERIDO";

                
                foreach (var item in lista_AddMateriales)
                {
                    if (item.Item_Nombre.Equals(newItemMaterial.Item_Nombre) || item.codSIGA.Equals(newItemMaterial.codSIGA))
                        return;
                }

                lista_AddMateriales.Add(newItemMaterial);

                dgvMaterialesAsignados.DataSource = lista_AddMateriales;
                dgvMaterialesAsignados.Columns.Clear();
                dgvMaterialesAsignados.AutoGenerateColumns = false;


                /*DataGridViewTextBoxColumn numTicketString = new DataGridViewTextBoxColumn();
                 numTicketString.HeaderText = "N° Atención";
                 numTicketString.DataPropertyName = "numTicketString";
                 numTicketString.Width = 150;
                 dgvMaterialesAsignados.Columns.Add(numTicketString);*/


                DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
                codSIGA.HeaderText = "COD. SIGA";
                codSIGA.DataPropertyName = "codSIGA";
                codSIGA.Width = 90;
                dgvMaterialesAsignados.Columns.Add(codSIGA);

                DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
                Item_Nombre.HeaderText = "ITEM";
                Item_Nombre.DataPropertyName = "Item_Nombre";
                Item_Nombre.Width = 550;
                dgvMaterialesAsignados.Columns.Add(Item_Nombre);

                DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
                Unidad_Medida.HeaderText = "U. MEDIDA";
                Unidad_Medida.DataPropertyName = "Unidad_Medida";
                Unidad_Medida.Width = 85;
                dgvMaterialesAsignados.Columns.Add(Unidad_Medida);


                DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
                cantidad.HeaderText = "CANTIDAD";
                cantidad.DataPropertyName = "cantidad";
                cantidad.Width = 80;
                dgvMaterialesAsignados.Columns.Add(cantidad);

                DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
                colBotones.Name = "colBtnDelete";
                colBotones.HeaderText = "Eliminar Material";
                colBotones.Width = 100;
                this.dgvMaterialesAsignados.Columns.Add(colBotones);

                lblMaterialesUtilziar.Visible = true;
            }
        }
        private void dgvMaterialesAsignados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvMaterialesAsignados.Columns[e.ColumnIndex].Name == "colBtnDelete" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvMaterialesAsignados.Rows[e.RowIndex].Cells["colBtnDelete"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\deleteGrid.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 35, e.CellBounds.Top + 1);

                this.dgvMaterialesAsignados.Rows[e.RowIndex].Height = icoAtomico.Height + 3;
                //  this.dgvMaterialesAsignados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 3;

                e.Handled = true;
            }
        }

        private void dgvMaterialesAsignados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterialesAsignados.Rows.Count <= 0)
                return;

            if (this.dgvMaterialesAsignados.Columns[e.ColumnIndex].Name == "colBtnDelete")
            {
                eliminarInsumosDGV(dgvMaterialesAsignados.CurrentRow.Index);               
            }
        }

        private void eliminarInsumosDGV(int index)
        {
            lista_AddMateriales = (List<MovMateriales>)dgvMaterialesAsignados.DataSource;
            lista_AddMateriales.RemoveAt(index);
            dgvMaterialesAsignados.DataSource = lista_AddMateriales;

            dgvMaterialesAsignados.Columns.Clear();
            dgvMaterialesAsignados.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn codSIGA = new DataGridViewTextBoxColumn();
            codSIGA.HeaderText = "COD. SIGA";
            codSIGA.DataPropertyName = "codSIGA";
            codSIGA.Width = 90;
            dgvMaterialesAsignados.Columns.Add(codSIGA);

            DataGridViewTextBoxColumn Item_Nombre = new DataGridViewTextBoxColumn();
            Item_Nombre.HeaderText = "ITEM";
            Item_Nombre.DataPropertyName = "Item_Nombre";
            Item_Nombre.Width = 550;
            dgvMaterialesAsignados.Columns.Add(Item_Nombre);

            DataGridViewTextBoxColumn Unidad_Medida = new DataGridViewTextBoxColumn();
            Unidad_Medida.HeaderText = "U. MEDIDA";
            Unidad_Medida.DataPropertyName = "Unidad_Medida";
            Unidad_Medida.Width = 85;
            dgvMaterialesAsignados.Columns.Add(Unidad_Medida);


            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();
            cantidad.HeaderText = "CANTIDAD";
            cantidad.DataPropertyName = "cantidad";
            cantidad.Width = 80;
            dgvMaterialesAsignados.Columns.Add(cantidad);

            DataGridViewButtonColumn colBotones = new DataGridViewButtonColumn();
            colBotones.Name = "colBtnDelete";
            colBotones.HeaderText = "Eliminar Material";
            colBotones.Width = 100;
            this.dgvMaterialesAsignados.Columns.Add(colBotones);
        }
    }
}
