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

using Microsoft.VisualBasic;


namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    public partial class VerMisSolicitudesUser : Form
    {
        string botonSeleccionado = "";

        string numTicketSelectedSaliente = "";
        string prioridadSolicitudSelectedSaliente = "";
        string estadoSolicitudSelectedSaliente = "";

        string numTicketSelectedEntrante = "";
        string prioridadSolicitudSelectedEntrante = "";
        string estadoSolicitudSelectedEntrante = "";


        string oficinaAreaSolicitanteEntrante = "";
        string oficinaAreaSolicitanteSaliente = "";
        public VerMisSolicitudesUser()
        {
            InitializeComponent();
            llenarInfoSolicitante();
            listarSolicitudesSalientes(VarGlobal.userAccesLogueado.DireccionOficina,VarGlobal.userAccesLogueado.AreaEspec);
            listarSolicitudesEntrantes(VarGlobal.userAccesLogueado.DireccionOficina, VarGlobal.userAccesLogueado.AreaEspec);
        }

        private void llenarInfoSolicitante(){

            txtOficinaSolicitante.Text = VarGlobal.userAccesLogueado.DireccionOficina;
            txtAreaSolicitante.Text = VarGlobal.userAccesLogueado.AreaEspec;
        }
        private void listarSolicitudesSalientes(string ofiSoli, string areaSoli)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvSolicitudesSalientes.DataSource = soliDao.listarSolicitudesSalientes(ofiSoli,areaSoli);
            dgvSolicitudesSalientes.Columns.Clear();
            dgvSolicitudesSalientes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn NumTicketString = new DataGridViewTextBoxColumn();
            NumTicketString.HeaderText = "N° Atención";
            NumTicketString.DataPropertyName = "NumTicketString";
            NumTicketString.Width = 100;
            dgvSolicitudesSalientes.Columns.Add(NumTicketString);


            DataGridViewTextBoxColumn FechaHoraRegistroReal = new DataGridViewTextBoxColumn();
            FechaHoraRegistroReal.HeaderText = "F/H de Registro";
            FechaHoraRegistroReal.DataPropertyName = "FechaHoraRegistroReal";
            FechaHoraRegistroReal.Width = 130;
            dgvSolicitudesSalientes.Columns.Add(FechaHoraRegistroReal);

            DataGridViewTextBoxColumn Oficina_Destino = new DataGridViewTextBoxColumn();
            Oficina_Destino.HeaderText = "Oficina Solicitud";
            Oficina_Destino.DataPropertyName = "Oficina_Destino";
            Oficina_Destino.Width = 200;
            dgvSolicitudesSalientes.Columns.Add(Oficina_Destino);

            DataGridViewTextBoxColumn Area_Destino = new DataGridViewTextBoxColumn();
            Area_Destino.HeaderText = "Área Solicitud";
            Area_Destino.DataPropertyName = "Area_Destino";
            Area_Destino.Width = 180;
            dgvSolicitudesSalientes.Columns.Add(Area_Destino);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Estado Solicitud";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 100;
            dgvSolicitudesSalientes.Columns.Add(Estado);


            DataGridViewTextBoxColumn Prioridad = new DataGridViewTextBoxColumn();
            Prioridad.HeaderText = "PR";
            Prioridad.DataPropertyName = "Prioridad";
            Prioridad.Width = 50;
            dgvSolicitudesSalientes.Columns.Add(Prioridad);

        }

        private void listarSolicitudesEntrantes(string ofiDestino, string areaDestino)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvSolicitudesEntrantes.DataSource = soliDao.listarSolicitudEntrantes(ofiDestino, areaDestino);
            dgvSolicitudesEntrantes.Columns.Clear();
            dgvSolicitudesEntrantes.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn NumTicketString = new DataGridViewTextBoxColumn();
            NumTicketString.HeaderText = "N° Atención";
            NumTicketString.DataPropertyName = "NumTicketString";
            NumTicketString.Width = 100;
            dgvSolicitudesEntrantes.Columns.Add(NumTicketString);


            DataGridViewTextBoxColumn FechaHoraRegistroReal = new DataGridViewTextBoxColumn();
            FechaHoraRegistroReal.HeaderText = "F/H de Registro";
            FechaHoraRegistroReal.DataPropertyName = "FechaHoraRegistroReal";
            FechaHoraRegistroReal.Width = 130;
            dgvSolicitudesEntrantes.Columns.Add(FechaHoraRegistroReal);

            DataGridViewTextBoxColumn Oficina_Destino = new DataGridViewTextBoxColumn();
            Oficina_Destino.HeaderText = "Oficina Solicitante";
            Oficina_Destino.DataPropertyName = "Oficina_Solicitante";
            Oficina_Destino.Width = 200;
            dgvSolicitudesEntrantes.Columns.Add(Oficina_Destino);

            DataGridViewTextBoxColumn Area_Destino = new DataGridViewTextBoxColumn();
            Area_Destino.HeaderText = "Área Solicitante";
            Area_Destino.DataPropertyName = "Area_Solicitante";
            Area_Destino.Width = 180;
            dgvSolicitudesEntrantes.Columns.Add(Area_Destino);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Estado Solicitud";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 100;
            dgvSolicitudesEntrantes.Columns.Add(Estado);


            DataGridViewTextBoxColumn Prioridad = new DataGridViewTextBoxColumn();
            Prioridad.HeaderText = "PR";
            Prioridad.DataPropertyName = "Prioridad";
            Prioridad.Width = 50;
            dgvSolicitudesEntrantes.Columns.Add(Prioridad);

            DataGridViewTextBoxColumn NombreUsuario = new DataGridViewTextBoxColumn();
            NombreUsuario.HeaderText = "Nombre Usuario";
            NombreUsuario.DataPropertyName = "NomPC_Solicitante";
            NombreUsuario.Width = 50;
            dgvSolicitudesEntrantes.Columns.Add(NombreUsuario);

        }
        private void dgvSolicitudesEntrantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaliente_CambiarEstado.Visible = false;
            numTicketSelectedSaliente = dgvSolicitudesSalientes.CurrentRow.Cells[0].Value.ToString();
            prioridadSolicitudSelectedSaliente = dgvSolicitudesSalientes.CurrentRow.Cells[5].Value.ToString();

            estadoSolicitudSelectedSaliente = dgvSolicitudesSalientes.CurrentRow.Cells[4].Value.ToString();

            //oficinaarea_solicitante:
            oficinaAreaSolicitanteSaliente = dgvSolicitudesSalientes.CurrentRow.Cells[2].Value.ToString() + " - " +  dgvSolicitudesSalientes.CurrentRow.Cells[3].Value.ToString();
            listarMovimientoSolicitud_Salientes(numTicketSelectedSaliente);                                            
        }
        private void habilitarBotonesSalientes()
        {

            if (botonSeleccionado.Equals("Saliente"))
            {
                string oficinaDestino = dgvSolicitudesSalientes.CurrentRow.Cells[2].Value.ToString();
                string areaDestino = dgvSolicitudesSalientes.CurrentRow.Cells[3].Value.ToString();

                //Validar si la solicitud es de la misma área:
                if (VarGlobal.userAccesLogueado.DireccionOficina.Equals(oficinaDestino) &&
                    VarGlobal.userAccesLogueado.AreaEspec.Equals(areaDestino))
                {
                    //string estado = dgvSolicitudesEntrantes.CurrentRow.Cells[4].Value.ToString();
                    btnSaliente_CambiarEstado.Visible = true;

                    if (estadoSolicitudSelectedSaliente.Equals("Solicitado"))
                        btnSaliente_CambiarEstado.Text = "Evaluar Solicitud";
                    else if (estadoSolicitudSelectedSaliente.Equals("Evaluado"))
                        btnSaliente_CambiarEstado.Text = "Iniciar Trabajo";
                    else if (estadoSolicitudSelectedSaliente.Equals("En curso"))
                        btnSaliente_CambiarEstado.Text = "Concluir Trabajo";
                    else if (estadoSolicitudSelectedSaliente.Equals("Atendido"))
                        btnSaliente_CambiarEstado.Visible = false;
                    
                }
            }
            else if (botonSeleccionado.Equals("Entrante"))
            {

                btnCambiarEstadoSolicitudEntrante.Visible = true;

                if (estadoSolicitudSelectedEntrante.Equals("Solicitado"))
                    btnCambiarEstadoSolicitudEntrante.Text = "Evaluar Solicitud";
                else if (estadoSolicitudSelectedEntrante.Equals("Evaluado"))
                    btnCambiarEstadoSolicitudEntrante.Text = "Iniciar Trabajo";
                else if (estadoSolicitudSelectedEntrante.Equals("En curso"))
                    btnCambiarEstadoSolicitudEntrante.Text = "Concluir Trabajo";
                else if (estadoSolicitudSelectedEntrante.Equals("Atendido"))
                    btnCambiarEstadoSolicitudEntrante.Visible = false;

            }

        }
        private void listarMovimientoSolicitud_Salientes(string numticketStr)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvMovimientoSolicitudSalientes.DataSource = soliDao.listarMovimientoSolicitud(numticketStr);
            dgvMovimientoSolicitudSalientes.Columns.Clear();
            dgvMovimientoSolicitudSalientes.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn MotivoSolicitud = new DataGridViewTextBoxColumn();
            MotivoSolicitud.HeaderText = "Motivo";
            MotivoSolicitud.DataPropertyName = "MotivoSolicitud";
            MotivoSolicitud.Width = 200;
            dgvMovimientoSolicitudSalientes.Columns.Add(MotivoSolicitud);


            DataGridViewTextBoxColumn FechaHoraMovimiento = new DataGridViewTextBoxColumn();
            FechaHoraMovimiento.HeaderText = "F/H Mov";
            FechaHoraMovimiento.DataPropertyName = "FechaHoraMovimiento";
            FechaHoraMovimiento.Width = 150;
            dgvMovimientoSolicitudSalientes.Columns.Add(FechaHoraMovimiento);

            DataGridViewTextBoxColumn PersonalDesignado = new DataGridViewTextBoxColumn();
            PersonalDesignado.HeaderText = "Personal Desig.";
            PersonalDesignado.DataPropertyName = "PersonalDesignado";
            PersonalDesignado.Width = 200;
            dgvMovimientoSolicitudSalientes.Columns.Add(PersonalDesignado);

            DataGridViewTextBoxColumn DiagnosticoPersonal = new DataGridViewTextBoxColumn();
            DiagnosticoPersonal.HeaderText = "Diag. Personal";
            DiagnosticoPersonal.DataPropertyName = "DiagnosticoPersonal";
            DiagnosticoPersonal.Width = 200;
            dgvMovimientoSolicitudSalientes.Columns.Add(DiagnosticoPersonal);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Estado";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 200;
            dgvMovimientoSolicitudSalientes.Columns.Add(Estado);


            DataGridViewTextBoxColumn ReqInsumo = new DataGridViewTextBoxColumn();
            ReqInsumo.HeaderText = "Req Insumo?";
            ReqInsumo.DataPropertyName = "ReqInsumoString";
            ReqInsumo.Width = 150;
            dgvMovimientoSolicitudSalientes.Columns.Add(ReqInsumo);

            

        }
        private void listarMovimientoSolicitud_Entrantes(string numticketStrEntrante)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvMovSoliEntrante.DataSource = soliDao.listarMovimientoSolicitud(numticketStrEntrante);
            dgvMovSoliEntrante.Columns.Clear();
            dgvMovSoliEntrante.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn MotivoSolicitud = new DataGridViewTextBoxColumn();
            MotivoSolicitud.HeaderText = "Motivo";
            MotivoSolicitud.DataPropertyName = "MotivoSolicitud";
            MotivoSolicitud.Width = 200;
            dgvMovSoliEntrante.Columns.Add(MotivoSolicitud);


            DataGridViewTextBoxColumn FechaHoraMovimiento = new DataGridViewTextBoxColumn();
            FechaHoraMovimiento.HeaderText = "F/H Mov";
            FechaHoraMovimiento.DataPropertyName = "FechaHoraMovimiento";
            FechaHoraMovimiento.Width = 150;
            dgvMovSoliEntrante.Columns.Add(FechaHoraMovimiento);

            DataGridViewTextBoxColumn PersonalDesignado = new DataGridViewTextBoxColumn();
            PersonalDesignado.HeaderText = "Personal Desig.";
            PersonalDesignado.DataPropertyName = "PersonalDesignado";
            PersonalDesignado.Width = 200;
            dgvMovSoliEntrante.Columns.Add(PersonalDesignado);

            DataGridViewTextBoxColumn DiagnosticoPersonal = new DataGridViewTextBoxColumn();
            DiagnosticoPersonal.HeaderText = "Diag. Personal";
            DiagnosticoPersonal.DataPropertyName = "DiagnosticoPersonal";
            DiagnosticoPersonal.Width = 200;
            dgvMovSoliEntrante.Columns.Add(DiagnosticoPersonal);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Estado";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 200;
            dgvMovSoliEntrante.Columns.Add(Estado);


            DataGridViewTextBoxColumn ReqInsumo = new DataGridViewTextBoxColumn();
            ReqInsumo.HeaderText = "Req Insumo?";
            ReqInsumo.DataPropertyName = "ReqInsumoString";
            ReqInsumo.Width = 150;
            dgvMovSoliEntrante.Columns.Add(ReqInsumo);

        }
        private void btnSaliente_CambiarEstado_Click(object sender, EventArgs e)
        {
            if (btnSaliente_CambiarEstado.Text == "Evaluar Solicitud")
            {
                EvaluarSolicitudUser openCambiarESTADO = new EvaluarSolicitudUser();
                //dgvMovimientoSolicitudEntrantes.Rows[dgvMovimientoSolicitudEntrantes.Rows.Count - 1].Selected = true;
                string motivoSolicitud = dgvMovimientoSolicitudSalientes.CurrentRow.Cells[0].Value.ToString();
                openCambiarESTADO.NumTicketInicial = numTicketSelectedSaliente;
                openCambiarESTADO.MotivoSolicitudInicial = motivoSolicitud;
                openCambiarESTADO.prioridadSolicitudInicial = prioridadSolicitudSelectedSaliente;
                openCambiarESTADO.ShowDialog();
            }
            else if (btnSaliente_CambiarEstado.Text == "Iniciar Trabajo")
            {
                int filas = dgvMovimientoSolicitudSalientes.Rows.Count - 1;
                MovimientoSolicitud nuevoMovSolici = new MovimientoSolicitud();
                Solicitud solicitudClass = new Solicitud();
                SolicitudDAO solidao = new SolicitudDAO();
                solicitudClass.NumTicketString = numTicketSelectedSaliente;
                nuevoMovSolici.Solicitud = solicitudClass;
                nuevoMovSolici.Estado = "En curso";
                nuevoMovSolici.MotivoSolicitud = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[0].Value.ToString();
                nuevoMovSolici.PersonalDesignado = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[2].Value.ToString();
                nuevoMovSolici.DiagnosticoPersonal = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[3].Value.ToString();
                bool reqInsumo = (dgvMovimientoSolicitudSalientes.Rows[filas].Cells[5].Value.ToString() == "SI") ? true : false;
                nuevoMovSolici.ReqInsumo = reqInsumo;

                if (solidao.generarMovimientoSolicitud(nuevoMovSolici))
                {
                    MessageBox.Show("Trabajo Iniciado.");
                }
                else
                {
                    MessageBox.Show("ocurriò un error al iniciar la solicitud");
                }

                if (solidao.actualizarEstadoSolicitud(nuevoMovSolici.Estado, prioridadSolicitudSelectedSaliente, numTicketSelectedSaliente))
                    MessageBox.Show("se actualizó la solicitud.....");
                else
                    MessageBox.Show("no se pudo actualizar el estado");
            }
            else if (btnSaliente_CambiarEstado.Text == "Concluir Trabajo")
            {
                ConcluirSolicitudUser openConcluirTrabajo = new ConcluirSolicitudUser();
                openConcluirTrabajo.nroTicket = numTicketSelectedSaliente;
                openConcluirTrabajo.oficinaAreaSolicitante = oficinaAreaSolicitanteSaliente;
                int filas = dgvMovimientoSolicitudSalientes.Rows.Count - 1;
                openConcluirTrabajo.motivoSolicitud = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[0].Value.ToString();
                openConcluirTrabajo.diagnosticoPersonal = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[3].Value.ToString();
                openConcluirTrabajo.personalDesignado = dgvMovimientoSolicitudSalientes.Rows[filas].Cells[2].Value.ToString();
                openConcluirTrabajo.prioridadConcluir = prioridadSolicitudSelectedSaliente;
                openConcluirTrabajo.ShowDialog();
            }                               
        }
        private void btnCambiarEstadoSolicitudEntrante_Click(object sender, EventArgs e)
        {
            if (btnCambiarEstadoSolicitudEntrante.Text == "Evaluar Solicitud")
            {
                EvaluarSolicitudUser openCambiarESTADO = new EvaluarSolicitudUser();
                //dgvMovimientoSolicitudEntrantes.Rows[dgvMovimientoSolicitudEntrantes.Rows.Count - 1].Selected = true;
                string motivoSolicitudEntrante = dgvMovSoliEntrante.CurrentRow.Cells[0].Value.ToString();

                openCambiarESTADO.NumTicketInicial = numTicketSelectedEntrante;
                openCambiarESTADO.MotivoSolicitudInicial = motivoSolicitudEntrante;
                openCambiarESTADO.prioridadSolicitudInicial = prioridadSolicitudSelectedEntrante;
                openCambiarESTADO.FormClosed += new System.Windows.Forms.FormClosedEventHandler(openEvaluarSolicitud_FormClosed);
                openCambiarESTADO.ShowDialog();
            }
            else if (btnCambiarEstadoSolicitudEntrante.Text == "Iniciar Trabajo")
            {
                int filas = dgvMovSoliEntrante.Rows.Count - 1;
                MovimientoSolicitud nuevoMovSolici = new MovimientoSolicitud();
                Solicitud solicitudClass = new Solicitud();
                SolicitudDAO solidao = new SolicitudDAO();              
                solicitudClass.NumTicketString = numTicketSelectedEntrante;
                nuevoMovSolici.Solicitud = solicitudClass;
                nuevoMovSolici.Estado = "En curso";
                nuevoMovSolici.MotivoSolicitud = dgvMovSoliEntrante.Rows[filas].Cells[0].Value.ToString();
                nuevoMovSolici.PersonalDesignado = dgvMovSoliEntrante.Rows[filas].Cells[2].Value.ToString();
                nuevoMovSolici.DiagnosticoPersonal = dgvMovSoliEntrante.Rows[filas].Cells[3].Value.ToString();
                bool reqInsumo = (dgvMovSoliEntrante.Rows[filas].Cells[5].Value.ToString() == "SI") ? true : false;
                nuevoMovSolici.ReqInsumo = reqInsumo;

                if (solidao.generarMovimientoSolicitud(nuevoMovSolici))
                {
                    MessageBox.Show("Trabajo Iniciado.","Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    
                }
                else
                {
                    MessageBox.Show("Ocurriò un error al iniciar la solicitud","Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }

                if (solidao.actualizarEstadoSolicitud(nuevoMovSolici.Estado, prioridadSolicitudSelectedEntrante, numTicketSelectedEntrante)){
                    MessageBox.Show("Se actualizó la solicitud.", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    listarMovimientoSolicitud_Entrantes(numTicketSelectedEntrante);
                }                   
                else
                    MessageBox.Show("No se pudo actualizar el estado", "Mensaje al Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else if (btnCambiarEstadoSolicitudEntrante.Text == "Concluir Trabajo")
            {
                ConcluirSolicitudUser openConcluirTrabajo = new ConcluirSolicitudUser();
                openConcluirTrabajo.nroTicket = numTicketSelectedEntrante;
                openConcluirTrabajo.oficinaAreaSolicitante = oficinaAreaSolicitanteEntrante;
                int filas = dgvMovSoliEntrante.Rows.Count - 1;
                openConcluirTrabajo.motivoSolicitud = dgvMovSoliEntrante.Rows[filas].Cells[0].Value.ToString();
                openConcluirTrabajo.diagnosticoPersonal = dgvMovSoliEntrante.Rows[filas].Cells[3].Value.ToString();
                openConcluirTrabajo.personalDesignado = dgvMovSoliEntrante.Rows[filas].Cells[2].Value.ToString();
                openConcluirTrabajo.prioridadConcluir = prioridadSolicitudSelectedEntrante;

                openConcluirTrabajo.FormClosed += new System.Windows.Forms.FormClosedEventHandler(openEvaluarSolicitud_FormClosed);
                openConcluirTrabajo.ShowDialog();
            }           
        }
        private void btnVerMaterialesEntrantes_Click(object sender, EventArgs e)
        {
            if (botonSeleccionado.Equals("Entrante"))
            {
                VerMaterialesUser openVerMateriales = new VerMaterialesUser();
                openVerMateriales.nroTicketMat = numTicketSelectedEntrante;
                openVerMateriales.estadoReq = estadoSolicitudSelectedEntrante;
                openVerMateriales.ShowDialog();
                
            }
        }
        private void btnVerMaterialesSalientes_Click(object sender, EventArgs e)
        {
            if (botonSeleccionado.Equals("Saliente"))
            {
                VerMaterialesUser openVerMateriales = new VerMaterialesUser();
                openVerMateriales.nroTicketMat = numTicketSelectedSaliente;
                openVerMateriales.estadoReq = estadoSolicitudSelectedSaliente;
                openVerMateriales.ShowDialog();
            }
        }
        private void btnCerrarVerMisSolis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvMovimientoSolicitudSalientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMotivoExtend.Text = dgvMovimientoSolicitudSalientes.CurrentRow.Cells[0].Value.ToString();
            txtPersonalDesigExtend.Text = dgvMovimientoSolicitudSalientes.CurrentRow.Cells[2].Value.ToString();
            txtDiagnosticoPersonalExtend.Text = dgvMovimientoSolicitudSalientes.CurrentRow.Cells[3].Value.ToString();

            botonSeleccionado = "Saliente";
          //  btnSaliente_AnularSoli.Visible = true;
            habilitarBotonesSalientes();

            int filas = dgvMovimientoSolicitudSalientes.Rows.Count - 1;

            if (dgvMovimientoSolicitudSalientes.Rows[filas].Cells[5].Value.ToString().Equals("SI") && (estadoSolicitudSelectedSaliente.Equals("Evaluado") ||
                estadoSolicitudSelectedSaliente.Equals("En curso") || estadoSolicitudSelectedSaliente.Equals("Atendido"))
                )
            {
                btnVerMaterialesSalientes.Visible = true;
            }


        }
        private void dgvSolicitudesEntrantes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnCambiarEstadoSolicitudEntrante.Visible = false;

            numTicketSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[0].Value.ToString();
            prioridadSolicitudSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[5].Value.ToString();
            estadoSolicitudSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[4].Value.ToString();
            //oficinaarea_solicitante:
            oficinaAreaSolicitanteEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[2].Value.ToString() + " - " + dgvSolicitudesEntrantes.CurrentRow.Cells[3].Value.ToString();

            listarMovimientoSolicitud_Entrantes(numTicketSelectedEntrante);
        }
        private void dgvMovSoliEntrante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            botonSeleccionado = "Entrante";
            habilitarBotonesSalientes();

            int filas = dgvMovSoliEntrante.Rows.Count - 1;

            if (dgvMovSoliEntrante.Rows[filas].Cells[5].Value.ToString().Equals("SI") && (estadoSolicitudSelectedEntrante.Equals("Evaluado") ||
                estadoSolicitudSelectedEntrante.Equals("En curso") || estadoSolicitudSelectedEntrante.Equals("Atendido"))
                )
            {
                btnVerMaterialesEntrantes.Visible = true;
            }
        }
        //Cerrar Evaluar Solicitud- Entrante:
        private void openEvaluarSolicitud_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCambiarEstadoSolicitudEntrante.Visible = false;

            numTicketSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[0].Value.ToString();
            prioridadSolicitudSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[5].Value.ToString();
            estadoSolicitudSelectedEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[4].Value.ToString();
            //oficinaarea_solicitante:
            oficinaAreaSolicitanteEntrante = dgvSolicitudesEntrantes.CurrentRow.Cells[2].Value.ToString() + " - " + dgvSolicitudesEntrantes.CurrentRow.Cells[3].Value.ToString();

            listarMovimientoSolicitud_Entrantes(numTicketSelectedEntrante);
        }



        //Personalizando Celdas por estado:


        private void dgvSolicitudesEntrantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {

                if (e.Value.ToString().Equals("Solicitado"))
                {
                    DataGridViewColumn col = dgvSolicitudesEntrantes.Columns[e.ColumnIndex];
                    col.DefaultCellStyle.ForeColor = Color.DarkGreen;                    
                }

                if (e.Value.ToString().Equals("Evaluado"))
                {
                    DataGridViewColumn col = dgvSolicitudesEntrantes.Columns[e.ColumnIndex];
                    col.DefaultCellStyle.ForeColor = Color.Olive;               
                }

                if (e.Value.ToString().Equals("En curso"))
                {
                    DataGridViewColumn col = dgvSolicitudesEntrantes.Columns[e.ColumnIndex];
                    col.DefaultCellStyle.ForeColor = Color.DarkOrange;                   
                }

                if (e.Value.ToString().Equals("Atendido"))
                {
                    DataGridViewColumn col = dgvSolicitudesEntrantes.Columns[e.ColumnIndex];
                    col.DefaultCellStyle.ForeColor = Color.Black;                   
                }

                SuspendLayout();
                ResumeLayout();
            }

        }



        private void dgvSolicitudesSalientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 0)
            {
                DataGridViewColumn col = dgvSolicitudesSalientes.Columns[e.ColumnIndex];
                col.DefaultCellStyle.ForeColor = Color.Red;
                col.DefaultCellStyle.BackColor = Color.Red;
            }
        }



        
       
    }
}
