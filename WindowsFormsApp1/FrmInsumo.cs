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

namespace WindowsFormsApp1
{
    public partial class FrmInsumo : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public FrmInsumo()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand commando = new OracleCommand("select * from insumo", ora);
            OracleDataAdapter adapter = new OracleDataAdapter(commando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvInsumo.DataSource = table;
            ora.Close();
        }
    }
}
