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

namespace WFA_SystemCC
{
    public partial class frmControleEstoque : Form
    {
        public frmControleEstoque()
        {
            InitializeComponent();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                tccMovimentacaoBindingSource.Filter = "";
            }
            else
            {

                tccMovimentacaoBindingSource.Filter = "CONVERT(codMov, 'System.String') LIKE '" + Convert.ToInt16(txtPesquisar.Text) + "%'";
            }
        }

        private void frmControleEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_TipoMov' table. You can move, or remove it, as needed.
            this.tcc_TipoMovTableAdapter.Fill(this.dataSet_TCC.tcc_TipoMov);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Movimentacao' table. You can move, or remove it, as needed.
            this.tcc_MovimentacaoTableAdapter.Fill(this.dataSet_TCC.tcc_Movimentacao);

        }
    }
}
