using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand("BuscarInsumos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursorMemoria", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("descrip", OracleType.VarChar).Value = txtDescripcion.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvInsumo.DataSource = table;
        }
    }
}
