namespace IntegradorBiblioteca
{
    partial class frmLibros
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
            dgvLibros = new DataGridView();
            label5 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtEstado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 71);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 132);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 192);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 248);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(34, 59);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(511, 466);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 25);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 5;
            label5.Text = "LISTA DE LIBROS";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(723, 481);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 44);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(595, 481);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 44);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(723, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 44);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(667, 64);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(168, 27);
            txtISBN.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(667, 125);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(168, 27);
            txtTitulo.TabIndex = 17;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(667, 185);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(168, 27);
            txtAutor.TabIndex = 18;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(667, 241);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(168, 27);
            txtEstado.TabIndex = 19;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 572);
            Controls.Add(txtEstado);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtISBN);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(dgvLibros);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "frmLibros";
            Load += frmLibros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvLibros;
        private Label label5;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtISBN;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtEstado;
    }
}