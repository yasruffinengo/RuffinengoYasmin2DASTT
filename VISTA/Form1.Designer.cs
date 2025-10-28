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
            dgvProyecto = new DataGridView();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // dgvProyecto
            // 
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Location = new Point(330, 53);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.RowHeadersWidth = 51;
            dgvProyecto.Size = new Size(392, 352);
            dgvProyecto.TabIndex = 0;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(28, 53);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(dgvProyecto);
            Name = "Form1";
            Text = "Proyectos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProyecto;
        private Button btnNuevo;
    }
}
