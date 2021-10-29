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
    public partial class FrmListarMerma : Form
    {
        public FrmListarMerma()
        {
            InitializeComponent();
        }

        private void FrmListarMerma_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarMerma", "cursorMemoria",dgvListarMerma);
        }
    }
}
