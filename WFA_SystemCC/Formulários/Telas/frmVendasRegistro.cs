using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SystemCC.Formulários;
using WFA_SystemCC.Dados.DataSet_TCCTableAdapters;
using WFA_SystemCC.Dados;
using WFA_SystemCC.Model;

namespace WFA_SystemCC.Formulários
{
    public partial class frmVendasRegistro : Form
    {
        public frmVendasRegistro()
        {
            InitializeComponent();
        }

        tcc_ItemVendaTableAdapter taItemVenda = new tcc_ItemVendaTableAdapter();
        private void btnDeletarVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.CodVenda = Convert.ToInt32(dgvVendas.CurrentRow.Cells[0].Value);
            taItemVenda.Delete(venda.CodVenda);
            tcc_VendaTableAdapter.Delete(venda.CodVenda);
            MessageBox.Show("Venda Excluída com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmVendasRegistro_Load(sender, e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVendasRegistro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Usuario' table. You can move, or remove it, as needed.
            this.tcc_UsuarioTableAdapter.Fill(this.dataSet_TCC.tcc_Usuario);
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Venda' table. You can move, or remove it, as needed.
            this.tcc_VendaTableAdapter.Fill(this.dataSet_TCC.tcc_Venda);

        }

        private void dgvVendas_Click(object sender, EventArgs e)
        {


        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try {
                int codVenda = (dgvVendas.CurrentRow.Cells[0].Value == null) ? -1 : Convert.ToInt32(dgvVendas.CurrentRow.Cells[0].Value);
                int qtdItem = Convert.ToInt32(taItemVenda.QtdItem(codVenda));

                dgvItemVenda.Rows.Clear();
                DataSet_TCC.tcc_ItemVendaDataTable dt = new DataSet_TCC.tcc_ItemVendaDataTable();
                dt = taItemVenda.PesquisaItem(codVenda);
                if (codVenda >= 0)
                {
                    for (int codItem = 0; codItem < qtdItem; codItem++)
                    {
                        int coditem = Convert.ToInt32(dt.Rows[codItem]["codItem"]);
                        int qtd = Convert.ToInt32(dt.Rows[codItem]["qtd"]);
                        double precoUnit = Convert.ToInt32(dt.Rows[codItem]["precoUnit"]);

                        dgvItemVenda.Rows.Add(coditem, coditem, qtd, precoUnit);
                    }
                }
                else
                {
                    dgvItemVenda.Rows.Clear();
                }
            }catch(Exception ex)
            {

            }
        }
    }
}
