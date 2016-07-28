using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WFA_SystemCC.Dados.DataSet_TCC_EscolaTableAdapters;
using WFA_SystemCC.Dados.DataSet_TCCTableAdapters;

namespace WFA_SystemCC
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        public int p;


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadProdutos produtos = new frmCadProdutos();
            tcc_ItemTableAdapter taitem = new tcc_ItemTableAdapter();
            produtos.HabilitaComponentes();
            produtos.lblCodigo.Text = taitem.ProximoID().ToString();
            produtos.ShowDialog();
            frmEstoque_Load(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCadProdutos produtos = new frmCadProdutos();
            produtos.Text = "Alterar Produtos";
            produtos.ShowDialog();
        }

        private void tcc_ItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_ItemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_TCC);

        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Fornecedor' table. You can move, or remove it, as needed.
            this.tcc_FornecedorTableAdapter.Fill(this.dataSet_TCC.tcc_Fornecedor);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_ItemCategoria' table. You can move, or remove it, as needed.
            this.tcc_ItemCategoriaTableAdapter.Fill(this.dataSet_TCC.tcc_ItemCategoria);
            // TODO: This line of code loads data into the 'dataSet_TCC_Escola.tcc_Item' table. You can move, or remove it, as needed.
            //this.tcc_ItemTableAdapter1.Fill(this.dataSet_TCC_Escola.tcc_Item);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);

            cmbPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (p == 0)//Código
                {
                    if (txtPesquisaProduto.Text == "")
                    {
                        tcc_ItemBindingSource.Filter = "";
                    }
                    else
                    {

                        tcc_ItemBindingSource.Filter = "CONVERT(codItem, 'System.String') LIKE '" + Convert.ToInt16(txtPesquisaProduto.Text) + "%'";
                    }
                }
                if (p == 1)//Nome
                {
                    if (txtPesquisaProduto.Text == "")
                    {
                        tcc_ItemBindingSource.Filter = "";
                    }
                    else
                    {
                        tcc_ItemBindingSource.Filter = "descricao like '" + txtPesquisaProduto.Text + "%'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dgvProdutos_DoubleClick_1(object sender, EventArgs e)
        {
            frmCadProdutos frmCadPro = new frmCadProdutos();
            try
            {
                int codItem = (int)dgvProdutos.CurrentRow.Cells[0].Value;
                string nome = dgvProdutos.CurrentRow.Cells["nome"].Value.ToString();
                int cat = (int)dgvProdutos.CurrentRow.Cells["categoria"].Value;
                int qtd = (int)dgvProdutos.CurrentRow.Cells["qtd"].Value;
                string precoUnit = dgvProdutos.CurrentRow.Cells["precoUnit"].Value.ToString();
                int taxa = (int)dgvProdutos.CurrentRow.Cells["taxa"].Value;
                int forn = (int)dgvProdutos.CurrentRow.Cells["fornecedor"].Value;
                string obs = dgvProdutos.CurrentRow.Cells["obs"].Value.ToString();


                frmCadPro.lblCodigo.Text = codItem.ToString();
                frmCadPro.txtNomePro.Text = nome;
                frmCadPro.cate = cat;
                frmCadPro.nudQtd.Value = qtd;
                frmCadPro.txtPrecoUnit.Text = precoUnit;
                frmCadPro.txtTaxa.Text = taxa.ToString();
                frmCadPro.forn = forn;
                frmCadPro.txtObs.Text = obs;

                frmCadPro.Text = "Produto";
                frmCadPro.btnSalvar.Text = "Alterar";
                frmCadPro.btnExcluir.Visible = true;
                frmCadPro.ShowDialog();
                frmEstoque_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisaProduto.Text = null;
            txtPesquisaProduto.Focus();
            if (cmbPesquisa.SelectedIndex == 0)
            {
                p = 0;
            }
            if (cmbPesquisa.SelectedIndex == 1)
            {
                p = 1;
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrdenar.SelectedIndex == 0)
            {
                dgvProdutos.Sort(dgvProdutos.Columns[4], ListSortDirection.Descending);
            }
            if (cmbOrdenar.SelectedIndex == 1)
            {
                dgvProdutos.Sort(dgvProdutos.Columns[4], ListSortDirection.Ascending);
            }
        }


    }
}
