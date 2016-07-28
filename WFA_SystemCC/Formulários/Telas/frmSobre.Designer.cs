namespace WFA_SystemCC
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtSobre = new System.Windows.Forms.TextBox();
            this.txtpap = new System.Windows.Forms.TextBox();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(145, 287);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtSobre
            // 
            this.txtSobre.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtSobre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSobre.Enabled = false;
            this.txtSobre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobre.ForeColor = System.Drawing.Color.White;
            this.txtSobre.Location = new System.Drawing.Point(12, 55);
            this.txtSobre.Multiline = true;
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.Size = new System.Drawing.Size(334, 131);
            this.txtSobre.TabIndex = 0;
            this.txtSobre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpap
            // 
            this.txtpap.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtpap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpap.Enabled = false;
            this.txtpap.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpap.ForeColor = System.Drawing.Color.Black;
            this.txtpap.Location = new System.Drawing.Point(12, 192);
            this.txtpap.Name = "txtpap";
            this.txtpap.Size = new System.Drawing.Size(334, 22);
            this.txtpap.TabIndex = 2;
            this.txtpap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVersao
            // 
            this.txtVersao.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtVersao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVersao.Enabled = false;
            this.txtVersao.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersao.ForeColor = System.Drawing.Color.White;
            this.txtVersao.Location = new System.Drawing.Point(12, 231);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(334, 22);
            this.txtVersao.TabIndex = 3;
            this.txtVersao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(358, 322);
            this.Controls.Add(this.txtVersao);
            this.Controls.Add(this.txtpap);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtSobre;
        private System.Windows.Forms.TextBox txtpap;
        private System.Windows.Forms.TextBox txtVersao;
    }
}