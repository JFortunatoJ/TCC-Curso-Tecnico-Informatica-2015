namespace WFA_SystemCC
{
    partial class frmControleEstoque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tccTipoMovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.tccItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccMovimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tcc_MovimentacaoTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_MovimentacaoTableAdapter();
            this.tcc_TipoMovTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_TipoMovTableAdapter();
            this.tcc_ItemTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter();
            this.codMovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTipoMovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMovimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMovDataGridViewTextBoxColumn,
            this.codTipoDataGridViewTextBoxColumn,
            this.codItemDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.dataMovDataGridViewTextBoxColumn,
            this.totalMovDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tccMovimentacaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(788, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // tccTipoMovBindingSource
            // 
            this.tccTipoMovBindingSource.DataMember = "tcc_TipoMov";
            this.tccTipoMovBindingSource.DataSource = this.dataSet_TCC;
            // 
            // dataSet_TCC
            // 
            this.dataSet_TCC.DataSetName = "DataSet_TCC";
            this.dataSet_TCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tccItemBindingSource
            // 
            this.tccItemBindingSource.DataMember = "tcc_Item";
            this.tccItemBindingSource.DataSource = this.dataSet_TCC;
            // 
            // tccMovimentacaoBindingSource
            // 
            this.tccMovimentacaoBindingSource.DataMember = "tcc_Movimentacao";
            this.tccMovimentacaoBindingSource.DataSource = this.dataSet_TCC;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(13, 13);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(16, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(218, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // tcc_MovimentacaoTableAdapter
            // 
            this.tcc_MovimentacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_TipoMovTableAdapter
            // 
            this.tcc_TipoMovTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_ItemTableAdapter
            // 
            this.tcc_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // codMovDataGridViewTextBoxColumn
            // 
            this.codMovDataGridViewTextBoxColumn.DataPropertyName = "codMov";
            this.codMovDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codMovDataGridViewTextBoxColumn.Name = "codMovDataGridViewTextBoxColumn";
            this.codMovDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMovDataGridViewTextBoxColumn.Width = 50;
            // 
            // codTipoDataGridViewTextBoxColumn
            // 
            this.codTipoDataGridViewTextBoxColumn.DataPropertyName = "codTipo";
            this.codTipoDataGridViewTextBoxColumn.DataSource = this.tccTipoMovBindingSource;
            this.codTipoDataGridViewTextBoxColumn.DisplayMember = "nome";
            this.codTipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.codTipoDataGridViewTextBoxColumn.Name = "codTipoDataGridViewTextBoxColumn";
            this.codTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codTipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codTipoDataGridViewTextBoxColumn.ValueMember = "codTipo";
            this.codTipoDataGridViewTextBoxColumn.Width = 75;
            // 
            // codItemDataGridViewTextBoxColumn
            // 
            this.codItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codItemDataGridViewTextBoxColumn.DataPropertyName = "codItem";
            this.codItemDataGridViewTextBoxColumn.DataSource = this.tccItemBindingSource;
            this.codItemDataGridViewTextBoxColumn.DisplayMember = "descricao";
            this.codItemDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.codItemDataGridViewTextBoxColumn.Name = "codItemDataGridViewTextBoxColumn";
            this.codItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.codItemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codItemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codItemDataGridViewTextBoxColumn.ValueMember = "codItem";
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            this.qtdDataGridViewTextBoxColumn.HeaderText = "Qtd";
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            this.qtdDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataMovDataGridViewTextBoxColumn
            // 
            this.dataMovDataGridViewTextBoxColumn.DataPropertyName = "DataMov";
            this.dataMovDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataMovDataGridViewTextBoxColumn.Name = "dataMovDataGridViewTextBoxColumn";
            this.dataMovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMovDataGridViewTextBoxColumn
            // 
            this.totalMovDataGridViewTextBoxColumn.DataPropertyName = "totalMov";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.totalMovDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalMovDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalMovDataGridViewTextBoxColumn.Name = "totalMovDataGridViewTextBoxColumn";
            this.totalMovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(812, 473);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmControleEstoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.frmControleEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTipoMovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccMovimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private Dados.DataSet_TCC dataSet_TCC;
        private Dados.DataSet_TCCTableAdapters.tcc_MovimentacaoTableAdapter tcc_MovimentacaoTableAdapter;
        private System.Windows.Forms.BindingSource tccMovimentacaoBindingSource;
        private System.Windows.Forms.BindingSource tccTipoMovBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_TipoMovTableAdapter tcc_TipoMovTableAdapter;
        private System.Windows.Forms.BindingSource tccItemBindingSource;
        private Dados.DataSet_TCCTableAdapters.tcc_ItemTableAdapter tcc_ItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMovDataGridViewTextBoxColumn;
    }
}