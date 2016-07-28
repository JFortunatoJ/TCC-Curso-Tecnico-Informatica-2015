using Ferramentas;
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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }
        //Alterar de acordo com o Banco de Dados
        String conexaoBD = "Data Source=LEO\\SQLSERVER;Initial Catalog = db_01894_1_B_2_2014; Persist Security Info=True;User ID = sa; Password=358352124";

        private void btnRecuperaBackup_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Backup Files|*.bak";
                ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    String localBackup = ofd.FileName;
                    //Alterar de acordo com o Banco de Dados
                    String nomeBanco = "db_01894_1_B_2_2014";
                    String conexao = conexaoBD;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, localBackup);

                    MessageBox.Show("Backup restaurado com sucesso.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCriaBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Backup Files|*.bak";
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    String localBackup = sfd.FileName;
                    //Alterar de acordo com o Banco de Dados
                    String nomeBanco = "db_01894_1_B_2_2014";
                    String conexao = conexaoBD;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup realizado com sucesso.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
