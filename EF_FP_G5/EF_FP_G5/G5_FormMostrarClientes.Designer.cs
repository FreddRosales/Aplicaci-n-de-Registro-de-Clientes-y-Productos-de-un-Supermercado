namespace EF_FP_G5
{
    partial class G5_FormMostrarClientes
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
            this.G5_dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.G5_dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // G5_dgvClientes
            // 
            this.G5_dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G5_dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.G5_dgvClientes.Name = "G5_dgvClientes";
            this.G5_dgvClientes.RowHeadersWidth = 51;
            this.G5_dgvClientes.RowTemplate.Height = 24;
            this.G5_dgvClientes.Size = new System.Drawing.Size(776, 426);
            this.G5_dgvClientes.TabIndex = 0;
            // 
            // G5_FormMostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.G5_dgvClientes);
            this.Name = "G5_FormMostrarClientes";
            this.Text = "Mostrar Clientes";
            this.Load += new System.EventHandler(this.G5_FormMostrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G5_dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView G5_dgvClientes;
    }
}