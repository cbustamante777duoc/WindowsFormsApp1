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
    public partial class FrmListarUsuarios : Form
    {
        public FrmListarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmListarUsuarios_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarUsuarios", "cursorMemoria",dgvUsuario);
        }
    }
}
