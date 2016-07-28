using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SystemCC.Formulários;
using WFA_SystemCC.Formulários.Cadastros;
using WFA_SystemCC.Formulários.Relatorios;

namespace WFA_SystemCC
{
    public partial class frmMenu : Form
    {
        public frmMenu(int codUser)
        {
            codUsuario = codUser;
            InitializeComponent();
        }
        private int codUsuario;

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tslData.Text = DateTime.Now.ToLongDateString();
            /*MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                // Attempt to cast the control to type MdiClient.
                ctlMDI = (MdiClient)ctl;

                // Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = this.BackColor;
            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frmCat = new frmCategoria();

            if (Application.OpenForms.OfType<frmCategoria>().Count() == 0)
            {
                frmCat.MdiParent = this;
                frmCat.Show();
            }
            else
            {
                Application.OpenForms[frmCat.Name].Focus();
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frmEst = new frmProdutos();

            if (Application.OpenForms.OfType<frmProdutos>().Count() == 0)
            {
                frmEst.MdiParent = this;
                frmEst.Show();
            }
            else
            {
                Application.OpenForms[frmEst.Name].Focus();
            }
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFornecedor frmForn = new frmFornecedor();

            if (Application.OpenForms.OfType<frmFornecedor>().Count() == 0)
            {
                frmForn.MdiParent = this;
                frmForn.Show();
            }
            else
            {
                Application.OpenForms[frmForn.Name].Focus();
            }
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBackup frmbackup = new frmBackup();
            frmbackup.MdiParent = this;
            frmbackup.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarefas frmTarefas = new frmTarefas(codUsuario);

            if (Application.OpenForms.OfType<frmTarefas>().Count() == 0)
            {
                frmTarefas.MdiParent = this;
                frmTarefas.Show();
            }
            else
            {
                Application.OpenForms[frmTarefas.Name].Focus();
            }
        }

        private void formulárioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas(codUsuario);

            if (Application.OpenForms.OfType<frmVendasRegistro>().Count() > 0)
            {
                Application.OpenForms.OfType<frmVendasRegistro>().ElementAt(0).Close();
            }

            if (Application.OpenForms.OfType<frmVendas>().Count() == 0)
            {
                frmVendas.MdiParent = this;
                frmVendas.Show();
            }
            else
            {
                Application.OpenForms[frmVendas.Name].Focus();
            }
        }

        private void registroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendasRegistro frmVendasRegistro = new frmVendasRegistro();

            if (Application.OpenForms.OfType<frmVendas>().Count() > 0)
            {
                Application.OpenForms.OfType<frmVendas>().ElementAt(0).Close();
            }

            if (Application.OpenForms.OfType<frmVendasRegistro>().Count() == 0)
            {
                frmVendasRegistro.MdiParent = this;
                frmVendasRegistro.Show();
            }
            else
            {
                Application.OpenForms[frmVendasRegistro.Name].Focus();
            }
        }


        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControleEstoque frmControleEstoque = new frmControleEstoque();

            if (Application.OpenForms.OfType<frmControleEstoque>().Count() == 0)
            {
                frmControleEstoque.MdiParent = this;
                frmControleEstoque.Show();
            }
            else
            {
                Application.OpenForms[frmControleEstoque.Name].Focus();
            }
        }

        private void registrarMovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadMovimentacao frmCadMovimentacao = new frmCadMovimentacao();

            if (Application.OpenForms.OfType<frmCadMovimentacao>().Count() == 0)
            {
                frmCadMovimentacao.MdiParent = this;
                frmCadMovimentacao.Show();
            }
            else
            {
                Application.OpenForms[frmCadMovimentacao.Name].Focus();
            }
        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorio frmRel = new frmRelatorio();
            frmRel.MdiParent = this;
            frmRel.Show();
        }
    }
}
