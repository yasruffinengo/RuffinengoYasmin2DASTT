namespace VISTA
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
            dgvPartidas = new DataGridView();
            dgvJugadores = new DataGridView();
            label1 = new Label();
            txtNombreJugador = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // dgvPartidas
            // 
            dgvPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidas.Location = new Point(715, 73);
            dgvPartidas.Name = "dgvPartidas";
            dgvPartidas.RowHeadersWidth = 51;
            dgvPartidas.Size = new Size(559, 549);
            dgvPartidas.TabIndex = 0;
            dgvPartidas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(21, 73);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(348, 444);
            dgvJugadores.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 2;
            label1.Text = "Registro de jugadores";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(23, 556);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(255, 27);
            txtNombreJugador.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(23, 613);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(275, 654);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 705);
            Controls.Add(btnAgregar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombreJugador);
            Controls.Add(label1);
            Controls.Add(dgvJugadores);
            Controls.Add(dgvPartidas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPartidas;
        private DataGridView dgvJugadores;
        private Label label1;
        private TextBox txtNombreJugador;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAgregar;
    }
}
