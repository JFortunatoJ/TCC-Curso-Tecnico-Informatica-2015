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
//using WFA_SystemCC.Dados.DataSet_TCC_EscolaTableAdapters;
using WFA_SystemCC.Dados;

namespace WFA_SystemCC
{
    public partial class frmCadFornecedor : Form
    {
        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        Fornecedor forn = new Fornecedor();
        tcc_FornecedorTableAdapter taFornecedor = new tcc_FornecedorTableAdapter();
        frmFornecedor frmforn = new frmFornecedor();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcc_FornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.tcc_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_TCC);*/

        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Fornecedor' table. You can move, or remove it, as needed.
            // this.tcc_FornecedorTableAdapter.Fill(this.dataSet_TCC.tcc_Fornecedor);
            txtNome.Focus();
        }

        private bool CaixasOK()
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
            if (txtTelefone.Text == "")
            {
                errErro.SetError(txtTelefone, "Informar o Telefone");
                return false;
            }
            else
            {
                errErro.SetError(txtTelefone, "");
            }
            if (txtEndereco.Text == "")
            {
                errErro.SetError(txtEndereco, "Informar o Endereço");
                return false;
            }
            else
            {
                errErro.SetError(txtEndereco, "");
            }
            if (txtEmail.Text == "")
            {
                errErro.SetError(txtEmail, "Informar o E-Mail");
                return false;
            }
            else
            {
                errErro.SetError(txtEmail, "");
            }
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Alterar")
            {
                HabilitaComponentes();
                txtNome.Focus();
                btnSalvar.Text = "Salvar";
            }
            else if (btnSalvar.Text == "Cadastrar")
            {
                try
                {
                    if (CaixasOK())
                    {
                        forn.Nome = txtNome.Text;
                        string tel = txtTelefone.Text;
                        //txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        forn.Telefone = tel;
                        forn.Endereco = txtEndereco.Text;
                        forn.Email = txtEmail.Text;

                        taFornecedor.Insert(forn.Nome, forn.Telefone, forn.Endereco, forn.Email);
                        MessageBox.Show("Fornecedor Cadastrado!", "Cadastro", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            else if (btnSalvar.Text == "Salvar")
            {
                try
                {
                    forn.CodFornecedor = Convert.ToInt16(lblCodigo.Text);
                    forn.Nome = txtNome.Text;
                    //txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    forn.Telefone = txtTelefone.Text.ToString();
                    forn.Endereco = txtEndereco.Text;
                    forn.Email = txtEmail.Text;

                    taFornecedor.Update(forn.Nome, forn.Telefone, forn.Endereco, forn.Email, forn.CodFornecedor);
                    MessageBox.Show("Fornecedor Alterado!", "Alteração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        public void HabilitaComponentes()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
        }

        public void LimpaCampos()
        {
            txtNome.Text = null;
            txtEndereco.Text = null;
            txtTelefone.Text = null;
            txtEmail.Text = null;
            txtNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                forn.CodFornecedor = Convert.ToInt16(lblCodigo.Text);
                DialogResult a;
                a = MessageBox.Show("Confirmar exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    taFornecedor.Delete(forn.CodFornecedor);
                    MessageBox.Show("Fornecedor Excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
