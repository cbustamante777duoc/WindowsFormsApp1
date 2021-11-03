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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
                OracleCommand cmd = new OracleCommand("BuscarMermaTest", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cursorMemoria", OracleType.Cursor).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("desde", OracleType.VarChar).Value =  textBox1.Text + "DD/MM/YYYY";
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvFiltro.DataSource = table;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarMerma", "cursorMemoria", dgvFiltro);
        }
    }
}
