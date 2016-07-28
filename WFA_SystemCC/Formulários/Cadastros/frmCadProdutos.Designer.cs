namespace WFA_SystemCC
{
    partial class frmCadProdutos
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
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label qtdLabel;
            System.Windows.Forms.Label precoUnitLabel;
            System.Windows.Forms.Label taxaLucroLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label codFornecedorLabel;
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.tcc_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.tableAdapterManager = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtNomePro = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoUnit = new System.Windows.Forms.MaskedTextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.tccFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_FornecedorTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter();
            this.fkItemFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.tccItemCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemCategoriaTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tccItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkItemCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tipoLabel = new System.Windows.Forms.Label();
            qtdLabel = new System.Windows.Forms.Label();
            precoUnitLabel = new System.Windows.Forms.Label();
            taxaLucroLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            codFornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkItemFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkItemCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(45, 66);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(55, 13);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "Categoria:";
            // 
            // qtdLabel
            // 
            qtdLabel.AutoSize = true;
            qtdLabel.Location = new System.Drawing.Point(35, 93);
            qtdLabel.Name = "qtdLabel";
            qtdLabel.Size = new System.Drawing.Size(65, 13);
            qtdLabel.TabIndex = 11;
            qtdLabel.Text = "Quantidade:";
            // 
            // precoUnitLabel
            // 
            precoUnitLabel.AutoSize = true;
            precoUnitLabel.Location = new System.Drawing.Point(23, 119);
            precoUnitLabel.Name = "precoUnitLabel";
            precoUnitLabel.Size = new System.Drawing.Size(77, 13);
            precoUnitLabel.TabIndex = 13;
            precoUnitLabel.Text = "Preço Unitário:";
            // 
            // taxaLucroLabel
            // 
            taxaLucroLabel.AutoSize = true;
            taxaLucroLabel.Location = new System.Drawing.Point(21, 145);
            taxaLucroLabel.Name = "taxaLucroLabel";
            taxaLucroLabel.Size = new System.Drawing.Size(79, 13);
            taxaLucroLabel.TabIndex = 15;
            taxaLucroLabel.Text = "Taxa de Lucro:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(62, 41);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(38, 13);
            descricaoLabel.TabIndex = 17;
            descricaoLabel.Text = "Nome:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(71, 206);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 19;
            obsLabel.Text = "Obs:";
            // 
            // codFornecedorLabel
            // 
            codFornecedorLabel.AutoSize = true;
            codFornecedorLabel.Location = new System.Drawing.Point(36, 171);
            codFornecedorLabel.Name = "codFornecedorLabel";
            codFornecedorLabel.Size = new System.Drawing.Size(64, 13);
            codFornecedorLabel.TabIndex = 21;
            codFornecedorLabel.Text = "Fornecedor:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Image = global::WFA_SystemCC.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(253, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 33);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Image = global::WFA_SystemCC.Properties.Resources.cadastro;
            this.btnSalvar.Location = new System.Drawing.Point(335, 328);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Image = global::WFA_SystemCC.Properties.Resources.seta_voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 335);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 33);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseCompatibleTextRendering = true;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_ItemBindingSource
            // 
            this.tcc_ItemBindingSource.DataMember = "tcc_Item";
            this.tcc_ItemBindingSource.DataSource = this.dataSet_TCC;
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
            // txtTaxa
            // 
            this.txtTaxa.Enabled = false;
            this.txtTaxa.Location = new System.Drawing.Point(106, 142);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(78, 20);
            this.txtTaxa.TabIndex = 16;
            // 
            // txtNomePro
            // 
            this.txtNomePro.Enabled = false;
            this.txtNomePro.Location = new System.Drawing.Point(106, 38);
            this.txtNomePro.Name = "txtNomePro";
            this.txtNomePro.Size = new System.Drawing.Size(316, 20);
            this.txtNomePro.TabIndex = 18;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(106, 203);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(316, 102);
            this.txtObs.TabIndex = 20;
            // 
            // nudQtd
            // 
            this.nudQtd.Enabled = false;
            this.nudQtd.Location = new System.Drawing.Point(106, 91);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(61, 20);
            this.nudQtd.TabIndex = 23;
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(106, 117);
            this.txtPrecoUnit.Mask = "$ 999,999.00";
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(78, 20);
            this.txtPrecoUnit.TabIndex = 24;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DataSource = this.tccFornecedorBindingSource;
            this.cmbFornecedor.DisplayMember = "nome";
            this.cmbFornecedor.Enabled = false;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(106, 168);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(316, 21);
            this.cmbFornecedor.TabIndex = 25;
            this.cmbFornecedor.ValueMember = "codFornecedor";
            // 
            // tccFornecedorBindingSource
            // 
            this.tccFornecedorBindingSource.DataMember = "tcc_Fornecedor";
            this.tccFornecedorBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tcc_FornecedorTableAdapter
            // 
            this.tcc_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // fkItemFornecedorBindingSource
            // 
            this.fkItemFornecedorBindingSource.DataMember = "Fk_Item_Fornecedor";
            this.fkItemFornecedorBindingSource.DataSource = this.tccFornecedorBindingSource;
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.tccItemCategoriaBindingSource;
            this.cmbCategoria.DisplayMember = "nomeCategoria";
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(107, 66);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(155, 21);
            this.cmbCategoria.TabIndex = 26;
            this.cmbCategoria.ValueMember = "codCategoria";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(106, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 28;
            // 
            // tccItemBindingSource
            // 
            this.tccItemBindingSource.DataMember = "tcc_Item";
            this.tccItemBindingSource.DataSource = this.dataSet_TCC;
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(433, 380);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.nudQtd);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(qtdLabel);
            this.Controls.Add(precoUnitLabel);
            this.Controls.Add(taxaLucroLabel);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtNomePro);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(codFornecedorLabel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkItemFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkItemCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource tcc_ItemBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private Dados.DataSet_TCCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tccFornecedorBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_FornecedorTableAdapter tcc_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource fkItemFornecedorBindingSource;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.BindingSource tccItemCategoriaBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter tcc_ItemCategoriaTableAdapter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtTaxa;
        public System.Windows.Forms.TextBox txtNomePro;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.NumericUpDown nudQtd;
        public System.Windows.Forms.MaskedTextBox txtPrecoUnit;
        public System.Windows.Forms.ComboBox cmbFornecedor;
        public System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.BindingSource tccItemBindingSource;
        private System.Windows.Forms.BindingSource fkItemCategoriaBindingSource;
    }
}