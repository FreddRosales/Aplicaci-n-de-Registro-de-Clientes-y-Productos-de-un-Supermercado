namespace EF_FP_G5
{
    partial class G5_FormMostrarProductos
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
            this.G5_dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.G5_dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // G5_dgvProductos
            // 
            this.G5_dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G5_dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.G5_dgvProductos.Name = "G5_dgvProductos";
            this.G5_dgvProductos.RowHeadersWidth = 51;
            this.G5_dgvProductos.RowTemplate.Height = 24;
            this.G5_dgvProductos.Size = new System.Drawing.Size(776, 337);
            this.G5_dgvProductos.TabIndex = 0;
            // 
            // G5_FormMostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(799, 360);
            this.Controls.Add(this.G5_dgvProductos);
            this.Name = "G5_FormMostrarProductos";
            this.Text = "Mostrar Productos";
            this.Load += new System.EventHandler(this.G5_FormMostrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G5_dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView G5_dgvProductos;
    }
}