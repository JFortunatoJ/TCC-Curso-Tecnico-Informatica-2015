namespace WFA_SystemCC
{
    partial class frmProdutos
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tccItemCategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tccFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcc_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.tableAdapterManager = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager();
            this.tccItemCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemCategoriaTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter();
            this.tcc_FornecedorTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter();
            this.cmbPesquisa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.LightGreen;
            this.btnIncluir.Image = global::WFA_SystemCC.Properties.Resources.incluir;
            this.btnIncluir.Location = new System.Drawing.Point(1034, 30);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(101, 34);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir Novo";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar por:";
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Location = new System.Drawing.Point(16, 38);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(218, 20);
            this.txtPesquisaProduto.TabIndex = 3;
            this.txtPesquisaProduto.TextChanged += new System.EventHandler(this.txtPesquisaProduto_TextChanged);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nome,
            this.categoria,
            this.qtd,
            this.precoUnit,
            this.taxa,
            this.fornecedor,
            this.obs});
            this.dgvProdutos.DataSource = this.tcc_ItemBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(16, 70);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(1119, 432);
            this.dgvProdutos.TabIndex = 4;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codItem";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "descricao";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "codCategoria";
            this.categoria.DataSource = this.tccItemCategoriaBindingSource1;
            this.categoria.DisplayMember = "nomeCategoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoria.ValueMember = "codCategoria";
            this.categoria.Width = 150;
            // 
            // tccItemCategoriaBindingSource1
            // 
            this.tccItemCategoriaBindingSource1.DataMember = "tcc_ItemCategoria";
            this.tccItemCategoriaBindingSource1.DataSource = this.dataSet_TCC;
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "Qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 50;
            // 
            // precoUnit
            // 
            this.precoUnit.DataPropertyName = "precoUnit";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precoUnit.DefaultCellStyle = dataGridViewCellStyle1;
            this.precoUnit.HeaderText = "Preço Unitário";
            this.precoUnit.Name = "precoUnit";
            this.precoUnit.ReadOnly = true;
            // 
            // taxa
            // 
            this.taxa.DataPropertyName = "taxaLucro";
            this.taxa.HeaderText = "Taxa Lucro";
            this.taxa.Name = "taxa";
            this.taxa.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "codFornecedor";
            this.fornecedor.DataSource = this.tccFornecedorBindingSource;
            this.fornecedor.DisplayMember = "nome";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fornecedor.ValueMember = "codFornecedor";
            this.fornecedor.Width = 150;
            // 
            // tccFornecedorBindingSource
            // 
            this.tccFornecedorBindingSource.DataMember = "tcc_Fornecedor";
            this.tccFornecedorBindingSource.DataSource = this.dataSet_TCC;
            // 
            // obs
            // 
            this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // tcc_ItemBindingSource
            // 
            this.tcc_ItemBindingSource.DataMember = "tcc_Item";
            this.tcc_ItemBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tccItemBindingSource
            // 
            this.tccItemBindingSource.DataMember = "tcc_Item";
            // 
            // tcc_ItemTableAdapter
            // 
            this.tcc_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_FornecedorTableAdapter = null;
            this.tableAdapterManager.tcc_ItemCategoriaTableAdapter = null;
            this.tableAdapterManager.tcc_ItemTableAdapter = this.tcc_ItemTableAdapter;
            this.tableAdapterManager.tcc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.tcc_MovimentacaoTableAdapter = null;
            this.tableAdapterManager.tcc_TarefaTableAdapter = null;
            this.tableAdapterManager.tcc_TipoMovTableAdapter = null;
            this.tableAdapterManager.tcc_UsuarioTableAdapter = null;
            this.tableAdapterManager.tcc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tccItemCategoriaBindingSource
            // 
            this.tccItemCategoriaBindingSource.DataMember = "tcc_ItemCategoria";
            this.tccItemCategoriaBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tcc_ItemCategoriaTableAdapter
            // 
            this.tcc_ItemCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_FornecedorTableAdapter
            // 
            this.tcc_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbPesquisa.Location = new System.Drawing.Point(93, 10);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cmbPesquisa.TabIndex = 5;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ordenar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.AutoCompleteCustomSource.AddRange(new string[] {
            "Maior Preço",
            "Menor Preço"});
            this.cmbOrdenar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOrdenar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Maior Preço",
            "Menor Preço"});
            this.cmbOrdenar.Location = new System.Drawing.Point(309, 10);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 7;
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1147, 514);
            this.Controls.Add(this.cmbOrdenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPesquisa);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque de Produtos";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource tcc_ItemBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private Dados.DataSet_TCCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tccItemBindingSource;
        private System.Windows.Forms.BindingSource tccItemCategoriaBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter tcc_ItemCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource tccFornecedorBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter tcc_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource tccItemCategoriaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxa;
        private System.Windows.Forms.DataGridViewComboBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ComboBox cmbPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrdenar;
    }
}

