﻿using System;
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
    public partial class FrmListarProveedor : Form
    {
        public FrmListarProveedor()
        {
            InitializeComponent();
        }

        private void FrmListarProveedor_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarProveedor", "cursorMemoria", dgvProveedor);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand("BuscarProveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursorMemoria", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("rutB", OracleType.VarChar).Value = txtRut.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProveedor.DataSource = table;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRut.Text = "";
            SQL.ListarProcedureSql("ListarProveedor", "cursorMemoria", dgvProveedor);
        }
    }
}
