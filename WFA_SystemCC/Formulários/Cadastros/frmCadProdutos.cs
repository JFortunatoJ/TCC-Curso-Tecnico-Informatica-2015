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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        Item item = new Item();
        tcc_ItemTableAdapter taProduto = new tcc_ItemTableAdapter();
        tcc_MovimentacaoTableAdapter taMov = new tcc_MovimentacaoTableAdapter();
        DataSet_TCC ds = new DataSet_TCC();
        public int cate, forn;


        private void adicionaProduto()
        {
            item.Descricao = txtNomePro.Text;
            item.CodCategoria = (int)cmbCategoria.SelectedValue;
            item.QtdEstoque = (int)nudQtd.Value;
            txtPrecoUnit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            item.PrecoUnit = float.Parse(txtPrecoUnit.Text);
            item.TaxaLucro = Convert.ToInt32(txtTaxa.Text);
            item.CodFornecedor = (int)cmbFornecedor.SelectedValue;
            item.Obs = txtObs.Text;
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_ItemCategoria' table. You can move, or remove it, as needed.
            this.tcc_ItemCategoriaTableAdapter.Fill(this.dataSet_TCC.tcc_ItemCategoria);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Fornecedor' table. You can move, or remove it, as needed.
            this.tcc_FornecedorTableAdapter.Fill(this.dataSet_TCC.tcc_Fornecedor);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);

            if (btnSalvar.Text == "Alterar")
            {
                cmbCategoria.SelectedValue = cate;
                cmbFornecedor.SelectedValue = forn;
            }
        }

        private bool CaixasOK()
        {
            if (txtNomePro.Text == "")
            {
                errErro.SetError(txtNomePro, "Informar o Nome");
                return false;
            }
            else
            {
                errErro.SetError(txtNomePro, "");
            }
            if (txtPrecoUnit.Text == "")
            {
                errErro.SetError(txtPrecoUnit, "Informar o Preço Unitário");
                return false;
            }
            else
            {
                errErro.SetError(txtPrecoUnit, "");
            }
            return true;
        }

        private void tcc_ItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_ItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_TCC);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Alterar")
            {
                HabilitaComponentes();
                txtNomePro.Focus();
                btnSalvar.Text = "Salvar";
            }
            else if (btnSalvar.Text == "Cadastrar")
            {
                try
                {
                    if (CaixasOK())
                    {
                        adicionaProduto();

                        taProduto.Insert(item.Descricao, item.CodCategoria, item.QtdEstoque, item.PrecoUnit,
                            item.TaxaLucro, item.CodFornecedor, item.Obs);
                        MessageBox.Show("Produto Cadastrado!", "Cadastro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        int codItem = (int)taProduto.ProximoID() - 1;
                        double precoTotal = item.PrecoUnit * item.QtdEstoque;
                        taMov.Insert(10, codItem, item.QtdEstoque, precoTotal, DateTime.Now);
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
                    if (CaixasOK())
                    {
                        item.CodItem = Convert.ToInt16(lblCodigo.Text);
                        adicionaProduto();

                        taProduto.Update(item.Descricao, item.CodCategoria, item.QtdEstoque, item.PrecoUnit,
                            item.TaxaLucro, item.CodFornecedor, item.Obs, item.CodItem);
                        MessageBox.Show("Produto Alterado!", "Cadastro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                item.CodItem = Convert.ToInt16(lblCodigo.Text);
                DialogResult a;
                a = MessageBox.Show("Confirmar exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    taProduto.Delete(item.CodItem);
                    MessageBox.Show("Fornecedor Excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNomePro.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbFornecedor.Enabled = true;
            nudQtd.Enabled = true;
            txtPrecoUnit.Enabled = true;
            txtTaxa.Enabled = true;
            txtObs.Enabled = true;
        }
    }
}
