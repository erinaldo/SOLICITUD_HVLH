namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    partial class VerMisSolicitudesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMisSolicitudesUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarGenSolicitud = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMisSolicitudes = new System.Windows.Forms.TabControl();
            this.tabSalientes = new System.Windows.Forms.TabPage();
            this.tabEntrantes = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaSolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOficinaSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSolicitudesEntrantes = new System.Windows.Forms.DataGridView();
            this.dgvMovimientoSolicitudEntrantes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).BeginInit();
            this.tabMisSolicitudes.SuspendLayout();
            this.tabSalientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesEntrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoSolicitudEntrantes)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(823, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarGenSolicitud
            // 
            this.btnCerrarGenSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarGenSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarGenSolicitud.Image")));
            this.btnCerrarGenSolicitud.Location = new System.Drawing.Point(780, 4);
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
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mis Solicitudes";
            // 
            // tabMisSolicitudes
            // 
            this.tabMisSolicitudes.Controls.Add(this.tabSalientes);
            this.tabMisSolicitudes.Controls.Add(this.tabEntrantes);
            this.tabMisSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMisSolicitudes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMisSolicitudes.Location = new System.Drawing.Point(0, 40);
            this.tabMisSolicitudes.Name = "tabMisSolicitudes";
            this.tabMisSolicitudes.SelectedIndex = 0;
            this.tabMisSolicitudes.Size = new System.Drawing.Size(823, 487);
            this.tabMisSolicitudes.TabIndex = 2;
            // 
            // tabSalientes
            // 
            this.tabSalientes.AutoScroll = true;
            this.tabSalientes.Controls.Add(this.dgvMovimientoSolicitudEntrantes);
            this.tabSalientes.Controls.Add(this.dgvSolicitudesEntrantes);
            this.tabSalientes.Controls.Add(this.txtAreaSolicitante);
            this.tabSalientes.Controls.Add(this.label5);
            this.tabSalientes.Controls.Add(this.txtOficinaSolicitante);
            this.tabSalientes.Controls.Add(this.label4);
            this.tabSalientes.Controls.Add(this.label2);
            this.tabSalientes.Location = new System.Drawing.Point(4, 26);
            this.tabSalientes.Name = "tabSalientes";
            this.tabSalientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalientes.Size = new System.Drawing.Size(815, 457);
            this.tabSalientes.TabIndex = 0;
            this.tabSalientes.Text = "Salientes";
            this.tabSalientes.UseVisualStyleBackColor = true;
            // 
            // tabEntrantes
            // 
            this.tabEntrantes.Location = new System.Drawing.Point(4, 26);
            this.tabEntrantes.Name = "tabEntrantes";
            this.tabEntrantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrantes.Size = new System.Drawing.Size(815, 457);
            this.tabEntrantes.TabIndex = 1;
            this.tabEntrantes.Text = "Entrantes";
            this.tabEntrantes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos del Solicitante";
            // 
            // txtAreaSolicitante
            // 
            this.txtAreaSolicitante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaSolicitante.Location = new System.Drawing.Point(121, 52);
            this.txtAreaSolicitante.Name = "txtAreaSolicitante";
            this.txtAreaSolicitante.Size = new System.Drawing.Size(657, 23);
            this.txtAreaSolicitante.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Área:";
            // 
            // txtOficinaSolicitante
            // 
            this.txtOficinaSolicitante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficinaSolicitante.Location = new System.Drawing.Point(121, 23);
            this.txtOficinaSolicitante.Name = "txtOficinaSolicitante";
            this.txtOficinaSolicitante.Size = new System.Drawing.Size(657, 23);
            this.txtOficinaSolicitante.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Oficina:";
            // 
            // dgvSolicitudesEntrantes
            // 
            this.dgvSolicitudesEntrantes.AllowUserToAddRows = false;
            this.dgvSolicitudesEntrantes.AllowUserToDeleteRows = false;
            this.dgvSolicitudesEntrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesEntrantes.Location = new System.Drawing.Point(10, 94);
            this.dgvSolicitudesEntrantes.Name = "dgvSolicitudesEntrantes";
            this.dgvSolicitudesEntrantes.ReadOnly = true;
            this.dgvSolicitudesEntrantes.Size = new System.Drawing.Size(768, 150);
            this.dgvSolicitudesEntrantes.TabIndex = 17;
            this.dgvSolicitudesEntrantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudesEntrantes_CellDoubleClick);
            // 
            // dgvMovimientoSolicitudEntrantes
            // 
            this.dgvMovimientoSolicitudEntrantes.AllowUserToAddRows = false;
            this.dgvMovimientoSolicitudEntrantes.AllowUserToDeleteRows = false;
            this.dgvMovimientoSolicitudEntrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientoSolicitudEntrantes.Location = new System.Drawing.Point(10, 276);
            this.dgvMovimientoSolicitudEntrantes.Name = "dgvMovimientoSolicitudEntrantes";
            this.dgvMovimientoSolicitudEntrantes.ReadOnly = true;
            this.dgvMovimientoSolicitudEntrantes.Size = new System.Drawing.Size(768, 101);
            this.dgvMovimientoSolicitudEntrantes.TabIndex = 18;
            // 
            // VerMisSolicitudesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 527);
            this.Controls.Add(this.tabMisSolicitudes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerMisSolicitudesUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerMisSolicitudesUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).EndInit();
            this.tabMisSolicitudes.ResumeLayout(false);
            this.tabSalientes.ResumeLayout(false);
            this.tabSalientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesEntrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoSolicitudEntrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarGenSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMisSolicitudes;
        private System.Windows.Forms.TabPage tabSalientes;
        private System.Windows.Forms.TabPage tabEntrantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAreaSolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOficinaSolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSolicitudesEntrantes;
        private System.Windows.Forms.DataGridView dgvMovimientoSolicitudEntrantes;
    }
}