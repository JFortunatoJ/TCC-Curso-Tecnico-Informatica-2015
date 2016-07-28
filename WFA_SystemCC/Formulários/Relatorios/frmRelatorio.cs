using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SystemCC.Formulários.Relatorios
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorioVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_TCC.tcc_Item' table. You can move, or remove it, as needed.
            this.tcc_ItemTableAdapter.Fill(this.dataSet_TCC.tcc_Item);

            this.reportViewer1.RefreshReport();
        }
    }
}
