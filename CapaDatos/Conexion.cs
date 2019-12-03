using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Conexion
    {
        private string con = "Data Source=307-1;Initial Catalog=AgendaElectronica;Integrated Security=True";
        public SqlConnection conec;

        public string Cnn
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public SqlConnection conexion()
        {
            try
            {
                conec = new SqlConnection(Cnn);
                conec.Open();
                return conec;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar " + ex);
                conec.Close();
                return conec;
            }
        }
    }
}
