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
using WFA_SystemCC.Model;

namespace WFA_SystemCC.Formulários.Cadastros
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

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
            if (txtConfSenha.Text == "")
            {
                errErro.SetError(txtConfSenha, "Confirme a Senha");
                return false;
            }
            else
                errErro.SetError(txtConfSenha, "");
            if (txtConfSenha.Text != txtSenha.Text)
            {
                errErro.SetError(txtConfSenha, "As senhas devem coincidir");
                return false;
            }
            else
                errErro.SetError(txtConfSenha, "");
            return true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                Usuario user = new Usuario();
                tcc_UsuarioTableAdapter taUsuario = new tcc_UsuarioTableAdapter();

                user.Nome = txtUsuario.Text;
                user.Senha = txtConfSenha.Text;
                if(cmbTipo.SelectedIndex == 0)
                {
                    user.Tipo = 0;
                }
                else
                {
                    user.Tipo = 1;
                }
                taUsuario.Insert(user.Nome, user.Senha, user.Tipo);
                MessageBox.Show("Usuário: " + user.Nome + " Cadastrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
