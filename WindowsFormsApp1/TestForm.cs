using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            SQL.listarConsultaSQl("select id_boleta, cantidad, descripcion from boleta",dgvBoleta);

            //OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            //OracleCommand cmd = new OracleCommand("select id_boleta,cantidad,descripcion from boleta",cn);
            //OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dgvBoleta.DataSource = table;


        }
    }
}
