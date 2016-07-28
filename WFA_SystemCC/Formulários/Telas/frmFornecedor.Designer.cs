namespace WFA_SystemCC
{
    partial class frmFornecedor
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
            this.fkItemFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.gbComponentes = new System.Windows.Forms.GroupBox();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluirNovo = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tccFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcc_FornecedorTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter();
            this.tableAdapterManager = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager();

            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.tcc_FornecedorTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter();
            this.cmbPesquisar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fkItemFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_FornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            this.gbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();

            this.SuspendLayout();
            // 
            // fkItemFornecedorBindingSource
            // 
            this.fkItemFornecedorBindingSource.DataMember = "Fk_Item_Fornecedor";
            this.fkItemFornecedorBindingSource.DataSource = this.tcc_FornecedorBindingSource;
            // 
            // tcc_FornecedorBindingSource
            // 
            this.tcc_FornecedorBindingSource.DataMember = "tcc_Fornecedor";
            this.tcc_FornecedorBindingSource.DataSource = this.dataSet_TCC;
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbComponentes
            // 
            this.gbComponentes.Controls.Add(this.cmbPesquisar);
            this.gbComponentes.Controls.Add(this.dgvFornecedor);
            this.gbComponentes.Controls.Add(this.btnIncluirNovo);
            this.gbComponentes.Controls.Add(this.txtPesquisar);
            this.gbComponentes.Controls.Add(this.label1);
            this.gbComponentes.Location = new System.Drawing.Point(12, 12);
            this.gbComponentes.Name = "gbComponentes";
            this.gbComponentes.Size = new System.Drawing.Size(866, 485);
            this.gbComponentes.TabIndex = 8;
            this.gbComponentes.TabStop = false;
            this.gbComponentes.Text = "Fornecedores";
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToOrderColumns = true;
            this.dgvFornecedor.AllowUserToResizeColumns = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.AutoGenerateColumns = false;
            this.dgvFornecedor.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.telefone,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvFornecedor.DataSource = this.tcc_FornecedorBindingSource;
            this.dgvFornecedor.Location = new System.Drawing.Point(5, 74);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.Size = new System.Drawing.Size(850, 405);
            this.dgvFornecedor.TabIndex = 14;
            this.dgvFornecedor.DoubleClick += new System.EventHandler(this.dgvFornecedor_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codFornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.MaxInputLength = 99999;
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnIncluirNovo
            // 
            this.btnIncluirNovo.BackColor = System.Drawing.Color.LightGreen;
            this.btnIncluirNovo.Image = global::WFA_SystemCC.Properties.Resources.incluir;
            this.btnIncluirNovo.Location = new System.Drawing.Point(758, 33);
            this.btnIncluirNovo.Name = "btnIncluirNovo";
            this.btnIncluirNovo.Size = new System.Drawing.Size(97, 35);
            this.btnIncluirNovo.TabIndex = 11;
            this.btnIncluirNovo.Text = "Incluir Novo";
            this.btnIncluirNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluirNovo.UseVisualStyleBackColor = false;
            this.btnIncluirNovo.Click += new System.EventHandler(this.btnIncluirNovo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(9, 48);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(218, 20);
            this.txtPesquisar.TabIndex = 9;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisar";
            // 
            // tccFornecedorBindingSource
            // 
            this.tccFornecedorBindingSource.DataMember = "tcc_Fornecedor";
            
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // tcc_FornecedorTableAdapter
            // 
            this.tcc_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_FornecedorTableAdapter = this.tcc_FornecedorTableAdapter;
            this.tableAdapterManager.tcc_ItemCategoriaTableAdapter = null;
            this.tableAdapterManager.tcc_ItemTableAdapter = null;
            this.tableAdapterManager.tcc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.tcc_MovimentacaoTableAdapter = null;
            this.tableAdapterManager.tcc_TarefaTableAdapter = null;
            this.tableAdapterManager.tcc_TipoMovTableAdapter = null;
            this.tableAdapterManager.tcc_UsuarioTableAdapter = null;
            this.tableAdapterManager.tcc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tcc_EstoqueBindingSource
            // 


            // 
            // tcc_EstoqueTableAdapter
            // 
            // 
            // tcc_ItemTableAdapter
            // 
            this.tcc_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_FornecedorTableAdapter1
            // 
            // 
            // cmbPesquisar
            // 
            this.cmbPesquisar.FormattingEnabled = true;
            this.cmbPesquisar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cmbPesquisar.Location = new System.Drawing.Point(65, 18);
            this.cmbPesquisar.Name = "cmbPesquisar";
            this.cmbPesquisar.Size = new System.Drawing.Size(121, 21);
            this.cmbPesquisar.TabIndex = 15;
            this.cmbPesquisar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(889, 509);
            this.Controls.Add(this.gbComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFornecedor";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fkItemFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_FornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            this.gbComponentes.ResumeLayout(false);
            this.gbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource fkItemFornecedorBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private System.Windows.Forms.GroupBox gbComponentes;
        private System.Windows.Forms.Button btnIncluirNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errErro;
        public System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.BindingSource tcc_FornecedorBindingSource;
        public Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter tcc_FornecedorTableAdapter;
        public Dados.DataSet_TCCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tccFornecedorBindingSource;
        private System.Windows.Forms.ComboBox cmbPesquisar;
    }
}