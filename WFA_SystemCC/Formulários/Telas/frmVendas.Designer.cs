namespace WFA_SystemCC.Formulários
{
    partial class frmVendas
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
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnRegistroVendas = new System.Windows.Forms.Button();
            this.txtProdCod = new System.Windows.Forms.TextBox();
            this.btnProdIncluir = new System.Windows.Forms.Button();
            this.btnAlterarQuantidade = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.codItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.tccItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQTD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtProdPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQTD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEncerrar.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(854, 147);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(101, 45);
            this.btnEncerrar.TabIndex = 1;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnRegistroVendas
            // 
            this.btnRegistroVendas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroVendas.Location = new System.Drawing.Point(858, 9);
            this.btnRegistroVendas.Name = "btnRegistroVendas";
            this.btnRegistroVendas.Size = new System.Drawing.Size(97, 43);
            this.btnRegistroVendas.TabIndex = 2;
            this.btnRegistroVendas.Text = "Registro de Vendas";
            this.btnRegistroVendas.UseVisualStyleBackColor = true;
            this.btnRegistroVendas.Click += new System.EventHandler(this.btnRegistroVendas_Click);
            // 
            // txtProdCod
            // 
            this.txtProdCod.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtProdCod.Location = new System.Drawing.Point(12, 30);
            this.txtProdCod.Multiline = true;
            this.txtProdCod.Name = "txtProdCod";
            this.txtProdCod.Size = new System.Drawing.Size(149, 26);
            this.txtProdCod.TabIndex = 3;
            this.txtProdCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCod_KeyDown);
            this.txtProdCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdCod_KeyPress);
            // 
            // btnProdIncluir
            // 
            this.btnProdIncluir.BackColor = System.Drawing.Color.LightGreen;
            this.btnProdIncluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnProdIncluir.ForeColor = System.Drawing.Color.White;
            this.btnProdIncluir.Image = global::WFA_SystemCC.Properties.Resources.incluir;
            this.btnProdIncluir.Location = new System.Drawing.Point(597, 24);
            this.btnProdIncluir.Name = "btnProdIncluir";
            this.btnProdIncluir.Size = new System.Drawing.Size(159, 37);
            this.btnProdIncluir.TabIndex = 16;
            this.btnProdIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProdIncluir.UseVisualStyleBackColor = false;
            this.btnProdIncluir.Click += new System.EventHandler(this.btnProdIncluir_Click);
            // 
            // btnAlterarQuantidade
            // 
            this.btnAlterarQuantidade.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAlterarQuantidade.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarQuantidade.Location = new System.Drawing.Point(125, 158);
            this.btnAlterarQuantidade.Name = "btnAlterarQuantidade";
            this.btnAlterarQuantidade.Size = new System.Drawing.Size(145, 34);
            this.btnAlterarQuantidade.TabIndex = 17;
            this.btnAlterarQuantidade.Text = "Alterar Quantidade";
            this.btnAlterarQuantidade.UseVisualStyleBackColor = false;
            this.btnAlterarQuantidade.Click += new System.EventHandler(this.btnAlterarQuantidade_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::WFA_SystemCC.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(12, 158);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 34);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AllowUserToAddRows = false;
            this.dgvItensVenda.AllowUserToDeleteRows = false;
            this.dgvItensVenda.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codItem,
            this.nome,
            this.qtd,
            this.precoUnit,
            this.subtotal});
            this.dgvItensVenda.Location = new System.Drawing.Point(16, 198);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.Size = new System.Drawing.Size(939, 338);
            this.dgvItensVenda.TabIndex = 20;
            this.dgvItensVenda.Click += new System.EventHandler(this.dgvItensVenda_Click);
            // 
            // codItem
            // 
            this.codItem.HeaderText = "Código";
            this.codItem.Name = "codItem";
            this.codItem.ReadOnly = true;
            this.codItem.Width = 75;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 50;
            // 
            // precoUnit
            // 
            this.precoUnit.HeaderText = "Preço Unitário";
            this.precoUnit.Name = "precoUnit";
            this.precoUnit.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome do Produto:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataSource = this.tccItemBindingSource;
            this.cmbProduto.DisplayMember = "descricao";
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(167, 30);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(243, 26);
            this.cmbProduto.TabIndex = 23;
            this.cmbProduto.ValueMember = "codItem";
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // tccItemBindingSource
            // 
            this.tccItemBindingSource.DataMember = "tcc_Item";
            this.tccItemBindingSource.DataSource = this.dataSet_TCC;
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_ItemTableAdapter
            // 
            this.tcc_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantidade:";
            // 
            // nudQTD
            // 
            this.nudQTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQTD.Location = new System.Drawing.Point(12, 91);
            this.nudQTD.Name = "nudQTD";
            this.nudQTD.Size = new System.Drawing.Size(84, 26);
            this.nudQTD.TabIndex = 25;
            this.nudQTD.ValueChanged += new System.EventHandler(this.nudQTD_ValueChanged);
            this.nudQTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudQTD_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Preço do Produto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(118, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Subtotal:";
            // 
            // txtProdTotal
            // 
            this.txtProdTotal.Enabled = false;
            this.txtProdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTotal.Location = new System.Drawing.Point(125, 91);
            this.txtProdTotal.Name = "txtProdTotal";
            this.txtProdTotal.Size = new System.Drawing.Size(175, 24);
            this.txtProdTotal.TabIndex = 28;
            // 
            // txtProdPreco
            // 
            this.txtProdPreco.Enabled = false;
            this.txtProdPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPreco.Location = new System.Drawing.Point(416, 30);
            this.txtProdPreco.Name = "txtProdPreco";
            this.txtProdPreco.Size = new System.Drawing.Size(175, 24);
            this.txtProdPreco.TabIndex = 29;
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.Enabled = false;
            this.txtTotalVenda.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenda.Location = new System.Drawing.Point(657, 147);
            this.txtTotalVenda.Multiline = true;
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(191, 45);
            this.txtTotalVenda.TabIndex = 0;
            this.txtTotalVenda.Text = "0";
            this.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(967, 546);
            this.Controls.Add(this.txtProdPreco);
            this.Controls.Add(this.txtProdTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQTD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItensVenda);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterarQuantidade);
            this.Controls.Add(this.btnProdIncluir);
            this.Controls.Add(this.txtProdCod);
            this.Controls.Add(this.btnRegistroVendas);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.txtTotalVenda);
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnRegistroVendas;
        private System.Windows.Forms.TextBox txtProdCod;
        private System.Windows.Forms.Button btnProdIncluir;
        private System.Windows.Forms.Button btnAlterarQuantidade;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProduto;
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource tccItemBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.MaskedTextBox txtProdTotal;
        private System.Windows.Forms.MaskedTextBox txtProdPreco;
        private System.Windows.Forms.TextBox txtTotalVenda;
    }
}