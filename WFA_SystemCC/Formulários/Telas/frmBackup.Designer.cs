namespace WFA_SystemCC
{
    partial class frmBackup
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
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.btnRecuperaBackup = new System.Windows.Forms.Button();
            this.btnCriaBackup = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gbAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.btnRecuperaBackup);
            this.gbAcoes.Controls.Add(this.btnCriaBackup);
            this.gbAcoes.Location = new System.Drawing.Point(12, 12);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(142, 84);
            this.gbAcoes.TabIndex = 1;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // btnRecuperaBackup
            // 
            this.btnRecuperaBackup.Location = new System.Drawing.Point(6, 50);
            this.btnRecuperaBackup.Name = "btnRecuperaBackup";
            this.btnRecuperaBackup.Size = new System.Drawing.Size(130, 23);
            this.btnRecuperaBackup.TabIndex = 1;
            this.btnRecuperaBackup.Text = "Recuperar Backup";
            this.btnRecuperaBackup.UseVisualStyleBackColor = true;
            this.btnRecuperaBackup.Click += new System.EventHandler(this.btnRecuperaBackup_Click);
            // 
            // btnCriaBackup
            // 
            this.btnCriaBackup.Location = new System.Drawing.Point(6, 21);
            this.btnCriaBackup.Name = "btnCriaBackup";
            this.btnCriaBackup.Size = new System.Drawing.Size(130, 23);
            this.btnCriaBackup.TabIndex = 0;
            this.btnCriaBackup.Text = "Criar Backup";
            this.btnCriaBackup.UseVisualStyleBackColor = true;
            this.btnCriaBackup.Click += new System.EventHandler(this.btnCriaBackup_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 102);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(166, 134);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gbAcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.gbAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.Button btnRecuperaBackup;
        private System.Windows.Forms.Button btnCriaBackup;
        private System.Windows.Forms.Button btnVoltar;
    }
}