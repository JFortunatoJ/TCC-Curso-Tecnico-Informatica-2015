namespace WFA_SystemCC.Formulários
{
    partial class frmTarefas
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
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.tccUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_TCC = new WFA_SystemCC.Dados.DataSet_TCC();
            this.tccTarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tcc_TarefaTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_TarefaTableAdapter();
            this.tcc_UsuarioTableAdapter = new WFA_SystemCC.Dados.DataSet_TCCTableAdapters.tcc_UsuarioTableAdapter();
            this.codTarefaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTarefaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.AutoGenerateColumns = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTarefaDataGridViewTextBoxColumn,
            this.codUsuarioDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn});
            this.dgvTarefas.DataSource = this.tccTarefaBindingSource;
            this.dgvTarefas.Location = new System.Drawing.Point(204, 50);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(793, 378);
            this.dgvTarefas.TabIndex = 0;
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
            // tccTarefaBindingSource
            // 
            this.tccTarefaBindingSource.DataMember = "tcc_Tarefa";
            this.tccTarefaBindingSource.DataSource = this.dataSet_TCC;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conteúdo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(15, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(183, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(15, 78);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(183, 301);
            this.txtConteudo.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnEditar.Location = new System.Drawing.Point(204, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 32);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnExcluir.Image = global::WFA_SystemCC.Properties.Resources.excluir;
            this.btnExcluir.Location = new System.Drawing.Point(905, 16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 32);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.LightGreen;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 10.25F);
            this.btnIncluir.Image = global::WFA_SystemCC.Properties.Resources.incluir;
            this.btnIncluir.Location = new System.Drawing.Point(15, 385);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(183, 43);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tcc_TarefaTableAdapter
            // 
            this.tcc_TarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tcc_UsuarioTableAdapter
            // 
            this.tcc_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // codTarefaDataGridViewTextBoxColumn
            // 
            this.codTarefaDataGridViewTextBoxColumn.DataPropertyName = "codTarefa";
            this.codTarefaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codTarefaDataGridViewTextBoxColumn.Name = "codTarefaDataGridViewTextBoxColumn";
            this.codTarefaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTarefaDataGridViewTextBoxColumn.Width = 50;
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
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "dataCriacao";
            dataGridViewCellStyle1.NullValue = null;
            this.dataCriacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1009, 440);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTarefas);
            this.Name = "frmTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.frmTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_TCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccTarefaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private Dados.DataSet_TCC dataSet_TCC;
        private Dados.DataSet_TCCTableAdapters.tcc_TarefaTableAdapter tcc_TarefaTableAdapter;
        private Dados.DataSet_TCCTableAdapters.tcc_UsuarioTableAdapter tcc_UsuarioTableAdapter;
        private System.Windows.Forms.BindingSource tccUsuarioBindingSource;
        private System.Windows.Forms.BindingSource tccTarefaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTarefaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
    }
}