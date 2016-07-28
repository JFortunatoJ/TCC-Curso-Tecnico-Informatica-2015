using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SystemCC.Dados.DataSet_TCCTableAdapters;
//using WFA_SystemCC.Dados.DataSet_TCC_EscolaTableAdapters;
using WFA_SystemCC.Model;

namespace WFA_SystemCC.Formulários.Cadastros
{
    public partial class frmCadCategoria : Form
    {
        public frmCadCategoria()
        {
            InitializeComponent();
        }

        Categoria cat = new Categoria();
        tcc_ItemCategoriaTableAdapter taCategoria = new tcc_ItemCategoriaTableAdapter();

        private bool CaixasOk()
        {
            if (txtNome.Text == "")
            {
                errErro.SetError(txtNome, "Informar o Nome");
                return false;
            }
            else
            {
                errErro.SetError(txtNome, "");
            }
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCadastrar.Text == "Alterar")
                {
                    HabilitaComponentes();
                    txtNome.Focus();
                    btnExcluir.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                }
                else if (btnCadastrar.Text == "Cadastrar")
                {
                    if (CaixasOk())
                    {
                        cat.Nome = txtNome.Text.ToString();

                        taCategoria.Insert(cat.Nome);
                        MessageBox.Show("Categoria Cadastrada", "Cadastro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (btnCadastrar.Text == "Salvar")
                {
                    cat.Codcategoria = Convert.ToInt16(lblCodigo.Text);
                    cat.Nome = txtNome.Text;

                    taCategoria.Update(cat.Nome, cat.Codcategoria);
                    MessageBox.Show("Alterações Salvas", "Alteração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                cat.Codcategoria = Convert.ToInt16(lblCodigo.Text);
                cat.Nome = txtNome.Text;

                DialogResult a;
                a = MessageBox.Show("Confirmar exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    taCategoria.Delete(cat.Codcategoria);
                    MessageBox.Show("Categoria Excluída", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        public void HabilitaComponentes()
        {
            txtNome.Enabled = true;
        }
    }
}
