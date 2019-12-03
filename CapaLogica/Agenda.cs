using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Agenda
    {
        public SqlDataAdapter Clt;
        public DataTable TContactos;
        public DataSet ds;
        public DataRow dr;
        public SqlCommand comando;
        public SqlDataReader sqldr;
        Conexion oConexion = new Conexion();

        public void InsertarContacto (string nombre, string apellido, string correo, long telefono, long celular, string nota, PictureBox foto)
        {
            try
            {
                comando = new SqlCommand("exec ae_Insertar_Contacto '" + nombre + "', '" + apellido + "', '" + correo + "'," + telefono + ", " + celular + ", '" + nota + "', @foto", oConexion.conexion());
                GuardarFoto(foto);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Insertar Datos" + ex);
            }
        }

        public void ActualizarContacto(string nombre, string apellido, string correo, long telefono, long celular, string nota, PictureBox foto)
        {
            try
            {
                comando = new SqlCommand("exec ae_Actualizar_Contacto '" + nombre + "', '" + apellido + "', '" + correo + "', " + telefono + ", '" + nota + "', @foto , " + celular + "", oConexion.conexion());
                GuardarFoto(foto);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Actualizar Datos" + ex);
            }
        }

        public void BorrarContacto(string nombre, long celular)
        {
            try
            {
                comando = new SqlCommand("exec ae_Borrar_Contacto '" + nombre + "', " + celular + "", oConexion.conexion());
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Insertar Datos" + ex);
            }
        }

        public void MostrarContactoBuscado(string Letra)
        {
            try
            {
                SqlCommand comando = new SqlCommand("select * from Contactos Where  nombre  Like '" + Letra + "%'", oConexion.conexion());
                comando.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Insertar Datos" + ex);
            }
        }

        public DataTable ImprimirTabla()
        {
            try
            {
                Clt = new SqlDataAdapter("select * from Contactos", oConexion.conexion());
                TContactos = new DataTable();
                Clt.Fill(TContactos);
                return TContactos;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar datos" + ex);
                return TContactos;
            }
        }

        public DataTable BuscarEnTabla(string letra)
        {
            try
            {
                Clt = new SqlDataAdapter("select * from Contactos Where  nombre  Like '" +letra + "%'", oConexion.conexion());
                TContactos = new DataTable();
                Clt.Fill(TContactos);
                return TContactos;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al cargar datos" + ex);
                return TContactos;
            }
        }

        public void MostrarFotoContacto(long celular, PictureBox foto)
        {
            try
            {
                Clt = new SqlDataAdapter("Select foto from Contactos where celular = " + celular + "", oConexion.conexion());
                ds = new DataSet();
                Clt.Fill(ds, "Contactos");
                byte[] datos = new byte[0];
                dr = ds.Tables["Contactos"].Rows[0];
                datos = (byte[])dr["foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                foto.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El contacto no tiene imagen ");
            }

        }

        public void GuardarFoto(PictureBox foto)
        {
            comando.Parameters.Add("@foto", SqlDbType.Image);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@foto"].Value = ms.GetBuffer();
            comando.ExecuteNonQuery();
        }
    }
}
