namespace VISTA
{
    partial class frmPrincipal
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
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCC = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(219, 44);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(834, 106);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(834, 169);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(834, 234);
            label4.Name = "label4";
            label4.Size = new Size(40, 22);
            label4.TabIndex = 3;
            label4.Text = "Dni";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(834, 297);
            label5.Name = "label5";
            label5.Size = new Size(85, 22);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            //label5.Click += this.label5_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(994, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 31);
            txtNombre.TabIndex = 5;
            //txtNombre.TextChanged += this.txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(994, 160);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(190, 31);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(994, 225);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(190, 31);
            txtDni.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(994, 292);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 31);
            txtTelefono.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(723, 510);
            dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F);
            label6.Location = new Point(935, 56);
            label6.Name = "label6";
            label6.Size = new Size(132, 22);
            label6.TabIndex = 10;
            label6.Text = "Nuevo cliente";
            //label6.Click += this.label6_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1066, 354);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 54);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(782, 474);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 54);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            //btnModificar.Click += this.button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(935, 474);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 54);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCC
            // 
            btnCC.Location = new Point(782, 542);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(271, 54);
            btnCC.TabIndex = 14;
            btnCC.Text = "Gestionar Cuentas";
            btnCC.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 610);
            Controls.Add(btnCC);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Inicio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCC;
    }
}
