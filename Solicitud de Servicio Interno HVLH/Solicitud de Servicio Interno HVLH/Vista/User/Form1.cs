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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listarSolicitudesSalientes("OFICINA DE ESTADISTICA E INFORMATICA", "INFORMÁTICA");
        }

        private void listarSolicitudesSalientes(string ofiSoli, string areaSoli)
        {
            SolicitudDAO soliDao = new SolicitudDAO();
            dgvSolicitudesSalientes.DataSource = soliDao.listarSolicitudesSalientes(ofiSoli, areaSoli);
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

        private void dgvSolicitudesSalientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4)
            {
                if (e.Value.ToString().Equals("Atendido"))
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Black;
                }
            }
        }

        private void btnCerrarVerMisSolis_Click(object sender, EventArgs e)
        {

        }

    }
}
