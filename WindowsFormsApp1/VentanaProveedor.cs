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
    public partial class VentanaProveedor : Form
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public VentanaProveedor()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand commando = new OracleCommand("select * from proveedor", ora);
            OracleDataAdapter adapter = new OracleDataAdapter(commando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvProveedor.DataSource = table;
            ora.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("insertarProveedor", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_proveedor", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("apellido", OracleType.VarChar).Value = txtApellido.Text;
                commando.Parameters.Add("comuna", OracleType.VarChar).Value = txtComuna.Text;
                commando.Parameters.Add("direccion", OracleType.VarChar).Value = txtDireccion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.Parameters.Add("rut", OracleType.VarChar).Value = txtRut.Text;
                commando.Parameters.Add("telefono", OracleType.VarChar).Value = txtTelefono.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el proveedor en la base de datos con id ="+ txtId.Text);

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
                OracleCommand commando = new OracleCommand("actualizarProveedor", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_porveedor", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("apellido", OracleType.VarChar).Value = txtApellido.Text;
                commando.Parameters.Add("comuna", OracleType.VarChar).Value = txtComuna.Text;
                commando.Parameters.Add("direccion", OracleType.VarChar).Value = txtDireccion.Text;
                commando.Parameters.Add("nombre", OracleType.VarChar).Value = txtNombre.Text;
                commando.Parameters.Add("rut", OracleType.VarChar).Value = txtRut.Text;
                commando.Parameters.Add("telefono", OracleType.VarChar).Value = txtTelefono.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se actualizo correctamente el proveedor en la base de datos con id = "+ txtId.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("se actualizo correctamente el proveedor en la base de datos");
            }
            ora.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("eliminarProveedor", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_porveedor", OracleType.VarChar).Value = txtId.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se elimino correctamente el proveedor con id " + txtId.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha podido eliminar el proveedor");
            }

            ora.Close();
        }

        private void VentanaProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
