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
    public partial class VerMisSolicitudesUser : Form
    {
        public VerMisSolicitudesUser()
        {
            InitializeComponent();
            llenarInfoSolicitante();
            listarSolicitudesSalientes(VarGlobal.userAccesLogueado.DireccionOficina,VarGlobal.userAccesLogueado.AreaEspec);
        }

        private void llenarInfoSolicitante(){

            txtOficinaSolicitante.Text = VarGlobal.userAccesLogueado.DireccionOficina;
            txtAreaSolicitante.Text = VarGlobal.userAccesLogueado.AreaEspec;
        }
        private void listarSolicitudesSalientes(string ofiSoli, string areaSoli)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvSolicitudesEntrantes.DataSource = soliDao.listarSolicitudesSalientes(ofiSoli,areaSoli);
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
            Oficina_Destino.HeaderText = "Oficina Solicitud";
            Oficina_Destino.DataPropertyName = "Oficina_Destino";
            Oficina_Destino.Width = 200;
            dgvSolicitudesEntrantes.Columns.Add(Oficina_Destino);

            DataGridViewTextBoxColumn Area_Destino = new DataGridViewTextBoxColumn();
            Area_Destino.HeaderText = "Área Solicitud";
            Area_Destino.DataPropertyName = "Area_Destino";
            Area_Destino.Width = 180;
            dgvSolicitudesEntrantes.Columns.Add(Area_Destino);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Área Solicitud";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 100;
            dgvSolicitudesEntrantes.Columns.Add(Estado);


            DataGridViewTextBoxColumn Prioridad = new DataGridViewTextBoxColumn();
            Prioridad.HeaderText = "PR";
            Prioridad.DataPropertyName = "Prioridad";
            Prioridad.Width = 50;
            dgvSolicitudesEntrantes.Columns.Add(Prioridad);


        }
        private void dgvSolicitudesEntrantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string numTicketSelected = dgvSolicitudesEntrantes.CurrentRow.Cells[0].Value.ToString();
            listarMovimientoSolicitud_Entrantes(numTicketSelected);
        }

        private void listarMovimientoSolicitud_Entrantes(string numticketStr)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvMovimientoSolicitudEntrantes.DataSource = soliDao.listarMovimientoSolicitud(numticketStr);
            dgvMovimientoSolicitudEntrantes.Columns.Clear();
            dgvMovimientoSolicitudEntrantes.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn MotivoSolicitud = new DataGridViewTextBoxColumn();
            MotivoSolicitud.HeaderText = "Motivo";
            MotivoSolicitud.DataPropertyName = "MotivoSolicitud";
            MotivoSolicitud.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(MotivoSolicitud);


            DataGridViewTextBoxColumn FechaHoraMovimiento = new DataGridViewTextBoxColumn();
            FechaHoraMovimiento.HeaderText = "F/H Mov";
            FechaHoraMovimiento.DataPropertyName = "FechaHoraMovimiento";
            FechaHoraMovimiento.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(FechaHoraMovimiento);

            DataGridViewTextBoxColumn PersonalDesignado = new DataGridViewTextBoxColumn();
            PersonalDesignado.HeaderText = "Personal Desig.";
            PersonalDesignado.DataPropertyName = "PersonalDesignado";
            PersonalDesignado.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(PersonalDesignado);

            DataGridViewTextBoxColumn DiagnosticoPersonal = new DataGridViewTextBoxColumn();
            DiagnosticoPersonal.HeaderText = "Diag. Personal";
            DiagnosticoPersonal.DataPropertyName = "DiagnosticoPersonal";
            DiagnosticoPersonal.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(DiagnosticoPersonal);

            DataGridViewTextBoxColumn Estado = new DataGridViewTextBoxColumn();
            Estado.HeaderText = "Estado";
            Estado.DataPropertyName = "Estado";
            Estado.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(Estado);


            DataGridViewTextBoxColumn ReqInsumo = new DataGridViewTextBoxColumn();
            ReqInsumo.HeaderText = "Req Insumo?";
            ReqInsumo.DataPropertyName = "ReqInsumo";
            ReqInsumo.Width = 200;
            dgvMovimientoSolicitudEntrantes.Columns.Add(ReqInsumo);

            string ss = ReqInsumo.DataPropertyName = "DiagnosticoPersonal";
            MessageBox.Show(ss);

        }
    }
}
