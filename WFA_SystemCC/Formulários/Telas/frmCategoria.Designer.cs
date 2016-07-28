namespace WFA_SystemCC.Formulários.Cadastros
{
    partial class frmCategoria
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
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.tcc_ItemCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_ItemCategoriaTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter();
            this.tableAdapterManager = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluirN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc_ItemCategoriaBindingSource
            // 
            this.tcc_ItemCategoriaBindingSource.DataMember = "tcc_ItemCategoria";
            this.tcc_ItemCategoriaBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tcc_ItemCategoriaTableAdapter
            // 
            this.tcc_ItemCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tcc_FornecedorTableAdapter = null;
            this.tableAdapterManager.tcc_ItemCategoriaTableAdapter = this.tcc_ItemCategoriaTableAdapter;
            this.tableAdapterManager.tcc_ItemTableAdapter = null;
            this.tableAdapterManager.tcc_ItemVendaTableAdapter = null;
            this.tableAdapterManager.tcc_MovimentacaoTableAdapter = null;
            this.tableAdapterManager.tcc_TarefaTableAdapter = null;
            this.tableAdapterManager.tcc_TipoMovTableAdapter = null;
            this.tableAdapterManager.tcc_UsuarioTableAdapter = null;
            this.tableAdapterManager.tcc_VendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFA_SystemCC.Dados.DataSet_TCCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AutoGenerateColumns = false;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCategoria.DataSource = this.tcc_ItemCategoriaBindingSource;
            this.dgvCategoria.Location = new System.Drawing.Point(12, 55);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(428, 210);
            this.dgvCategoria.TabIndex = 5;
            this.dgvCategoria.DoubleClick += new System.EventHandler(this.dgvCategoria_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codCategoria";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCategoria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnIncluirN
            // 
            this.btnIncluirN.BackColor = System.Drawing.Color.LightGreen;
            this.btnIncluirN.Image = global::WFA_SystemCC.Properties.Resources.incluir;
            this.btnIncluirN.Location = new System.Drawing.Point(342, 12);
            this.btnIncluirN.Name = "btnIncluirN";
            this.btnIncluirN.Size = new System.Drawing.Size(98, 37);
            this.btnIncluirN.TabIndex = 6;
            this.btnIncluirN.Text = "Incluir Novo";
            this.btnIncluirN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluirN.UseVisualStyleBackColor = false;
            this.btnIncluirN.Click += new System.EventHandler(this.btnIncluirN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(15, 29);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(166, 20);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(452, 275);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIncluirN);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCadCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_ItemCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados.DataSet_TCC dataSet_TCC;
        private System.Windows.Forms.BindingSource tcc_ItemCategoriaBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemCategoriaTableAdapter tcc_ItemCategoriaTableAdapter;
        private Dados.DataSet_TCCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnIncluirN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}