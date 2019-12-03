using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaElectronicaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pcFoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtNota.Text == ""))
            {
                Agenda oAgenda = new Agenda();
                oAgenda.InsertarContacto(txtNombre.Text, txtApellido.Text, txtCorreo.Text, long.Parse(txtTelefono.Text), long.Parse(txtCelular.Text), txtNota.Text, pcFoto);
                dataGridView1.DataSource = oAgenda.ImprimirTabla();
                limpiar();

            }else
            {
                MessageBox.Show("Porfavor Digita todos los campos incluyendo foto de contacto");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtNota.Text == "" || ckbActualizar.Checked == false))
            {
                Agenda oAgenda = new Agenda();
                oAgenda.ActualizarContacto(txtNombre.Text, txtApellido.Text, txtCorreo.Text, long.Parse(txtTelefono.Text), long.Parse(txtCelular.Text), txtNota.Text, pcFoto);
                dataGridView1.DataSource = oAgenda.ImprimirTabla();
                limpiar();
            }
            else
            {
                MessageBox.Show("Porfavor verifica si todos los campos estan digitados, si incluye foto y si esta el check actualizar esta activo");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtNota.Text == "" || ckbBorrar.Checked == false))
            {
            Agenda oAgenda = new Agenda();
            oAgenda.BorrarContacto(txtNombre.Text, long.Parse(txtCelular.Text));
            dataGridView1.DataSource = oAgenda.ImprimirTabla();
            limpiar();
            }
            else
            {
                MessageBox.Show("Porfavor verifica si todos los campos estan digitados, si incluye foto y si esta el check borrar esta activo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaElectronicaDataSet.Contactos' table. You can move, or remove it, as needed.
            //this.contactosTableAdapter.Fill(this.agendaElectronicaDataSet.Contactos);
        }

        private void contactosBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
        }

        private void ckbBorrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBorrar.Checked == true)
            {
                txtNombre.Visible = true;
                txtCelular.Visible = true;
                txtApellido.Visible = false;
                txtCorreo.Visible = false;
                txtNota.Visible = false;
                txtTelefono.Visible = false;
            }
            else
            {
                txtNombre.Visible = true;
                txtCelular.Visible = true;
                txtApellido.Visible = true;
                txtCorreo.Visible = true;
                txtNota.Visible = true;
                txtTelefono.Visible = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 1;
            Agenda oAgenda = new Agenda();
            oAgenda.MostrarContactoBuscado(txtBuscar.Text);
            dataGridView1.DataSource = oAgenda.BuscarEnTabla(txtBuscar.Text);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                epError.SetError(txtNombre, "Introduce Solo Letras ");
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                epError.SetError(txtApellido, "Introduce Solo Letras ");
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTelefono.MaxLength = 7;

            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                epError.SetError(txtTelefono, "Introduce Solo Numeros ");
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCelular.MaxLength = 10;

            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                epError.SetError(txtCelular, "Introduce Solo Numeros ");
                e.Handled = true;
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && e.KeyChar != (char)Keys.Back)
            {
                epError.SetError(txtNota, "Introduce Solo Letras ");
                e.Handled = true;
            }
        }

        private void btnAgreagarFoto_Click(object sender, EventArgs e)
        {
        }

        private void pcFoto_Click(object sender, EventArgs e)
        {
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtNota.Clear();
            pcFoto.Visible = false;
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            if (!(txtBuscar.Text == ""))
            {
                txtNombre.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtApellido.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtCorreo.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtCelular.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtNota.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                Agenda oAgenda = new Agenda();
                oAgenda.MostrarFotoContacto(long.Parse(txtCelular.Text), pcFoto);
            }else
            {
                MessageBox.Show("Por favor digita una letra en el campo de busqueda");
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
