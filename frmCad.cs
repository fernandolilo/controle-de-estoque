using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paula
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.Show();
            this.Visible = false;

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
