namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    partial class ConcluirSolicitudUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcluirSolicitudUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarConcluirTrabajo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMisSolicitudes = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnAddLista = new System.Windows.Forms.Button();
            this.txtListaPersonal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTrabajadorDesig = new System.Windows.Forms.DataGridView();
            this.txtBuscarPersonal_ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabMateriales = new System.Windows.Forms.TabPage();
            this.btnQuitarListarMateriales = new System.Windows.Forms.Button();
            this.dgvMaterialesAsignados = new System.Windows.Forms.DataGridView();
            this.txtUMSelected = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidadSelected = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemSelected = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.dgvItemsSIGA = new System.Windows.Forms.DataGridView();
            this.txtBuscarMateriales = new System.Windows.Forms.TextBox();
            this.lblBuscarMt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTicket_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiagnosticoPerso_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivoSolicitud_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOficinaAreaSolicita = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFinalizarTrabajo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarConcluirTrabajo)).BeginInit();
            this.tabMisSolicitudes.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadorDesig)).BeginInit();
            this.tabMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSIGA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnCerrarConcluirTrabajo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarConcluirTrabajo
            // 
            this.btnCerrarConcluirTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarConcluirTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarConcluirTrabajo.Image")));
            this.btnCerrarConcluirTrabajo.Location = new System.Drawing.Point(1043, 4);
            this.btnCerrarConcluirTrabajo.Name = "btnCerrarConcluirTrabajo";
            this.btnCerrarConcluirTrabajo.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarConcluirTrabajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarConcluirTrabajo.TabIndex = 2;
            this.btnCerrarConcluirTrabajo.TabStop = false;
            this.btnCerrarConcluirTrabajo.Click += new System.EventHandler(this.btnCerrarConcluirTrabajo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Concluir Trabajo";
            // 
            // tabMisSolicitudes
            // 
            this.tabMisSolicitudes.Controls.Add(this.tabPersonal);
            this.tabMisSolicitudes.Controls.Add(this.tabMateriales);
            this.tabMisSolicitudes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMisSolicitudes.Location = new System.Drawing.Point(5, 160);
            this.tabMisSolicitudes.Name = "tabMisSolicitudes";
            this.tabMisSolicitudes.SelectedIndex = 0;
            this.tabMisSolicitudes.Size = new System.Drawing.Size(1069, 367);
            this.tabMisSolicitudes.TabIndex = 3;
            // 
            // tabPersonal
            // 
            this.tabPersonal.AutoScroll = true;
            this.tabPersonal.Controls.Add(this.btnLimpiarLista);
            this.tabPersonal.Controls.Add(this.btnAddLista);
            this.tabPersonal.Controls.Add(this.txtListaPersonal);
            this.tabPersonal.Controls.Add(this.label7);
            this.tabPersonal.Controls.Add(this.dgvTrabajadorDesig);
            this.tabPersonal.Controls.Add(this.txtBuscarPersonal_);
            this.tabPersonal.Controls.Add(this.label8);
            this.tabPersonal.Location = new System.Drawing.Point(4, 26);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(1061, 337);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.FlatAppearance.BorderSize = 0;
            this.btnLimpiarLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLimpiarLista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarLista.Location = new System.Drawing.Point(831, 171);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(95, 23);
            this.btnLimpiarLista.TabIndex = 22;
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
            this.btnAddLista.Location = new System.Drawing.Point(802, 130);
            this.btnAddLista.Name = "btnAddLista";
            this.btnAddLista.Size = new System.Drawing.Size(134, 35);
            this.btnAddLista.TabIndex = 21;
            this.btnAddLista.Text = "Agregar a la Lista";
            this.btnAddLista.UseVisualStyleBackColor = true;
            this.btnAddLista.Click += new System.EventHandler(this.btnAddLista_Click);
            // 
            // txtListaPersonal
            // 
            this.txtListaPersonal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaPersonal.Location = new System.Drawing.Point(147, 130);
            this.txtListaPersonal.Multiline = true;
            this.txtListaPersonal.Name = "txtListaPersonal";
            this.txtListaPersonal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaPersonal.Size = new System.Drawing.Size(634, 89);
            this.txtListaPersonal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Personal Designado:";
            // 
            // dgvTrabajadorDesig
            // 
            this.dgvTrabajadorDesig.AllowUserToAddRows = false;
            this.dgvTrabajadorDesig.AllowUserToDeleteRows = false;
            this.dgvTrabajadorDesig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadorDesig.Location = new System.Drawing.Point(13, 33);
            this.dgvTrabajadorDesig.Name = "dgvTrabajadorDesig";
            this.dgvTrabajadorDesig.ReadOnly = true;
            this.dgvTrabajadorDesig.Size = new System.Drawing.Size(768, 91);
            this.dgvTrabajadorDesig.TabIndex = 18;
            // 
            // txtBuscarPersonal_
            // 
            this.txtBuscarPersonal_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPersonal_.Location = new System.Drawing.Point(233, 6);
            this.txtBuscarPersonal_.Name = "txtBuscarPersonal_";
            this.txtBuscarPersonal_.Size = new System.Drawing.Size(544, 21);
            this.txtBuscarPersonal_.TabIndex = 16;
            this.txtBuscarPersonal_.TextChanged += new System.EventHandler(this.txtBuscarPersonal__TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Buscar Personal por DNI o Nombres:";
            // 
            // tabMateriales
            // 
            this.tabMateriales.AutoScroll = true;
            this.tabMateriales.Controls.Add(this.btnQuitarListarMateriales);
            this.tabMateriales.Controls.Add(this.dgvMaterialesAsignados);
            this.tabMateriales.Controls.Add(this.txtUMSelected);
            this.tabMateriales.Controls.Add(this.label10);
            this.tabMateriales.Controls.Add(this.txtCantidadSelected);
            this.tabMateriales.Controls.Add(this.label9);
            this.tabMateriales.Controls.Add(this.txtItemSelected);
            this.tabMateriales.Controls.Add(this.label11);
            this.tabMateriales.Controls.Add(this.btnAddMateriales);
            this.tabMateriales.Controls.Add(this.dgvItemsSIGA);
            this.tabMateriales.Controls.Add(this.txtBuscarMateriales);
            this.tabMateriales.Controls.Add(this.lblBuscarMt);
            this.tabMateriales.Location = new System.Drawing.Point(4, 26);
            this.tabMateriales.Name = "tabMateriales";
            this.tabMateriales.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateriales.Size = new System.Drawing.Size(1061, 337);
            this.tabMateriales.TabIndex = 1;
            this.tabMateriales.Text = "Materiales";
            this.tabMateriales.UseVisualStyleBackColor = true;
            // 
            // btnQuitarListarMateriales
            // 
            this.btnQuitarListarMateriales.FlatAppearance.BorderSize = 0;
            this.btnQuitarListarMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnQuitarListarMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarListarMateriales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarListarMateriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuitarListarMateriales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuitarListarMateriales.Location = new System.Drawing.Point(902, 304);
            this.btnQuitarListarMateriales.Name = "btnQuitarListarMateriales";
            this.btnQuitarListarMateriales.Size = new System.Drawing.Size(134, 26);
            this.btnQuitarListarMateriales.TabIndex = 37;
            this.btnQuitarListarMateriales.Text = "Quitar de la Lista";
            this.btnQuitarListarMateriales.UseVisualStyleBackColor = true;
            this.btnQuitarListarMateriales.Click += new System.EventHandler(this.btnQuitarListarMateriales_Click);
            // 
            // dgvMaterialesAsignados
            // 
            this.dgvMaterialesAsignados.AllowUserToAddRows = false;
            this.dgvMaterialesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesAsignados.Location = new System.Drawing.Point(12, 148);
            this.dgvMaterialesAsignados.Name = "dgvMaterialesAsignados";
            this.dgvMaterialesAsignados.ReadOnly = true;
            this.dgvMaterialesAsignados.Size = new System.Drawing.Size(1024, 153);
            this.dgvMaterialesAsignados.TabIndex = 36;
            this.dgvMaterialesAsignados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialesAsignados_CellClick);
            this.dgvMaterialesAsignados.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMaterialesAsignados_CellPainting);
            // 
            // txtUMSelected
            // 
            this.txtUMSelected.Enabled = false;
            this.txtUMSelected.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMSelected.Location = new System.Drawing.Point(796, 62);
            this.txtUMSelected.Name = "txtUMSelected";
            this.txtUMSelected.Size = new System.Drawing.Size(110, 21);
            this.txtUMSelected.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(717, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "U. MEDIDA:";
            // 
            // txtCantidadSelected
            // 
            this.txtCantidadSelected.Enabled = false;
            this.txtCantidadSelected.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadSelected.Location = new System.Drawing.Point(798, 89);
            this.txtCantidadSelected.Name = "txtCantidadSelected";
            this.txtCantidadSelected.Size = new System.Drawing.Size(110, 21);
            this.txtCantidadSelected.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(716, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "CANTIDAD:";
            // 
            // txtItemSelected
            // 
            this.txtItemSelected.Enabled = false;
            this.txtItemSelected.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSelected.Location = new System.Drawing.Point(795, 33);
            this.txtItemSelected.Name = "txtItemSelected";
            this.txtItemSelected.Size = new System.Drawing.Size(110, 21);
            this.txtItemSelected.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(753, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "ITEM:";
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.FlatAppearance.BorderSize = 0;
            this.btnAddMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMateriales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMateriales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddMateriales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMateriales.Location = new System.Drawing.Point(924, 84);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(134, 26);
            this.btnAddMateriales.TabIndex = 29;
            this.btnAddMateriales.Text = "Agregar a la Lista";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            this.btnAddMateriales.Visible = false;
            this.btnAddMateriales.Click += new System.EventHandler(this.btnAddMateriales_Click);
            // 
            // dgvItemsSIGA
            // 
            this.dgvItemsSIGA.AllowUserToAddRows = false;
            this.dgvItemsSIGA.AllowUserToDeleteRows = false;
            this.dgvItemsSIGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsSIGA.Location = new System.Drawing.Point(12, 33);
            this.dgvItemsSIGA.Name = "dgvItemsSIGA";
            this.dgvItemsSIGA.ReadOnly = true;
            this.dgvItemsSIGA.Size = new System.Drawing.Size(685, 108);
            this.dgvItemsSIGA.TabIndex = 28;
            this.dgvItemsSIGA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsSIGA_CellClick);
            // 
            // txtBuscarMateriales
            // 
            this.txtBuscarMateriales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMateriales.Location = new System.Drawing.Point(128, 6);
            this.txtBuscarMateriales.Name = "txtBuscarMateriales";
            this.txtBuscarMateriales.Size = new System.Drawing.Size(569, 21);
            this.txtBuscarMateriales.TabIndex = 27;
            this.txtBuscarMateriales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMateriales_KeyPress);
            // 
            // lblBuscarMt
            // 
            this.lblBuscarMt.AutoSize = true;
            this.lblBuscarMt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarMt.Location = new System.Drawing.Point(9, 9);
            this.lblBuscarMt.Name = "lblBuscarMt";
            this.lblBuscarMt.Size = new System.Drawing.Size(116, 17);
            this.lblBuscarMt.TabIndex = 26;
            this.lblBuscarMt.Text = "Buscar Materiales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resumen del trabajo:";
            // 
            // txtNumTicket_
            // 
            this.txtNumTicket_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTicket_.Location = new System.Drawing.Point(271, 43);
            this.txtNumTicket_.Name = "txtNumTicket_";
            this.txtNumTicket_.Size = new System.Drawing.Size(171, 21);
            this.txtNumTicket_.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(173, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nº Atención:";
            // 
            // txtDiagnosticoPerso_
            // 
            this.txtDiagnosticoPerso_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosticoPerso_.Location = new System.Drawing.Point(110, 114);
            this.txtDiagnosticoPerso_.Multiline = true;
            this.txtDiagnosticoPerso_.Name = "txtDiagnosticoPerso_";
            this.txtDiagnosticoPerso_.Size = new System.Drawing.Size(964, 40);
            this.txtDiagnosticoPerso_.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "Diagnóstico Personal:";
            // 
            // txtMotivoSolicitud_
            // 
            this.txtMotivoSolicitud_.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoSolicitud_.Location = new System.Drawing.Point(110, 71);
            this.txtMotivoSolicitud_.Multiline = true;
            this.txtMotivoSolicitud_.Name = "txtMotivoSolicitud_";
            this.txtMotivoSolicitud_.ReadOnly = true;
            this.txtMotivoSolicitud_.Size = new System.Drawing.Size(964, 41);
            this.txtMotivoSolicitud_.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 41);
            this.label5.TabIndex = 24;
            this.label5.Text = "Motivo Solicitud:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(460, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Oficina Solicitante:";
            // 
            // txtOficinaAreaSolicita
            // 
            this.txtOficinaAreaSolicita.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficinaAreaSolicita.Location = new System.Drawing.Point(602, 43);
            this.txtOficinaAreaSolicita.Name = "txtOficinaAreaSolicita";
            this.txtOficinaAreaSolicita.Size = new System.Drawing.Size(472, 21);
            this.txtOficinaAreaSolicita.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 10);
            this.panel2.TabIndex = 30;
            // 
            // btnFinalizarTrabajo
            // 
            this.btnFinalizarTrabajo.FlatAppearance.BorderSize = 0;
            this.btnFinalizarTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFinalizarTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarTrabajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFinalizarTrabajo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarTrabajo.Location = new System.Drawing.Point(9, 529);
            this.btnFinalizarTrabajo.Name = "btnFinalizarTrabajo";
            this.btnFinalizarTrabajo.Size = new System.Drawing.Size(175, 39);
            this.btnFinalizarTrabajo.TabIndex = 31;
            this.btnFinalizarTrabajo.Text = "Finalizar Trabajo";
            this.btnFinalizarTrabajo.UseVisualStyleBackColor = true;
            this.btnFinalizarTrabajo.Click += new System.EventHandler(this.btnFinalizarTrabajo_Click);
            // 
            // ConcluirSolicitudUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 584);
            this.Controls.Add(this.btnFinalizarTrabajo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtOficinaAreaSolicita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnosticoPerso_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivoSolicitud_);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumTicket_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabMisSolicitudes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConcluirSolicitudUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConcluirSolicitudUser";
            this.Load += new System.EventHandler(this.ConcluirSolicitudUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarConcluirTrabajo)).EndInit();
            this.tabMisSolicitudes.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadorDesig)).EndInit();
            this.tabMateriales.ResumeLayout(false);
            this.tabMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsSIGA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarConcluirTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabMisSolicitudes;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.TabPage tabMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumTicket_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiagnosticoPerso_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivoSolicitud_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOficinaAreaSolicita;
        private System.Windows.Forms.TextBox txtBuscarPersonal_;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTrabajadorDesig;
        private System.Windows.Forms.TextBox txtListaPersonal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnAddLista;
        private System.Windows.Forms.TextBox txtUMSelected;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidadSelected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemSelected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.DataGridView dgvItemsSIGA;
        private System.Windows.Forms.TextBox txtBuscarMateriales;
        private System.Windows.Forms.Label lblBuscarMt;
        private System.Windows.Forms.Button btnQuitarListarMateriales;
        private System.Windows.Forms.DataGridView dgvMaterialesAsignados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFinalizarTrabajo;
    }
}