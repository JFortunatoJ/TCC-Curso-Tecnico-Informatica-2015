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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }
        int p;

        Fornecedor forn = new Fornecedor();
        tcc_FornecedorTableAdapter taFornecedor = new tcc_FornecedorTableAdapter();

        public void tcc_FornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_TCC);

        }

        public void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC_Escola1.tcc_Fornecedor' table. You can move, or remove it, as needed.
            //this.tcc_FornecedorTableAdapter1.Fill(this.dataSet_TCC_Escola1.tcc_Fornecedor);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Fornecedor' table. You can move, or remove it, as needed.
            this.tcc_FornecedorTableAdapter.Fill(this.dataSet_TCC.tcc_Fornecedor);

            cmbPesquisar.SelectedIndex = 0;
        }

        private void btnIncluirNovo_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frmCadforn = new frmCadFornecedor();
            frmCadforn.lblCodigo.Text = taFornecedor.ProximoID().ToString();
            frmCadforn.HabilitaComponentes();
            frmCadforn.LimpaCampos();
            frmCadforn.ShowDialog();
            frmFornecedor_Load(sender, e);
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            int codForn = (int)dgvFornecedor.CurrentRow.Cells[0].Value;
            string nome = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            string endereco = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            string telefone = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            string email = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();

            frmCadFornecedor frmCadforn = new frmCadFornecedor();
            frmCadforn.lblCodigo.Text = codForn.ToString();
            frmCadforn.txtNome.Text = nome;
            frmCadforn.txtEndereco.Text = endereco;
            frmCadforn.txtTelefone.Text = telefone;
            frmCadforn.txtEmail.Text = email;

            frmCadforn.Text = "Fornecedor";
            frmCadforn.btnSalvar.Text = "Alterar";
            frmCadforn.btnExcluir.Visible = true;
            frmCadforn.ShowDialog();
            frmFornecedor_Load(sender, e);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (p == 0)//Código
                {
                    if (txtPesquisar.Text == "")
                    {
                        tcc_FornecedorBindingSource.Filter = "";
                    }
                    else
                    {

                        tcc_FornecedorBindingSource.Filter = "CONVERT(codFornecedor, 'System.String') LIKE '" + Convert.ToInt16(txtPesquisar.Text) + "%'";
                    }
                }
                if (p == 1)//Nome
                {
                    if (txtPesquisar.Text == "")
                    {
                        tcc_FornecedorBindingSource.Filter = "";
                    }
                    else
                    {
                        tcc_FornecedorBindingSource.Filter = "nome like '" + txtPesquisar.Text + "%'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = null;
            txtPesquisar.Focus();
            if (cmbPesquisar.SelectedIndex == 0)
            {
                p = 0;
            }
            else
            {
                p = 1;
            }
        }
    }
}
