using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class SQL
    {
        private static OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);


        //metodo para listar las consultas sql
        public static void listarConsultaSQl(string consulta,DataGridView grilla) 
        {
            //OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand(consulta, cn);
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grilla.DataSource = table;
        }

        public static void ListarProcedureSql(string NombreProcedure,string nombreCursor, DataGridView grilla) 
        {
            //OracleConnection cn = new OracleConnection(ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
            OracleCommand cmd = new OracleCommand(NombreProcedure, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(nombreCursor, OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grilla.DataSource = table;

        }

        public static void FiltrarProcedureSql(string nombreProcedure, string nombreCursor, string parametro,
            TextBox textbox,DataGridView grilla) 
        {
            OracleCommand cmd = new OracleCommand("buscarBoletaTest", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(nombreProcedure, OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parametro, OracleType.VarChar).Value = textbox.Text;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grilla.DataSource = table;
        }


    }
}
