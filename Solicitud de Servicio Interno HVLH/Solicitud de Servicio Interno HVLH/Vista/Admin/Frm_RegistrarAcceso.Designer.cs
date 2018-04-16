namespace Solicitud_de_Servicio_Interno_HVLH.Vista.Admin
{
    partial class Frm_RegistrarAcceso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusquedaTrabajador = new System.Windows.Forms.TextBox();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboTipoAccess = new System.Windows.Forms.ComboBox();
            this.cboOficinaAccess = new System.Windows.Forms.ComboBox();
            this.txtContrasenaAccess = new System.Windows.Forms.TextBox();
            this.txtUsuarioAccess = new System.Windows.Forms.TextBox();
            this.txtNombresAccess = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DNI o Nombres del Trabajador:";
            // 
            // txtBusquedaTrabajador
            // 
            this.txtBusquedaTrabajador.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaTrabajador.Location = new System.Drawing.Point(335, 18);
            this.txtBusquedaTrabajador.Name = "txtBusquedaTrabajador";
            this.txtBusquedaTrabajador.Size = new System.Drawing.Size(532, 31);
            this.txtBusquedaTrabajador.TabIndex = 1;
            this.txtBusquedaTrabajador.TextChanged += new System.EventHandler(this.txtBusquedaTrabajador_TextChanged);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.AllowUserToAddRows = false;
            this.dgvTrabajadores.AllowUserToDeleteRows = false;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Location = new System.Drawing.Point(109, 55);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.ReadOnly = true;
            this.dgvTrabajadores.Size = new System.Drawing.Size(742, 127);
            this.dgvTrabajadores.TabIndex = 2;
            this.dgvTrabajadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.cboTipoAccess);
            this.panel1.Controls.Add(this.cboOficinaAccess);
            this.panel1.Controls.Add(this.txtContrasenaAccess);
            this.panel1.Controls.Add(this.txtUsuarioAccess);
            this.panel1.Controls.Add(this.txtNombresAccess);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 203);
            this.panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(720, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 44);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(524, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(178, 44);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboTipoAccess
            // 
            this.cboTipoAccess.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoAccess.FormattingEnabled = true;
            this.cboTipoAccess.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cboTipoAccess.Location = new System.Drawing.Point(207, 148);
            this.cboTipoAccess.Name = "cboTipoAccess";
            this.cboTipoAccess.Size = new System.Drawing.Size(141, 24);
            this.cboTipoAccess.Sorted = true;
            this.cboTipoAccess.TabIndex = 10;
            // 
            // cboOficinaAccess
            // 
            this.cboOficinaAccess.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOficinaAccess.FormattingEnabled = true;
            this.cboOficinaAccess.Location = new System.Drawing.Point(207, 114);
            this.cboOficinaAccess.Name = "cboOficinaAccess";
            this.cboOficinaAccess.Size = new System.Drawing.Size(495, 24);
            this.cboOficinaAccess.TabIndex = 9;
            // 
            // txtContrasenaAccess
            // 
            this.txtContrasenaAccess.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaAccess.Location = new System.Drawing.Point(207, 78);
            this.txtContrasenaAccess.Name = "txtContrasenaAccess";
            this.txtContrasenaAccess.Size = new System.Drawing.Size(274, 27);
            this.txtContrasenaAccess.TabIndex = 8;
            this.txtContrasenaAccess.UseSystemPasswordChar = true;
            // 
            // txtUsuarioAccess
            // 
            this.txtUsuarioAccess.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioAccess.Location = new System.Drawing.Point(207, 46);
            this.txtUsuarioAccess.Name = "txtUsuarioAccess";
            this.txtUsuarioAccess.Size = new System.Drawing.Size(274, 27);
            this.txtUsuarioAccess.TabIndex = 7;
            // 
            // txtNombresAccess
            // 
            this.txtNombresAccess.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresAccess.Location = new System.Drawing.Point(207, 12);
            this.txtNombresAccess.Name = "txtNombresAccess";
            this.txtNombresAccess.Size = new System.Drawing.Size(630, 27);
            this.txtNombresAccess.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo de Acceso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Oficina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "DATOS DE ACCESO";
            // 
            // Frm_RegistrarAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTrabajadores);
            this.Controls.Add(this.txtBusquedaTrabajador);
            this.Controls.Add(this.label1);
            this.Name = "Frm_RegistrarAcceso";
            this.Text = "Frm_RegistrarAcceso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusquedaTrabajador;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboTipoAccess;
        private System.Windows.Forms.ComboBox cboOficinaAccess;
        private System.Windows.Forms.TextBox txtContrasenaAccess;
        private System.Windows.Forms.TextBox txtUsuarioAccess;
        private System.Windows.Forms.TextBox txtNombresAccess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}