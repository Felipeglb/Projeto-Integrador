using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class MDIdepartamentos : Form
    {
        private int childFormNumber = 0;
    private void MDIrh_Load(object sender, EventArgs e)
        {

        }

        private void cadUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
