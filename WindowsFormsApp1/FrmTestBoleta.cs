using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class FrmTestBoleta : Form
    {
        public FrmTestBoleta()
        {
            InitializeComponent();
        }

        private void FrmTestBoleta_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("upslitarBoleta", "cursorMemoria",dgvBoleta);

            //OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //OracleCommand cmd = new OracleCommand("upslitarBoleta", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("cursorMemoria",OracleType.Cursor).Direction = ParameterDirection.Output;
            //OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dgvBoleta.DataSource = table;

          
        }
    }
}
