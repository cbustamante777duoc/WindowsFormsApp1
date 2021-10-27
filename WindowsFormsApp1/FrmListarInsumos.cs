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
    public partial class FrmListarInsumos : Form
    {
        public FrmListarInsumos()
        {
            InitializeComponent();
        }

        private void FrmListarInsumos_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarInsumos", "cursorMemoria", dgvInsumo);

        }
    }
}
