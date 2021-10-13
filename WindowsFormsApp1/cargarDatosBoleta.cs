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

namespace WindowsFormsApp1
{
    public partial class cargarDatosBoleta : Form
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public cargarDatosBoleta()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            
            ora.Open();
            MessageBox.Show("Conectado a oracle");
            ora.Close();

                
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand commando = new OracleCommand("select * from BOLETA", ora);
            OracleDataAdapter adapter = new OracleDataAdapter(commando);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvDatos.DataSource = table;
            ora.Close();
           
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            

            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("insertarboleta", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_boleta", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("cantidad", OracleType.VarChar).Value = txtCantidad.Text;
                commando.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente");

            }
            catch (Exception)
            {

                MessageBox.Show("algo fallo");
            }

            ora.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("actualizarBoleta", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("idboleta", OracleType.VarChar).Value = txtId.Text;
                commando.Parameters.Add("cantidad", OracleType.VarChar).Value = txtCantidad.Text;
                commando.Parameters.Add("descripcion", OracleType.VarChar).Value = txtDescripcion.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se actualizo correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("algo fallo");
            }

              ora.Close();







        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("eliminarBoleta", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_boleta", OracleType.VarChar).Value = txtId.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se elimino correctamente "+txtId.Text);


            }
            catch (Exception)
            {

                MessageBox.Show("algo anda mal");
            }

            ora.Close();
        }
    }
}
