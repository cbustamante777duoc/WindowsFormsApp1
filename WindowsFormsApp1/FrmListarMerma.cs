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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand("BuscarMerma", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursorMemoria", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("cantidadB", OracleType.VarChar).Value = txtCantidad.Text;
            cmd.Parameters.Add("nombreB", OracleType.VarChar).Value = txtNombre.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);                  
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvListarMerma.DataSource = table;
           
        }
    }
}
