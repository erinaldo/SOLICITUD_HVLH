namespace Solicitud_de_Servicio_Interno_HVLH.Vista.User
{
    partial class VerMaterialesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMaterialesUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarVerMateriales = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaterialesAsignados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVerMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnCerrarVerMateriales);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnCerrarVerMateriales
            // 
            this.btnCerrarVerMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVerMateriales.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVerMateriales.Image")));
            this.btnCerrarVerMateriales.Location = new System.Drawing.Point(857, 4);
            this.btnCerrarVerMateriales.Name = "btnCerrarVerMateriales";
            this.btnCerrarVerMateriales.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarVerMateriales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVerMateriales.TabIndex = 2;
            this.btnCerrarVerMateriales.TabStop = false;
            this.btnCerrarVerMateriales.Click += new System.EventHandler(this.btnCerrarVerMateriales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materiales";
            // 
            // dgvMaterialesAsignados
            // 
            this.dgvMaterialesAsignados.AllowUserToAddRows = false;
            this.dgvMaterialesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialesAsignados.Location = new System.Drawing.Point(12, 112);
            this.dgvMaterialesAsignados.Name = "dgvMaterialesAsignados";
            this.dgvMaterialesAsignados.ReadOnly = true;
            this.dgvMaterialesAsignados.Size = new System.Drawing.Size(876, 261);
            this.dgvMaterialesAsignados.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Lista de Materiales:";
            // 
            // VerMaterialesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMaterialesAsignados);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerMaterialesUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerMaterialesUser";
            this.Load += new System.EventHandler(this.VerMaterialesUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVerMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialesAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarVerMateriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaterialesAsignados;
        private System.Windows.Forms.Label label2;
    }
}