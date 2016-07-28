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

namespace WFA_SystemCC.Formulários.Cadastros
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        Categoria cat = new Categoria();
        tcc_ItemCategoriaTableAdapter taCategoria = new tcc_ItemCategoriaTableAdapter();


        private void tcc_ItemCategoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tcc_ItemCategoriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_TCC);
        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_ItemCategoria' table. You can move, or remove it, as needed.
            this.tcc_ItemCategoriaTableAdapter.Fill(this.dataSet_TCC.tcc_ItemCategoria);
        }

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int codCat = (int)dgvCategoria.CurrentRow.Cells[0].Value;
                string nome = dgvCategoria.CurrentRow.Cells[1].Value.ToString();

                frmCadCategoria frmCadCat = new frmCadCategoria();
                frmCadCat.lblCodigo.Text = codCat.ToString();
                frmCadCat.txtNome.Text = nome;

                frmCadCat.Text = "Categoria";
                frmCadCat.btnCadastrar.Text = "Alterar";
                frmCadCat.btnExcluir.Visible = true;
                frmCadCat.ShowDialog();
                frmCadCategoria_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnIncluirN_Click(object sender, EventArgs e)
        {
            frmCadCategoria frmCadCat = new frmCadCategoria();
            frmCadCat.lblCodigo.Text = taCategoria.ProximoID().ToString();
            frmCadCat.txtNome.Enabled = true;
            frmCadCat.ShowDialog();
            frmCadCategoria_Load(sender, e);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                tcc_ItemCategoriaBindingSource.Filter = "";
            }
            else
            {
                tcc_ItemCategoriaBindingSource.Filter = "nomeCategoria like '" + txtPesquisar.Text + "%'";
            }
        }
    }
}
