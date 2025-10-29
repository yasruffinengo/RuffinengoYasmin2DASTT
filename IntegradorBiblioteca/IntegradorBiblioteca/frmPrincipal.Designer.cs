namespace IntegradorBiblioteca
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
            button1 = new Button();
            button2 = new Button();
            dgvPrestamos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbSocio = new ComboBox();
            cmbLibro = new ComboBox();
            btnGuardarPrestamo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(457, 90);
            button1.Name = "button1";
            button1.Size = new Size(192, 32);
            button1.TabIndex = 0;
            button1.Text = "GESTION DE SOCIOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(457, 40);
            button2.Name = "button2";
            button2.Size = new Size(192, 32);
            button2.TabIndex = 1;
            button2.Text = "GESTION DE LIBROS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(12, 139);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(637, 425);
            dgvPrestamos.TabIndex = 2;
            dgvPrestamos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 3;
            label1.Text = "LISTA DE PRESTAMOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 179);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 4;
            label2.Text = "Registrar prestamo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 232);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Socio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 289);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Libro";
            // 
            // cmbSocio
            // 
            cmbSocio.FormattingEnabled = true;
            cmbSocio.Location = new Point(770, 224);
            cmbSocio.Name = "cmbSocio";
            cmbSocio.Size = new Size(180, 28);
            cmbSocio.TabIndex = 7;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(770, 281);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(180, 28);
            cmbLibro.TabIndex = 8;
            // 
            // btnGuardarPrestamo
            // 
            btnGuardarPrestamo.Location = new Point(848, 341);
            btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            btnGuardarPrestamo.Size = new Size(102, 41);
            btnGuardarPrestamo.TabIndex = 9;
            btnGuardarPrestamo.Text = "Guardar";
            btnGuardarPrestamo.UseVisualStyleBackColor = true;
            btnGuardarPrestamo.Click += btnGuardarPrestamo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 584);
            Controls.Add(btnGuardarPrestamo);
            Controls.Add(cmbLibro);
            Controls.Add(cmbSocio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPrestamos);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dgvPrestamos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbSocio;
        private ComboBox cmbLibro;
        private Button btnGuardarPrestamo;
    }
}
