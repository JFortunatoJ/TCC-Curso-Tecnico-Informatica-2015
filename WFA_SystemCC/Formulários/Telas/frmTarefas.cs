using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SystemCC.Model;
using WFA_SystemCC.Dados.DataSet_TCCTableAdapters;

namespace WFA_SystemCC.Formulários
{
    public partial class frmTarefas : Form
    {
        public frmTarefas(int codUser)

        {
            codUsuario = codUser;
            InitializeComponent();
        }
        private int codUsuario;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefa tar = new Tarefa();
                tcc_TarefaTableAdapter taTarefa = new tcc_TarefaTableAdapter();
                tar.CodTarefa = (int)dgvTarefas.CurrentRow.Cells[0].Value;
                DialogResult a;
                a = MessageBox.Show("Confirmar exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    taTarefa.Delete(tar.CodTarefa);
                    MessageBox.Show("Tarefa Excluída!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTarefas_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int codUser;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefa tar = new Tarefa();
                tcc_TarefaTableAdapter taTarefa = new tcc_TarefaTableAdapter();

                if (btnIncluir.Text == "Salvar")
                {
                    tar.CodTarefa = (int)dgvTarefas.CurrentRow.Cells[0].Value;
                    tar.Titulo = txtTitulo.Text;
                    tar.Descricao = txtConteudo.Text;
                    tar.DataCriacao = DateTime.Now;
                    tar.CodUsuario = codUsuario;


                    taTarefa.Update(tar.CodUsuario, tar.Titulo, tar.Descricao, tar.DataCriacao.ToString(), tar.CodTarefa);
                    LimpaCampos();
                    frmTarefas_Load(sender, e);
                    btnIncluir.Text = "Incluir";
                }
                else
                {
                    frmLogin login = new frmLogin();
                    tar.Titulo = txtTitulo.Text;
                    tar.Descricao = txtConteudo.Text;
                    tar.DataCriacao = DateTime.Now;
                    tar.CodUsuario = codUsuario;

                    taTarefa.Insert(tar.CodUsuario, tar.Titulo, tar.Descricao, tar.DataCriacao);
                    LimpaCampos();
                    frmTarefas_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTarefas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Usuario' table. You can move, or remove it, as needed.
            this.tcc_UsuarioTableAdapter.Fill(this.dataSet_TCC.tcc_Usuario);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Tarefa' table. You can move, or remove it, as needed.
            this.tcc_TarefaTableAdapter.Fill(this.dataSet_TCC.tcc_Tarefa);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitulo.Text = dgvTarefas.CurrentRow.Cells[2].Value.ToString();
                txtConteudo.Text = dgvTarefas.CurrentRow.Cells[3].Value.ToString();

                btnIncluir.Text = "Salvar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpaCampos()
        {
            txtTitulo.Clear();
            txtConteudo.Clear();
        }
    }
}
