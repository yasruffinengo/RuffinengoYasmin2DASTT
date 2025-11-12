namespace VISTA
{
    partial class frmResumen
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
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            dgvMovimientosResumen = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientosResumen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(75, 167);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 0;
            label1.Text = "Id cuenta:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Verdana", 9F);
            lbl1.Location = new Point(230, 167);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(53, 22);
            lbl1.TabIndex = 1;
            lbl1.Text = "label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 159);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(75, 222);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 3;
            label3.Text = "Total crédito:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(75, 280);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 4;
            label4.Text = "Total débito:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(75, 332);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 5;
            label5.Text = "Saldo actual:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Verdana", 9F);
            lbl2.Location = new Point(230, 222);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(53, 22);
            lbl2.TabIndex = 6;
            lbl2.Text = "label";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Verdana", 9F);
            lbl3.Location = new Point(230, 280);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(53, 22);
            lbl3.TabIndex = 7;
            lbl3.Text = "label";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Verdana", 9F);
            lbl4.Location = new Point(230, 332);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(53, 22);
            lbl4.TabIndex = 8;
            lbl4.Text = "label";
            // 
            // dgvMovimientosResumen
            // 
            dgvMovimientosResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientosResumen.Location = new Point(377, 40);
            dgvMovimientosResumen.Name = "dgvMovimientosResumen";
            dgvMovimientosResumen.RowHeadersWidth = 62;
            dgvMovimientosResumen.Size = new Size(785, 446);
            dgvMovimientosResumen.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold);
            label6.Location = new Point(75, 77);
            label6.Name = "label6";
            label6.Size = new Size(216, 44);
            label6.TabIndex = 10;
            label6.Text = "RESUMEN";
            // 
            // frmResumen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 537);
            Controls.Add(label6);
            Controls.Add(dgvMovimientosResumen);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Name = "frmResumen";
            Text = "frmResumen";
            Load += frmResumen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientosResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected internal Label label1;
        protected internal Label lbl1;
        private Label label2;
        protected internal Label label3;
        protected internal Label label4;
        protected internal Label label5;
        protected internal Label lbl2;
        protected internal Label lbl3;
        protected internal Label lbl4;
        private DataGridView dgvMovimientosResumen;
        private Label label6;
    }
}