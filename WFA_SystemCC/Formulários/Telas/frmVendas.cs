using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_SystemCC.Dados;
using WFA_SystemCC.Dados.DataSet_TCCTableAdapters;
using System.Windows.Forms;
using System.Collections;
using WFA_SystemCC.Model;

namespace WFA_SystemCC.Formulários
{
    public partial class frmVendas : Form
    {
        public frmVendas(int codUser)
        {
            codUsuario = codUser;
            InitializeComponent();

        }

        private int codUsuario;


        tcc_ItemTableAdapter taItem = new tcc_ItemTableAdapter();
        DataSet_TCC.tcc_ItemDataTable dt = new DataSet_TCC.tcc_ItemDataTable();
        tcc_MovimentacaoTableAdapter taMov = new tcc_MovimentacaoTableAdapter();


        private void LimpaCampos(bool newCodProd)
        {
            if (newCodProd)
            {
                txtProdCod.Text = "";
                cmbProduto.SelectedIndex = -1;
                txtProdPreco.Text = "0";
            }

            txtProdTotal.Text = "0";
            nudQTD.Value = 0;
        }


        private void txtProdCod_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtProdCod.Text != ""))
            {
                if ((Convert.ToInt32(txtProdCod.Text) > 0 && (Convert.ToInt32(txtProdCod.Text) < tcc_ItemTableAdapter.ProximoID())))
                {
                    try
                    {
                        dt = taItem.PesquisaProd(Convert.ToInt32(txtProdCod.Text));

                        cmbProduto.SelectedValue = Convert.ToInt32(txtProdCod.Text);
                        txtProdPreco.Text = Convert.ToDouble(dt.Rows[0]["precoUnit"]).ToString();
                        nudQTD.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não há produto com o código: " + txtProdCod.Text + " cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnProdIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(txtProdCod.Text) > 0 && (Convert.ToInt32(txtProdCod.Text) < tcc_ItemTableAdapter.ProximoID()) && (txtProdCod.Text != "")))
                {
                    if (Convert.ToInt32(nudQTD.Value) > 0)
                    {
                        bool sobrescrever = false;
                        int linhaEditar = -1;
                        for (int linha = 0; linha < dgvItensVenda.RowCount; linha++)
                        {
                            if (Convert.ToInt32(dgvItensVenda.Rows[linha].Cells[0].Value) == Convert.ToInt32(txtProdCod.Text))
                            {
                                sobrescrever = true;
                                linhaEditar = linha;
                            }
                        }
                        if (!sobrescrever)
                        {
                            dgvItensVenda.Rows.Add(txtProdCod.Text, cmbProduto.Text, nudQTD.Value, txtProdPreco.Text, txtProdTotal.Text);
                        }
                        else
                        {
                            int quantidade = Convert.ToInt32(dgvItensVenda.Rows[linhaEditar].Cells[2].Value) + Convert.ToInt32(nudQTD.Value);
                            dgvItensVenda.Rows[linhaEditar].Cells[2].Value = quantidade;
                            dgvItensVenda.Rows[linhaEditar].Cells[4].Value = Convert.ToInt32(dgvItensVenda.Rows[linhaEditar].Cells[3].Value) * Convert.ToInt32(dgvItensVenda.Rows[linhaEditar].Cells[2].Value);
                        }

                        int totalVenda = Convert.ToInt32(txtTotalVenda.Text) + Convert.ToInt32(txtProdTotal.Text);
                        LimpaCampos(true);
                        txtTotalVenda.Text = totalVenda.ToString();


                        txtProdCod.Focus();
                        dgvItensVenda.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Inclua uma quantidade desse produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Não há produto com o código: " + txtProdCod.Text + " cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);

            LimpaCampos(true);
            txtProdCod.Select();
            dgvItensVenda.ClearSelection();
        }

        private void btnRegistroVendas_Click(object sender, EventArgs e)
        {
            frmVendasRegistro frmVendasRegistro = new frmVendasRegistro();
            frmVendasRegistro.ShowDialog();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = taItem.PesquisaProd((int)cmbProduto.SelectedValue);
                txtProdPreco.Text = Convert.ToDouble(dt.Rows[0]["precoUnit"]).ToString();

                LimpaCampos(false);
                txtProdCod.Text = cmbProduto.SelectedValue.ToString();
            }
            catch (NullReferenceException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void nudQTD_ValueChanged(object sender, EventArgs e)
        {
            int textoQT = nudQTD.Value < 0 ? 0 : Convert.ToInt32(nudQTD.Value);
            double prodPrecoTotal = 0;
            txtProdPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            prodPrecoTotal = textoQT * Convert.ToInt32(txtProdPreco.Text);

            txtProdTotal.Text = prodPrecoTotal.ToString();
        }

        private void txtProdCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItensVenda.RowCount != 0)
                {
                    if ((dgvItensVenda.RowCount == 0) || (dgvItensVenda.SelectedRows.Count == 0))
                    {
                        btnExcluir.Enabled = false;
                    }
                    else
                    {
                        btnExcluir.Enabled = true;
                    }
                    DialogResult a;
                    a = MessageBox.Show("Confirmar exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        int subtotal = Convert.ToInt32(dgvItensVenda.CurrentRow.Cells[4].Value);
                        int totalVenda = Convert.ToInt32(txtTotalVenda.Text) - subtotal;
                        txtTotalVenda.Text = totalVenda.ToString();

                        dgvItensVenda.Rows.Remove(dgvItensVenda.CurrentRow);
                        dgvItensVenda.ClearSelection();
                    }
                    else
                    {
                        btnExcluir.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Não há produtos para serem excluídos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int linhaEditar;

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            try
            {
                btnProdIncluir.Enabled = false;
                btnExcluir.Enabled = false;
                if (dgvItensVenda.RowCount != 0)
                {
                    if ((dgvItensVenda.RowCount == 0) || (dgvItensVenda.SelectedRows.Count == 0))
                    {
                        btnAlterarQuantidade.Enabled = false;
                    }
                    else
                    {
                        btnAlterarQuantidade.Enabled = true;
                    }
                    if (btnAlterarQuantidade.Text == "Salvar")
                    {
                        btnAlterarQuantidade.Text = "Alterar Quantidade";

                        dgvItensVenda.Rows.RemoveAt(linhaEditar);
                        dgvItensVenda.Rows.Insert(linhaEditar, txtProdCod.Text, cmbProduto.Text, nudQTD.Value, txtProdPreco.Text, txtProdTotal.Text);
                        dgvItensVenda.ClearSelection();
                        LimpaCampos(true);
                        txtProdCod.Enabled = true;
                        cmbProduto.Enabled = true;
                        txtProdCod.Focus();

                        btnProdIncluir.Enabled = true;
                    }
                    else
                    {
                        btnAlterarQuantidade.Text = "Salvar";

                        txtProdCod.Enabled = false;
                        cmbProduto.Enabled = false;
                        nudQTD.Focus();

                        linhaEditar = dgvItensVenda.CurrentRow.Index;
                        txtProdCod.Text = dgvItensVenda.CurrentRow.Cells[0].Value.ToString();
                        cmbProduto.SelectedValue = Convert.ToInt32(txtProdCod.Text);
                        nudQTD.Value = Convert.ToInt32(dgvItensVenda.CurrentRow.Cells[2].Value);
                        txtProdPreco.Text = dgvItensVenda.CurrentRow.Cells[3].Value.ToString();
                        txtProdTotal.Text = dgvItensVenda.CurrentRow.Cells[4].Value.ToString();
                        btnAlterarQuantidade.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Não há produtos para serem excluídos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Venda ven = new Venda();
                ItemVenda item = new ItemVenda();
                tcc_ItemVendaTableAdapter itemVenda = new tcc_ItemVendaTableAdapter();
                tcc_VendaTableAdapter taVenda = new tcc_VendaTableAdapter();
                DataSet_TCC.tcc_ItemDataTable dt = new DataSet_TCC.tcc_ItemDataTable();
                

                taVenda.Insert(DateTime.Now, codUsuario, Convert.ToInt32(txtTotalVenda.Text));
                item.Codvenda = (int)taVenda.ProximoID() - 1;
                for (int numberLines = dgvItensVenda.RowCount - 1; numberLines >= 0; numberLines--)
                {
                    item.CodItem = Convert.ToInt32(dgvItensVenda.Rows[numberLines].Cells[0].Value);
                    item.Quantidade = Convert.ToInt32(dgvItensVenda.Rows[numberLines].Cells[2].Value);
                    item.PrecoUnit = Convert.ToInt32(dgvItensVenda.Rows[numberLines].Cells[4].Value);

                    itemVenda.Insert(item.Codvenda, item.CodItem, item.Quantidade, item.PrecoUnit);
                    dt = tcc_ItemTableAdapter.PesquisaProd(item.CodItem);
                    int qtdi = (int)dt.Rows[0]["qtd"] - item.Quantidade;
                    tcc_ItemTableAdapter.AtualizaQTD(qtdi, item.CodItem);

                    taMov.Insert(20, item.CodItem, item.Quantidade, item.PrecoUnit, DateTime.Now);
                }
                MessageBox.Show("Venda encerrada", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTotalVenda.Text = "0";
                dgvItensVenda.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvItensVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItensVenda.RowCount > 0)
                {
                    btnExcluir.Enabled = true;
                    btnAlterarQuantidade.Enabled = true;
                }
                else
                {
                    btnExcluir.Enabled = false;
                    btnAlterarQuantidade.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudQTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProdIncluir_Click(sender, e);
            }
        }
    }
}

