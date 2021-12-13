using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarMerma frm = new FrmListarMerma();
            frm.Show();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarInsumos frm = new FrmListarInsumos();
            frm.Show();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarLocal frm = new frmListarLocal();
            frm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProducto frm = new FrmListarProducto();
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaProvedor frmLista = new frmListaProvedor();
            frmLista.Show();
        }

        private void boletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestBoleta frm = new FrmTestBoleta();
            frm.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarProveedor frm = new FrmListarProveedor();
            frm.Show();
        }

        private void localToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLocal frm = new FrmLocal();
            frm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
        }

        private void insumoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol frm = new frmRol();
            frm.Show();
        }
    }
}
