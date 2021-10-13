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
    public partial class FrmLocal : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public FrmLocal()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand commando = new OracleCommand("select * from local", ora);
            OracleDataAdapter adapter = new OracleDataAdapter(commando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvLocal.DataSource = table;
            ora.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("insertarLocal", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_local", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("comuna", OracleType.VarChar).Value = txtComuna.Text;
                commando.Parameters.Add("direccion", OracleType.VarChar).Value = txtDireccion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el local en la base de datos con id =" + txtId.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("algo fallo");
            }

            ora.Close();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("actualizarLocal", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_local", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("comuna", OracleType.VarChar).Value = txtComuna.Text;
                commando.Parameters.Add("direccion", OracleType.VarChar).Value = txtDireccion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se actualizo correctamente el local en la base de datos con id = " + txtId.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("se actualizo correctamente el local en la base de datos con id = " + txtId.Text);
            }

            ora.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("eliminarLocal", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_local", OracleType.VarChar).Value = txtId.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se elimino correctamente el local con id " + txtId.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido eliminar el local");
            }

            ora.Close();
        }
    }
}
