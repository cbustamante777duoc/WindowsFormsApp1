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
    public partial class FrmUsuario : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =XE; PASSWORD=abcd1234; USER ID =SIGLOXXI");
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //ora.Open();
            //OracleCommand commando = new OracleCommand("select * from usuario", ora);
            //OracleDataAdapter adapter = new OracleDataAdapter(commando);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dgvUsuario.DataSource = table;
            //ora.Close();
            SQL.ListarProcedureSql("ListarUsuarios", "cursorMemoria", dgvUsuario);
            txtEstado.Text = "";
            txtIdLocal.Text = "";
            txtIdUsuario.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            txtBuscarNombre.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("insertarUsuario", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_usuario", OracleType.VarChar).Value = txtIdUsuario.Text;
                commando.Parameters.Add("estado", OracleType.VarChar).Value = txtEstado.Text;
                commando.Parameters.Add("password", OracleType.VarChar).Value = txtPass.Text;
                commando.Parameters.Add("usuario", OracleType.VarChar).Value = txtNombre.Text;
                commando.Parameters.Add("id_local", OracleType.VarChar).Value = txtIdLocal.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el usuario en la base de datos con id =" + txtIdUsuario.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("algo fallo al insertar usuario");
            }

            ora.Close();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand commando = new OracleCommand("actualizarUsuario", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_usuario", OracleType.VarChar).Value = txtIdUsuario.Text;
                commando.Parameters.Add("estado", OracleType.VarChar).Value = txtEstado.Text;
                commando.Parameters.Add("password", OracleType.VarChar).Value = txtPass.Text;
                commando.Parameters.Add("usuario", OracleType.VarChar).Value = txtNombre.Text;
                commando.Parameters.Add("id_local", OracleType.VarChar).Value = txtIdLocal.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se inserto correctamente el usuario en la base de datos con id =" + txtIdUsuario.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo actualizar el usuario");
            }
            ora.Close();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ora.Open();
                OracleCommand commando = new OracleCommand("eliminarUsuario", ora);
                commando.CommandType = System.Data.CommandType.StoredProcedure;
                commando.Parameters.Add("id_usuario", OracleType.VarChar).Value = txtIdUsuario.Text;
                commando.ExecuteNonQuery();
                MessageBox.Show("se elimino correctamente el local con id " + txtIdUsuario.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("no se puedo eliminar el usuario");
            }
            ora.Close();

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            SQL.ListarProcedureSql("ListarUsuarios", "cursorMemoria", dgvUsuario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand("BuscarUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("cursorMemoria", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("usuarioB", OracleType.VarChar).Value = txtBuscarNombre.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsuario.DataSource = table;
        }
    }
}
