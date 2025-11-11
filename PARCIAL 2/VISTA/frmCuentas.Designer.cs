namespace VISTA
{
    partial class frmCuentas
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
            dgvCuentasCliente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnNuevaCC = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCuentasCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCuentasCliente
            // 
            dgvCuentasCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentasCliente.Location = new Point(58, 185);
            dgvCuentasCliente.Name = "dgvCuentasCliente";
            dgvCuentasCliente.RowHeadersWidth = 62;
            dgvCuentasCliente.Size = new Size(599, 410);
            dgvCuentasCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(404, 44);
            label1.TabIndex = 1;
            label1.Text = "Cuentas Corrientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(58, 106);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(58, 142);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 3;
            label3.Text = "Dni:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(138, 106);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(138, 142);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // btnNuevaCC
            // 
            btnNuevaCC.Location = new Point(530, 107);
            btnNuevaCC.Name = "btnNuevaCC";
            btnNuevaCC.Size = new Size(127, 57);
            btnNuevaCC.TabIndex = 6;
            btnNuevaCC.Text = "Nueva CC";
            btnNuevaCC.UseVisualStyleBackColor = true;
            btnNuevaCC.Click += btnNuevaCC_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(707, 336);
            button3.Name = "button3";
            button3.Size = new Size(175, 67);
            button3.TabIndex = 8;
            button3.Text = "Registrar Movimiento";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(707, 517);
            button2.Name = "button2";
            button2.Size = new Size(175, 59);
            button2.TabIndex = 9;
            button2.Text = "Resumen Cuenta";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(707, 437);
            button4.Name = "button4";
            button4.Size = new Size(175, 62);
            button4.TabIndex = 10;
            button4.Text = "Historial de Movimientos";
            button4.UseVisualStyleBackColor = true;
            // 
            // frmCuentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 607);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnNuevaCC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCuentasCliente);
            Name = "frmCuentas";
            Text = "frmCuentas";
            Load += frmCuentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuentasCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCuentasCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnNuevaCC;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}