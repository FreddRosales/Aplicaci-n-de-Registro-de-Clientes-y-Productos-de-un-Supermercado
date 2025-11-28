namespace EF_FP_G5
{
    partial class G5_FormAsignarProducto
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
            this.G5_btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // G5_btnTotal
            // 
            this.G5_btnTotal.BackColor = System.Drawing.Color.DarkGray;
            this.G5_btnTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_btnTotal.Location = new System.Drawing.Point(646, 358);
            this.G5_btnTotal.Name = "G5_btnTotal";
            this.G5_btnTotal.Size = new System.Drawing.Size(132, 49);
            this.G5_btnTotal.TabIndex = 0;
            this.G5_btnTotal.Text = "Total";
            this.G5_btnTotal.UseVisualStyleBackColor = false;
            // 
            // G5_FormAsignarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.G5_btnTotal);
            this.Name = "G5_FormAsignarProducto";
            this.Text = "Asignar Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button G5_btnTotal;
    }
}