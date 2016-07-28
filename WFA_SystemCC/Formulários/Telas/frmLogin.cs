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
using WFA_SystemCC.Dados;
using WFA_SystemCC.Formulários.Cadastros;
using WFA_SystemCC.Formulários;

namespace WFA_SystemCC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public int codUsuario;
        private int vErros = 3;
        

        private bool CaixasOK()
        {
            if (txtUsuario.Text == "")
            {
                errErro.SetError(txtUsuario, "Informar o Usuário");
                return false;
            }
            else
            {
                errErro.SetError(txtUsuario, "");
            }
            if (txtSenha.Text == "")
            {
                errErro.SetError(txtSenha, "Informar a Senha");
                return false;
            }
            else
                errErro.SetError(txtSenha, "");
            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // Com o Banco
            if (CaixasOK())
            {
                DataSet_TCC.tcc_UsuarioDataTable dtUsuario = new DataSet_TCC.tcc_UsuarioDataTable();
                tcc_UsuarioTableAdapter taUsuario = new tcc_UsuarioTableAdapter();
                dtUsuario = taUsuario.VerificaPrivilegio(txtUsuario.Text, txtSenha.Text);
                if (dtUsuario.Rows.Count == 0)
                {
                    vErros--;
                    MessageBox.Show("Usuário ou Senha inválidos!\nTentativas restantes: " + vErros, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (vErros == 0)
                    {
                        MessageBox.Show("Número de Tentativas esgotado...", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        taUsuario.Dispose();
                        this.Close();
                    }
                }
                else
                {
                    Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["privilegio"];
                    Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;

                    dtUsuario = taUsuario.CodigoUser(txtUsuario.Text, txtSenha.Text);

                    int cod = (int)dtUsuario.Rows[0]["codUsuario"];


                    frmMenu frmmenu = new frmMenu(cod);
                    frmmenu.Show();
                    this.Visible = false;
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.Enter && txtSenha.Focused)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmCadUsuario = new frmCadUsuario();
            frmCadUsuario.ShowDialog();
        }
    }
}
