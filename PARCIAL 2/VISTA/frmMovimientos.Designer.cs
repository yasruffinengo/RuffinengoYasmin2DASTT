namespace VISTA
{
    partial class frmMovimientos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            dgvMovimientos = new DataGridView();
            btnGuardar = new Button();
            label6 = new Label();
            cbSubtipo = new ComboBox();
            lblCC = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(865, 142);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(865, 211);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 2;
            label3.Text = "Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(865, 275);
            label4.Name = "label4";
            label4.Size = new Size(113, 22);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(865, 351);
            label5.Name = "label5";
            label5.Size = new Size(48, 22);
            label5.TabIndex = 4;
            label5.Text = "Tipo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(1016, 340);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(239, 33);
            cbTipo.TabIndex = 5;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(1016, 133);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(239, 31);
            dtpFecha.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(1016, 266);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(239, 31);
            txtDescripcion.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(1016, 202);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(239, 31);
            txtMonto.TabIndex = 8;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(31, 135);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 62;
            dgvMovimientos.Size = new Size(785, 421);
            dgvMovimientos.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1122, 479);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 48);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label6.Location = new Point(31, 28);
            label6.Name = "label6";
            label6.Size = new Size(323, 44);
            label6.TabIndex = 11;
            label6.Text = "MOVIMIENTOS";
            // 
            // cbSubtipo
            // 
            cbSubtipo.FormattingEnabled = true;
            cbSubtipo.Location = new Point(1016, 399);
            cbSubtipo.Name = "cbSubtipo";
            cbSubtipo.Size = new Size(239, 33);
            cbSubtipo.TabIndex = 12;
            // 
            // lblCC
            // 
            lblCC.AutoSize = true;
            lblCC.Font = new Font("Verdana", 10F, FontStyle.Bold);
            lblCC.ForeColor = SystemColors.MenuHighlight;
            lblCC.Location = new Point(31, 92);
            lblCC.Name = "lblCC";
            lblCC.Size = new Size(80, 25);
            lblCC.TabIndex = 13;
            lblCC.Text = "label7";
            // 
            // frmMovimientos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 616);
            Controls.Add(lblCC);
            Controls.Add(cbSubtipo);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(dgvMovimientos);
            Controls.Add(txtMonto);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFecha);
            Controls.Add(cbTipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmMovimientos";
            Text = "Movimientos";
            Load += frmMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbTipo;
        private DateTimePicker dtpFecha;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private DataGridView dgvMovimientos;
        private Button btnGuardar;
        private Label label6;
        private ComboBox cbSubtipo;
        private Label lblCC;
    }
}