namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User.Informes
{
    partial class Frm_Inf_SolicitudAtendida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inf_SolicitudAtendida));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InformeAtendidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarGenSolicitud = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.InformeAtendidoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // InformeAtendidoBindingSource
            // 
            this.InformeAtendidoBindingSource.DataSource = typeof(Solicitud_de_Servicio_Interno_HVLH.Class.InformeAtendido);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnCerrarGenSolicitud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrarGenSolicitud
            // 
            this.btnCerrarGenSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarGenSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarGenSolicitud.Image")));
            this.btnCerrarGenSolicitud.Location = new System.Drawing.Point(1003, 4);
            this.btnCerrarGenSolicitud.Name = "btnCerrarGenSolicitud";
            this.btnCerrarGenSolicitud.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarGenSolicitud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarGenSolicitud.TabIndex = 2;
            this.btnCerrarGenSolicitud.TabStop = false;
            this.btnCerrarGenSolicitud.Click += new System.EventHandler(this.btnCerrarGenSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe de Solicitud Atendida";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsInformeAtendido";
            reportDataSource1.Value = this.InformeAtendidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Solicitud_de_Servicio_Interno_HVLH.Vista.User.Informes.Inf_SolicitudAtendida.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1046, 524);
            this.reportViewer1.TabIndex = 4;
            // 
            // Frm_Inf_SolicitudAtendida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 564);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Inf_SolicitudAtendida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Inf_SolicitudAtendida";
            this.Load += new System.EventHandler(this.Frm_Inf_SolicitudAtendida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformeAtendidoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarGenSolicitud;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InformeAtendidoBindingSource;
    }
}