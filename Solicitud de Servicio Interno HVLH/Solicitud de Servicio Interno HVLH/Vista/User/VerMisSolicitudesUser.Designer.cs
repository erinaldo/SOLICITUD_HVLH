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
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnSaliente_AnularSoli = new System.Windows.Forms.Button();
            this.btnSaliente_CambiarEstado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiagnosticoPersonalExtend = new System.Windows.Forms.TextBox();
            this.txtPersonalDesigExtend = new System.Windows.Forms.TextBox();
            this.txtMotivoExtend = new System.Windows.Forms.TextBox();
            this.dgvMovimientoSolicitudSalientes = new System.Windows.Forms.DataGridView();
            this.dgvSolicitudesSalientes = new System.Windows.Forms.DataGridView();
            this.txtAreaSolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOficinaSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEntrantes = new System.Windows.Forms.TabPage();
            this.panelBotonesEntrantes = new System.Windows.Forms.Panel();
            this.btnAnularSoliEntrante = new System.Windows.Forms.Button();
            this.btnCambiarEstadoSolicitudEntrante = new System.Windows.Forms.Button();
            this.dgvMovSoliEntrante = new System.Windows.Forms.DataGridView();
            this.dgvSolicitudesEntrantes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGenSolicitud)).BeginInit();
            this.tabMisSolicitudes.SuspendLayout();
            this.tabSalientes.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoSolicitudSalientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesSalientes)).BeginInit();
            this.tabEntrantes.SuspendLayout();
            this.panelBotonesEntrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovSoliEntrante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesEntrantes)).BeginInit();
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
            this.tabSalientes.Controls.Add(this.panelBotones);
            this.tabSalientes.Controls.Add(this.label7);
            this.tabSalientes.Controls.Add(this.label6);
            this.tabSalientes.Controls.Add(this.label3);
            this.tabSalientes.Controls.Add(this.txtDiagnosticoPersonalExtend);
            this.tabSalientes.Controls.Add(this.txtPersonalDesigExtend);
            this.tabSalientes.Controls.Add(this.txtMotivoExtend);
            this.tabSalientes.Controls.Add(this.dgvMovimientoSolicitudSalientes);
            this.tabSalientes.Controls.Add(this.dgvSolicitudesSalientes);
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
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnSaliente_AnularSoli);
            this.panelBotones.Controls.Add(this.btnSaliente_CambiarEstado);
            this.panelBotones.Location = new System.Drawing.Point(15, 325);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(616, 56);
            this.panelBotones.TabIndex = 25;
            // 
            // btnSaliente_AnularSoli
            // 
            this.btnSaliente_AnularSoli.FlatAppearance.BorderSize = 0;
            this.btnSaliente_AnularSoli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaliente_AnularSoli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaliente_AnularSoli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaliente_AnularSoli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaliente_AnularSoli.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaliente_AnularSoli.Location = new System.Drawing.Point(151, 3);
            this.btnSaliente_AnularSoli.Name = "btnSaliente_AnularSoli";
            this.btnSaliente_AnularSoli.Size = new System.Drawing.Size(134, 51);
            this.btnSaliente_AnularSoli.TabIndex = 5;
            this.btnSaliente_AnularSoli.Text = "Anular Solicitud";
            this.btnSaliente_AnularSoli.UseVisualStyleBackColor = true;
            this.btnSaliente_AnularSoli.Visible = false;
            // 
            // btnSaliente_CambiarEstado
            // 
            this.btnSaliente_CambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnSaliente_CambiarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaliente_CambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaliente_CambiarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaliente_CambiarEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaliente_CambiarEstado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaliente_CambiarEstado.Location = new System.Drawing.Point(-1, 3);
            this.btnSaliente_CambiarEstado.Name = "btnSaliente_CambiarEstado";
            this.btnSaliente_CambiarEstado.Size = new System.Drawing.Size(134, 51);
            this.btnSaliente_CambiarEstado.TabIndex = 4;
            this.btnSaliente_CambiarEstado.Text = "Evaluar Solicitud";
            this.btnSaliente_CambiarEstado.UseVisualStyleBackColor = true;
            this.btnSaliente_CambiarEstado.Visible = false;
            this.btnSaliente_CambiarEstado.Click += new System.EventHandler(this.btnSaliente_CambiarEstado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(28, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Diagnóstico P:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(28, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "P. Designado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Motivo:";
            // 
            // txtDiagnosticoPersonalExtend
            // 
            this.txtDiagnosticoPersonalExtend.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosticoPersonalExtend.Location = new System.Drawing.Point(137, 479);
            this.txtDiagnosticoPersonalExtend.Multiline = true;
            this.txtDiagnosticoPersonalExtend.Name = "txtDiagnosticoPersonalExtend";
            this.txtDiagnosticoPersonalExtend.Size = new System.Drawing.Size(641, 40);
            this.txtDiagnosticoPersonalExtend.TabIndex = 21;
            // 
            // txtPersonalDesigExtend
            // 
            this.txtPersonalDesigExtend.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalDesigExtend.Location = new System.Drawing.Point(137, 431);
            this.txtPersonalDesigExtend.Multiline = true;
            this.txtPersonalDesigExtend.Name = "txtPersonalDesigExtend";
            this.txtPersonalDesigExtend.Size = new System.Drawing.Size(641, 40);
            this.txtPersonalDesigExtend.TabIndex = 20;
            // 
            // txtMotivoExtend
            // 
            this.txtMotivoExtend.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoExtend.Location = new System.Drawing.Point(137, 387);
            this.txtMotivoExtend.Multiline = true;
            this.txtMotivoExtend.Name = "txtMotivoExtend";
            this.txtMotivoExtend.Size = new System.Drawing.Size(641, 40);
            this.txtMotivoExtend.TabIndex = 19;
            // 
            // dgvMovimientoSolicitudSalientes
            // 
            this.dgvMovimientoSolicitudSalientes.AllowUserToAddRows = false;
            this.dgvMovimientoSolicitudSalientes.AllowUserToDeleteRows = false;
            this.dgvMovimientoSolicitudSalientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientoSolicitudSalientes.Location = new System.Drawing.Point(15, 219);
            this.dgvMovimientoSolicitudSalientes.Name = "dgvMovimientoSolicitudSalientes";
            this.dgvMovimientoSolicitudSalientes.ReadOnly = true;
            this.dgvMovimientoSolicitudSalientes.Size = new System.Drawing.Size(768, 101);
            this.dgvMovimientoSolicitudSalientes.TabIndex = 18;
            this.dgvMovimientoSolicitudSalientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientoSolicitudEntrantes_CellDoubleClick);
            // 
            // dgvSolicitudesSalientes
            // 
            this.dgvSolicitudesSalientes.AllowUserToAddRows = false;
            this.dgvSolicitudesSalientes.AllowUserToDeleteRows = false;
            this.dgvSolicitudesSalientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesSalientes.Location = new System.Drawing.Point(15, 78);
            this.dgvSolicitudesSalientes.Name = "dgvSolicitudesSalientes";
            this.dgvSolicitudesSalientes.ReadOnly = true;
            this.dgvSolicitudesSalientes.Size = new System.Drawing.Size(768, 121);
            this.dgvSolicitudesSalientes.TabIndex = 17;
            this.dgvSolicitudesSalientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudesEntrantes_CellDoubleClick);
            // 
            // txtAreaSolicitante
            // 
            this.txtAreaSolicitante.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaSolicitante.Location = new System.Drawing.Point(121, 52);
            this.txtAreaSolicitante.Name = "txtAreaSolicitante";
            this.txtAreaSolicitante.Size = new System.Drawing.Size(657, 21);
            this.txtAreaSolicitante.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Área:";
            // 
            // txtOficinaSolicitante
            // 
            this.txtOficinaSolicitante.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficinaSolicitante.Location = new System.Drawing.Point(121, 23);
            this.txtOficinaSolicitante.Name = "txtOficinaSolicitante";
            this.txtOficinaSolicitante.Size = new System.Drawing.Size(657, 21);
            this.txtOficinaSolicitante.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Oficina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos del Solicitante";
            // 
            // tabEntrantes
            // 
            this.tabEntrantes.AutoScroll = true;
            this.tabEntrantes.Controls.Add(this.panelBotonesEntrantes);
            this.tabEntrantes.Controls.Add(this.dgvMovSoliEntrante);
            this.tabEntrantes.Controls.Add(this.dgvSolicitudesEntrantes);
            this.tabEntrantes.Location = new System.Drawing.Point(4, 26);
            this.tabEntrantes.Name = "tabEntrantes";
            this.tabEntrantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrantes.Size = new System.Drawing.Size(815, 457);
            this.tabEntrantes.TabIndex = 1;
            this.tabEntrantes.Text = "Entrantes";
            this.tabEntrantes.UseVisualStyleBackColor = true;
            // 
            // panelBotonesEntrantes
            // 
            this.panelBotonesEntrantes.Controls.Add(this.btnAnularSoliEntrante);
            this.panelBotonesEntrantes.Controls.Add(this.btnCambiarEstadoSolicitudEntrante);
            this.panelBotonesEntrantes.Location = new System.Drawing.Point(36, 296);
            this.panelBotonesEntrantes.Name = "panelBotonesEntrantes";
            this.panelBotonesEntrantes.Size = new System.Drawing.Size(393, 56);
            this.panelBotonesEntrantes.TabIndex = 26;
            // 
            // btnAnularSoliEntrante
            // 
            this.btnAnularSoliEntrante.FlatAppearance.BorderSize = 0;
            this.btnAnularSoliEntrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnularSoliEntrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularSoliEntrante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularSoliEntrante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnularSoliEntrante.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnularSoliEntrante.Location = new System.Drawing.Point(172, 3);
            this.btnAnularSoliEntrante.Name = "btnAnularSoliEntrante";
            this.btnAnularSoliEntrante.Size = new System.Drawing.Size(134, 51);
            this.btnAnularSoliEntrante.TabIndex = 5;
            this.btnAnularSoliEntrante.Text = "Anular Solicitud";
            this.btnAnularSoliEntrante.UseVisualStyleBackColor = true;
            this.btnAnularSoliEntrante.Visible = false;
            // 
            // btnCambiarEstadoSolicitudEntrante
            // 
            this.btnCambiarEstadoSolicitudEntrante.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstadoSolicitudEntrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCambiarEstadoSolicitudEntrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstadoSolicitudEntrante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoSolicitudEntrante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCambiarEstadoSolicitudEntrante.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarEstadoSolicitudEntrante.Location = new System.Drawing.Point(-1, 3);
            this.btnCambiarEstadoSolicitudEntrante.Name = "btnCambiarEstadoSolicitudEntrante";
            this.btnCambiarEstadoSolicitudEntrante.Size = new System.Drawing.Size(134, 51);
            this.btnCambiarEstadoSolicitudEntrante.TabIndex = 4;
            this.btnCambiarEstadoSolicitudEntrante.Text = "Evaluar Solicitud";
            this.btnCambiarEstadoSolicitudEntrante.UseVisualStyleBackColor = true;
            this.btnCambiarEstadoSolicitudEntrante.Visible = false;
            this.btnCambiarEstadoSolicitudEntrante.Click += new System.EventHandler(this.btnCambiarEstadoSolicitudEntrante_Click);
            // 
            // dgvMovSoliEntrante
            // 
            this.dgvMovSoliEntrante.AllowUserToAddRows = false;
            this.dgvMovSoliEntrante.AllowUserToDeleteRows = false;
            this.dgvMovSoliEntrante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovSoliEntrante.Location = new System.Drawing.Point(26, 172);
            this.dgvMovSoliEntrante.Name = "dgvMovSoliEntrante";
            this.dgvMovSoliEntrante.ReadOnly = true;
            this.dgvMovSoliEntrante.Size = new System.Drawing.Size(768, 101);
            this.dgvMovSoliEntrante.TabIndex = 19;
            this.dgvMovSoliEntrante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovSoliEntrante_CellDoubleClick);
            // 
            // dgvSolicitudesEntrantes
            // 
            this.dgvSolicitudesEntrantes.AllowUserToAddRows = false;
            this.dgvSolicitudesEntrantes.AllowUserToDeleteRows = false;
            this.dgvSolicitudesEntrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudesEntrantes.Location = new System.Drawing.Point(6, 22);
            this.dgvSolicitudesEntrantes.Name = "dgvSolicitudesEntrantes";
            this.dgvSolicitudesEntrantes.ReadOnly = true;
            this.dgvSolicitudesEntrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudesEntrantes.Size = new System.Drawing.Size(799, 121);
            this.dgvSolicitudesEntrantes.TabIndex = 18;
            this.dgvSolicitudesEntrantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudesEntrantes_CellDoubleClick_1);
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
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientoSolicitudSalientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesSalientes)).EndInit();
            this.tabEntrantes.ResumeLayout(false);
            this.panelBotonesEntrantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovSoliEntrante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudesEntrantes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSolicitudesSalientes;
        private System.Windows.Forms.DataGridView dgvMovimientoSolicitudSalientes;
        private System.Windows.Forms.TextBox txtDiagnosticoPersonalExtend;
        private System.Windows.Forms.TextBox txtPersonalDesigExtend;
        private System.Windows.Forms.TextBox txtMotivoExtend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnSaliente_CambiarEstado;
        private System.Windows.Forms.Button btnSaliente_AnularSoli;
        private System.Windows.Forms.DataGridView dgvSolicitudesEntrantes;
        private System.Windows.Forms.DataGridView dgvMovSoliEntrante;
        private System.Windows.Forms.Panel panelBotonesEntrantes;
        private System.Windows.Forms.Button btnAnularSoliEntrante;
        private System.Windows.Forms.Button btnCambiarEstadoSolicitudEntrante;
    }
}