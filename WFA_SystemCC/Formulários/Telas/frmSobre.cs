using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SystemCC
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            string sobre = "RayTrixel é uma empresa criada com o intuito de solucionar problemas comuns que atrapalham "
                 + "o funcionamento de um negócio de forma simples e objetiva.";
            string Pap = "Papelaria Cópia e Cor - Controle de Estoque";
            string versao = "Versão: 1.0";

            txtSobre.Text = sobre;
            txtpap.Text = Pap;
            txtVersao.Text = versao;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
