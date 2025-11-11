namespace IntegradorBiblioteca
{
    partial class frmSocios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            dgvSocios = new DataGridView();
            label5 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(850, 155);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(850, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(850, 321);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(850, 405);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(1011, 146);
            txtDni.Margin = new Padding(4, 4, 4, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(198, 31);
            txtDni.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1011, 228);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1011, 312);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1011, 396);
            txtTelefono.Margin = new Padding(4, 4, 4, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(198, 31);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1070, 468);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 55);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(75, 136);
            dgvSocios.Margin = new Padding(4, 4, 4, 4);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.Size = new Size(742, 575);
            dgvSocios.TabIndex = 9;
            dgvSocios.CellContentClick += dgvSocios_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 10;
            label5.Text = "LISTA DE SOCIOS";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(910, 656);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 55);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1070, 656);
            btnEliminar.Margin = new Padding(4, 4, 4, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 55);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 802);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(dgvSocios);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmSocios";
            Text = "frmSocios";
            Load += frmSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnGuardar;
        private DataGridView dgvSocios;
        private Label label5;
        private Button btnEditar;
        private Button btnEliminar;
    }
}