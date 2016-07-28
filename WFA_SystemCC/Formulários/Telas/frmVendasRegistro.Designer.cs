namespace WFA_SystemCC.Formulários
{
    partial class frmVendasRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.codVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tccUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tccVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletarVenda = new System.Windows.Forms.Button();
            this.tcc_VendaTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_VendaTableAdapter();
            this.tcc_UsuarioTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_UsuarioTableAdapter();
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.tccItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.codItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).BeginInit();
            this.gbVendas.SuspendLayout();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVendaDataGridViewTextBoxColumn,
            this.codUsuarioDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.totalVendaDataGridViewTextBoxColumn});
            this.dgvVendas.DataSource = this.tccVendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(6, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(403, 516);
            this.dgvVendas.TabIndex = 0;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            this.dgvVendas.Click += new System.EventHandler(this.dgvVendas_Click);
            // 
            // codVendaDataGridViewTextBoxColumn
            // 
            this.codVendaDataGridViewTextBoxColumn.DataPropertyName = "codVenda";
            this.codVendaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codVendaDataGridViewTextBoxColumn.Name = "codVendaDataGridViewTextBoxColumn";
            this.codVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVendaDataGridViewTextBoxColumn.Width = 50;
            // 
            // codUsuarioDataGridViewTextBoxColumn
            // 
            this.codUsuarioDataGridViewTextBoxColumn.DataPropertyName = "codUsuario";
            this.codUsuarioDataGridViewTextBoxColumn.DataSource = this.tccUsuarioBindingSource;
            this.codUsuarioDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.codUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.codUsuarioDataGridViewTextBoxColumn.Name = "codUsuarioDataGridViewTextBoxColumn";
            this.codUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codUsuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codUsuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codUsuarioDataGridViewTextBoxColumn.ValueMember = "codUsuario";
            // 
            // tccUsuarioBindingSource
            // 
            this.tccUsuarioBindingSource.DataMember = "tcc_Usuario";
            this.tccUsuarioBindingSource.DataSource = this.dataSet_TCC;
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "dataVenda";
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            this.totalVendaDataGridViewTextBoxColumn.DataPropertyName = "totalVenda";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalVendaDataGridViewTextBoxColumn.HeaderText = "Total da Venda";
            this.totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            this.totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalVendaDataGridViewTextBoxColumn.Width = 110;
            // 
            // tccVendaBindingSource
            // 
            this.tccVendaBindingSource.DataMember = "tcc_Venda";
            this.tccVendaBindingSource.DataSource = this.dataSet_TCC;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnVoltar.Image = global::WFA_SystemCC.Properties.Resources.seta_voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 34);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDeletarVenda
            // 
            this.btnDeletarVenda.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletarVenda.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnDeletarVenda.ForeColor = System.Drawing.Color.White;
            this.btnDeletarVenda.Image = global::WFA_SystemCC.Properties.Resources.excluir;
            this.btnDeletarVenda.Location = new System.Drawing.Point(258, 12);
            this.btnDeletarVenda.Name = "btnDeletarVenda";
            this.btnDeletarVenda.Size = new System.Drawing.Size(172, 34);
            this.btnDeletarVenda.TabIndex = 4;
            this.btnDeletarVenda.Text = "Deletar Venda";
            this.btnDeletarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletarVenda.UseVisualStyleBackColor = false;
            this.btnDeletarVenda.Click += new System.EventHandler(this.btnDeletarVenda_Click);
            // 
            // tcc_VendaTableAdapter
            // 
            this.tcc_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_UsuarioTableAdapter
            // 
            this.tcc_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // gbVendas
            // 
            this.gbVendas.Controls.Add(this.dgvVendas);
            this.gbVendas.Location = new System.Drawing.Point(13, 52);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(417, 501);
            this.gbVendas.TabIndex = 5;
            this.gbVendas.TabStop = false;
            this.gbVendas.Text = "Vendas";
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.dgvItemVenda);
            this.gbItens.Location = new System.Drawing.Point(437, 52);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(527, 501);
            this.gbItens.TabIndex = 6;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens da Venda";
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AllowUserToAddRows = false;
            this.dgvItemVenda.AllowUserToDeleteRows = false;
            this.dgvItemVenda.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codItem,
            this.produto,
            this.qtd,
            this.subtotal});
            this.dgvItemVenda.Location = new System.Drawing.Point(16, 20);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.ReadOnly = true;
            this.dgvItemVenda.Size = new System.Drawing.Size(508, 475);
            this.dgvItemVenda.TabIndex = 0;
            // 
            // tccItemBindingSource
            // 
            this.tccItemBindingSource.DataMember = "tcc_Item";
            this.tccItemBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tcc_ItemTableAdapter
            // 
            this.tcc_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // codItem
            // 
            this.codItem.HeaderText = "Código";
            this.codItem.Name = "codItem";
            this.codItem.ReadOnly = true;
            this.codItem.Width = 50;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.DataSource = this.tccItemBindingSource;
            this.produto.DisplayMember = "descricao";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.produto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.produto.ValueMember = "codItem";
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 50;
            // 
            // subtotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // frmVendasRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(973, 565);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.btnDeletarVenda);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmVendasRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vendas";
            this.Load += new System.EventHandler(this.frmVendasRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccVendaBindingSource)).EndInit();
            this.gbVendas.ResumeLayout(false);
            this.gbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletarVenda;
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource tccVendaBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_VendaTableAdapter tcc_VendaTableAdapter;
        private System.Windows.Forms.BindingSource tccUsuarioBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_UsuarioTableAdapter tcc_UsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.BindingSource tccItemBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}