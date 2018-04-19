namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    partial class EvaluarSolicitudUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluarSolicitudUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarGenSolicitud = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivoSolicitud_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumTicket_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabMisSolicitudes = new System.Windows.Forms.TabControl();
            this.tabPersonalDesig = new System.Windows.Forms.TabPage();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnAddLista = new System.Windows.Forms.Button();
            this.dgvTrabajadorDesig = new System.Windows.Forms.DataGridView();
            this.txtListaPersonal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarPersonal_ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabMateriales = new System.Windows.Forms.TabPage();
            this.txtDiagnosticoPerso_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).BeginInit();
            this.tabMisSolicitudes.SuspendLayout();
            this.tabPersonalDesig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadorDesig)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnCerrarGenSolicitud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarGenSolicitud
            // 
            this.btnCerrarGenSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarGenSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarGenSolicitud.Image")));
            this.btnCerrarGenSolicitud.Location = new System.Drawing.Point(764, 4);
            this.btnCerrarGenSolicitud.Name = "btnCerrarGenSolicitud";
            this.btnCerrarGenSolicitud.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarGenSolicitud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarGenSolicitud.TabIndex = 2;
            this.btnCerrarGenSolicitud.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evaluar Solicitud";
            // 
            // txtMotivoSolicitud_
            // 
            this.txtMotivoSolicitud_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoSolicitud_.Location = new System.Drawing.Point(122, 75);
            this.txtMotivoSolicitud_.Multiline = true;
            this.txtMotivoSolicitud_.Name = "txtMotivoSolicitud_";
            this.txtMotivoSolicitud_.Size = new System.Drawing.Size(681, 56);
            this.txtMotivoSolicitud_.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "Motivo Solicitud:";
            // 
            // txtNumTicket_
            // 
            this.txtNumTicket_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTicket_.Location = new System.Drawing.Point(122, 46);
            this.txtNumTicket_.Name = "txtNumTicket_";
            this.txtNumTicket_.Size = new System.Drawing.Size(171, 21);
            this.txtNumTicket_.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nº Atención:";
            // 
            // tabMisSolicitudes
            // 
            this.tabMisSolicitudes.Controls.Add(this.tabPersonalDesig);
            this.tabMisSolicitudes.Controls.Add(this.tabMateriales);
            this.tabMisSolicitudes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMisSolicitudes.Location = new System.Drawing.Point(0, 199);
            this.tabMisSolicitudes.Name = "tabMisSolicitudes";
            this.tabMisSolicitudes.SelectedIndex = 0;
            this.tabMisSolicitudes.Size = new System.Drawing.Size(807, 291);
            this.tabMisSolicitudes.TabIndex = 21;
            // 
            // tabPersonalDesig
            // 
            this.tabPersonalDesig.AutoScroll = true;
            this.tabPersonalDesig.Controls.Add(this.btnLimpiarLista);
            this.tabPersonalDesig.Controls.Add(this.btnAddLista);
            this.tabPersonalDesig.Controls.Add(this.dgvTrabajadorDesig);
            this.tabPersonalDesig.Controls.Add(this.txtListaPersonal);
            this.tabPersonalDesig.Controls.Add(this.label2);
            this.tabPersonalDesig.Controls.Add(this.txtBuscarPersonal_);
            this.tabPersonalDesig.Controls.Add(this.label8);
            this.tabPersonalDesig.Location = new System.Drawing.Point(4, 26);
            this.tabPersonalDesig.Name = "tabPersonalDesig";
            this.tabPersonalDesig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalDesig.Size = new System.Drawing.Size(799, 261);
            this.tabPersonalDesig.TabIndex = 0;
            this.tabPersonalDesig.Text = "Personal";
            this.tabPersonalDesig.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.FlatAppearance.BorderSize = 0;
            this.btnLimpiarLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLimpiarLista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarLista.Location = new System.Drawing.Point(94, 224);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(95, 23);
            this.btnLimpiarLista.TabIndex = 19;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = true;
            // 
            // btnAddLista
            // 
            this.btnAddLista.FlatAppearance.BorderSize = 0;
            this.btnAddLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddLista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddLista.Location = new System.Drawing.Point(14, 132);
            this.btnAddLista.Name = "btnAddLista";
            this.btnAddLista.Size = new System.Drawing.Size(134, 35);
            this.btnAddLista.TabIndex = 18;
            this.btnAddLista.Text = "Agregar a la Lista";
            this.btnAddLista.UseVisualStyleBackColor = true;
            this.btnAddLista.Visible = false;
            this.btnAddLista.Click += new System.EventHandler(this.btnAddLista_Click);
            // 
            // dgvTrabajadorDesig
            // 
            this.dgvTrabajadorDesig.AllowUserToAddRows = false;
            this.dgvTrabajadorDesig.AllowUserToDeleteRows = false;
            this.dgvTrabajadorDesig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadorDesig.Location = new System.Drawing.Point(11, 37);
            this.dgvTrabajadorDesig.Name = "dgvTrabajadorDesig";
            this.dgvTrabajadorDesig.ReadOnly = true;
            this.dgvTrabajadorDesig.Size = new System.Drawing.Size(768, 91);
            this.dgvTrabajadorDesig.TabIndex = 17;
            this.dgvTrabajadorDesig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadorDesig_CellClick);
            // 
            // txtListaPersonal
            // 
            this.txtListaPersonal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaPersonal.Location = new System.Drawing.Point(195, 166);
            this.txtListaPersonal.Multiline = true;
            this.txtListaPersonal.Name = "txtListaPersonal";
            this.txtListaPersonal.ReadOnly = true;
            this.txtListaPersonal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaPersonal.Size = new System.Drawing.Size(584, 89);
            this.txtListaPersonal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(59, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Personal Designado:";
            // 
            // txtBuscarPersonal_
            // 
            this.txtBuscarPersonal_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPersonal_.Location = new System.Drawing.Point(234, 10);
            this.txtBuscarPersonal_.Name = "txtBuscarPersonal_";
            this.txtBuscarPersonal_.Size = new System.Drawing.Size(544, 21);
            this.txtBuscarPersonal_.TabIndex = 14;
            this.txtBuscarPersonal_.TextChanged += new System.EventHandler(this.txtBuscarPersonal__TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Buscar Personal por DNI o Nombres:";
            // 
            // tabMateriales
            // 
            this.tabMateriales.AutoScroll = true;
            this.tabMateriales.Location = new System.Drawing.Point(4, 26);
            this.tabMateriales.Name = "tabMateriales";
            this.tabMateriales.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateriales.Size = new System.Drawing.Size(799, 261);
            this.tabMateriales.TabIndex = 1;
            this.tabMateriales.Text = "Insumos";
            this.tabMateriales.UseVisualStyleBackColor = true;
            // 
            // txtDiagnosticoPerso_
            // 
            this.txtDiagnosticoPerso_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosticoPerso_.Location = new System.Drawing.Point(122, 137);
            this.txtDiagnosticoPerso_.Multiline = true;
            this.txtDiagnosticoPerso_.Name = "txtDiagnosticoPerso_";
            this.txtDiagnosticoPerso_.Size = new System.Drawing.Size(681, 56);
            this.txtDiagnosticoPerso_.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "Diagnóstico Personal:";
            // 
            // EvaluarSolicitudUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 489);
            this.Controls.Add(this.txtDiagnosticoPerso_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabMisSolicitudes);
            this.Controls.Add(this.txtMotivoSolicitud_);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumTicket_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluarSolicitudUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvaluarSolicitudUser";
            this.Load += new System.EventHandler(this.EvaluarSolicitudUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).EndInit();
            this.tabMisSolicitudes.ResumeLayout(false);
            this.tabPersonalDesig.ResumeLayout(false);
            this.tabPersonalDesig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadorDesig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarGenSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivoSolicitud_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumTicket_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabMisSolicitudes;
        private System.Windows.Forms.TabPage tabPersonalDesig;
        private System.Windows.Forms.DataGridView dgvTrabajadorDesig;
        private System.Windows.Forms.TextBox txtListaPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarPersonal_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabMateriales;
        private System.Windows.Forms.TextBox txtDiagnosticoPerso_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnAddLista;
    }
}