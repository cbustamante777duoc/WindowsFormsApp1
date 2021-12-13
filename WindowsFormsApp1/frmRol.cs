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
    public partial class frmRol : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public frmRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("insertarRol", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_rol", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el rol en la base de datos con id =" + txtId.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Algo fallo");
            }
            ora.Close();

        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarRol", "cursorMemoria",dgvRol);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            SQL.ListarProcedureSql("ListarRol", "cursorMemoria", dgvRol);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand commando = new OracleCommand("actualizarRol", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_rol", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el rol en la base de datos con id =" + txtId.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo actualizar el rol");
            }

            ora.Close();
        }
    }
}
