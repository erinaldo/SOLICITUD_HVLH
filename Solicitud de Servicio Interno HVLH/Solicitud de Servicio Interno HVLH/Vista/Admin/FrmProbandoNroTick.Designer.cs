namespace Solicitud_de_Servicio_Interno_HVLH.Vista.Admin
{
    partial class FrmProbandoNroTick
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
            this.btnReadeR = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadeR
            // 
            this.btnReadeR.Location = new System.Drawing.Point(487, 22);
            this.btnReadeR.Name = "btnReadeR";
            this.btnReadeR.Size = new System.Drawing.Size(118, 78);
            this.btnReadeR.TabIndex = 0;
            this.btnReadeR.Text = "Reader";
            this.btnReadeR.UseVisualStyleBackColor = true;
            this.btnReadeR.Click += new System.EventHandler(this.btnReadeR_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(19, 22);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(450, 78);
            this.txtNum.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReadeR);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 441);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(74, 170);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(479, 100);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 2;
            // 
            // FrmProbandoNroTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 441);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProbandoNroTick";
            this.Text = "FrmProbandoNroTick";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadeR;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}