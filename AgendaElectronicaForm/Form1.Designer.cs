namespace AgendaElectronicaForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaElectronicaDataSet = new AgendaElectronicaForm.AgendaElectronicaDataSet();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pcFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.contactosTableAdapter = new AgendaElectronicaForm.AgendaElectronicaDataSetTableAdapters.ContactosTableAdapter();
            this.ckbActualizar = new System.Windows.Forms.CheckBox();
            this.ckbBorrar = new System.Windows.Forms.CheckBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnContacto = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaElectronicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.correo,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "Contactos";
            this.contactosBindingSource.DataSource = this.agendaElectronicaDataSet;
            this.contactosBindingSource.CurrentChanged += new System.EventHandler(this.contactosBindingSource_CurrentChanged);
            // 
            // agendaElectronicaDataSet
            // 
            this.agendaElectronicaDataSet.DataSetName = "AgendaElectronicaDataSet";
            this.agendaElectronicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(133, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(133, 95);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(133, 135);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(133, 174);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(44, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(44, 101);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(44, 141);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 9;
            this.lblCelular.Text = "Celular";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(44, 180);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(44, 224);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(133, 216);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 86);
            this.txtNota.TabIndex = 12;
            this.txtNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(354, 279);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(534, 277);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(690, 278);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pcFoto
            // 
            this.pcFoto.Location = new System.Drawing.Point(962, 12);
            this.pcFoto.Name = "pcFoto";
            this.pcFoto.Size = new System.Drawing.Size(140, 182);
            this.pcFoto.TabIndex = 16;
            this.pcFoto.TabStop = false;
            this.pcFoto.Click += new System.EventHandler(this.pcFoto_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(1002, 214);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // ckbActualizar
            // 
            this.ckbActualizar.AutoSize = true;
            this.ckbActualizar.Location = new System.Drawing.Point(534, 223);
            this.ckbActualizar.Name = "ckbActualizar";
            this.ckbActualizar.Size = new System.Drawing.Size(72, 17);
            this.ckbActualizar.TabIndex = 19;
            this.ckbActualizar.Text = "Actualizar";
            this.ckbActualizar.UseVisualStyleBackColor = true;
            this.ckbActualizar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbBorrar
            // 
            this.ckbBorrar.AutoSize = true;
            this.ckbBorrar.Location = new System.Drawing.Point(690, 223);
            this.ckbBorrar.Name = "ckbBorrar";
            this.ckbBorrar.Size = new System.Drawing.Size(54, 17);
            this.ckbBorrar.TabIndex = 20;
            this.ckbBorrar.Text = "Borrar";
            this.ckbBorrar.UseVisualStyleBackColor = true;
            this.ckbBorrar.CheckedChanged += new System.EventHandler(this.ckbBorrar_CheckedChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(289, 216);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(354, 216);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 22;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(840, 278);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(75, 23);
            this.btnContacto.TabIndex = 24;
            this.btnContacto.Text = "Contacto";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "nombre";
            this.correo.HeaderText = "correo";
            this.correo.Name = "correo";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 320);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.ckbBorrar);
            this.Controls.Add(this.ckbActualizar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pcFoto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaElectronicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pcFoto;
        private System.Windows.Forms.Button btnFoto;
        private AgendaElectronicaDataSet agendaElectronicaDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private AgendaElectronicaDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.CheckBox ckbActualizar;
        private System.Windows.Forms.CheckBox ckbBorrar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
    }
}

