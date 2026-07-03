namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtNacimiento = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            cmbGenero = new ComboBox();
            cmbEstado = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtTelefono = new TextBox();
            txtMovil = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            dgvContactos = new DataGridView();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 130);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(164, 26);
            label3.Name = "label3";
            label3.Size = new Size(245, 15);
            label3.TabIndex = 2;
            label3.Text = "Bienvenido a la Agenda electronica";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(106, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(49, 207);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(200, 23);
            dtNacimiento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 174);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 272);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 7;
            label5.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(138, 267);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 96);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(426, 93);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 10;
            cmbGenero.SelectedIndexChanged += Form1_Load;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a" });
            cmbEstado.Location = new Point(426, 135);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 11;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 138);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 12;
            label7.Text = "Estado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(367, 231);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 13;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 275);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 14;
            label9.Text = "Correo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(372, 183);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 15;
            label10.Text = "Movil";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(426, 228);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 16;
            txtTelefono.TextChanged += textBox4_TextChanged;
            // 
            // txtMovil
            // 
            txtMovil.Location = new Point(426, 183);
            txtMovil.Name = "txtMovil";
            txtMovil.Size = new Size(100, 23);
            txtMovil.TabIndex = 17;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(427, 272);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(25, 337);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(131, 337);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(234, 337);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(334, 337);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvContactos
            // 
            dgvContactos.BackgroundColor = SystemColors.Control;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(12, 378);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.Size = new Size(623, 182);
            dgvContactos.TabIndex = 23;
            dgvContactos.CellClick += dgvContactos_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(442, 337);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(647, 572);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvContactos);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtMovil);
            Controls.Add(txtTelefono);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbEstado);
            Controls.Add(cmbGenero);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agenda Electronica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtNacimiento;
        private Label label4;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private ComboBox cmbGenero;
        private ComboBox cmbEstado;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtTelefono;
        private TextBox txtMovil;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView dgvContactos;
        private Button btnLimpiar;
    }
}
