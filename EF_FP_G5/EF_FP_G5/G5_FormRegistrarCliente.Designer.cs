namespace EF_FP_G5
{
    partial class G5_FormRegistrarCliente
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
            this.G5_lblNombreCliente = new System.Windows.Forms.Label();
            this.G5_txtNombreCliente = new System.Windows.Forms.TextBox();
            this.G5_lblDNI = new System.Windows.Forms.Label();
            this.G5_txtDNI = new System.Windows.Forms.TextBox();
            this.G5_lblCelular = new System.Windows.Forms.Label();
            this.G5_txtCelular = new System.Windows.Forms.TextBox();
            this.G5_btnRegistrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // G5_lblNombreCliente
            // 
            this.G5_lblNombreCliente.AutoSize = true;
            this.G5_lblNombreCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_lblNombreCliente.Location = new System.Drawing.Point(12, 24);
            this.G5_lblNombreCliente.Name = "G5_lblNombreCliente";
            this.G5_lblNombreCliente.Size = new System.Drawing.Size(124, 33);
            this.G5_lblNombreCliente.TabIndex = 0;
            this.G5_lblNombreCliente.Text = "Nombre:";
            // 
            // G5_txtNombreCliente
            // 
            this.G5_txtNombreCliente.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_txtNombreCliente.Location = new System.Drawing.Point(123, 24);
            this.G5_txtNombreCliente.Name = "G5_txtNombreCliente";
            this.G5_txtNombreCliente.Size = new System.Drawing.Size(507, 28);
            this.G5_txtNombreCliente.TabIndex = 1;
            // 
            // G5_lblDNI
            // 
            this.G5_lblDNI.AutoSize = true;
            this.G5_lblDNI.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_lblDNI.Location = new System.Drawing.Point(53, 96);
            this.G5_lblDNI.Name = "G5_lblDNI";
            this.G5_lblDNI.Size = new System.Drawing.Size(58, 26);
            this.G5_lblDNI.TabIndex = 2;
            this.G5_lblDNI.Text = "DNI:";
            // 
            // G5_txtDNI
            // 
            this.G5_txtDNI.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_txtDNI.Location = new System.Drawing.Point(123, 94);
            this.G5_txtDNI.Name = "G5_txtDNI";
            this.G5_txtDNI.Size = new System.Drawing.Size(152, 28);
            this.G5_txtDNI.TabIndex = 3;
            // 
            // G5_lblCelular
            // 
            this.G5_lblCelular.AutoSize = true;
            this.G5_lblCelular.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_lblCelular.Location = new System.Drawing.Point(22, 161);
            this.G5_lblCelular.Name = "G5_lblCelular";
            this.G5_lblCelular.Size = new System.Drawing.Size(89, 26);
            this.G5_lblCelular.TabIndex = 4;
            this.G5_lblCelular.Text = "Celular:";
            // 
            // G5_txtCelular
            // 
            this.G5_txtCelular.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_txtCelular.Location = new System.Drawing.Point(123, 161);
            this.G5_txtCelular.Name = "G5_txtCelular";
            this.G5_txtCelular.Size = new System.Drawing.Size(152, 28);
            this.G5_txtCelular.TabIndex = 5;
            // 
            // G5_btnRegistrarCliente
            // 
            this.G5_btnRegistrarCliente.BackColor = System.Drawing.Color.DarkGray;
            this.G5_btnRegistrarCliente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5_btnRegistrarCliente.Location = new System.Drawing.Point(524, 139);
            this.G5_btnRegistrarCliente.Name = "G5_btnRegistrarCliente";
            this.G5_btnRegistrarCliente.Size = new System.Drawing.Size(160, 65);
            this.G5_btnRegistrarCliente.TabIndex = 6;
            this.G5_btnRegistrarCliente.Text = "Registrar";
            this.G5_btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.G5_btnRegistrarCliente.Click += new System.EventHandler(this.G5_btnRegistrarCliente_Click);
            // 
            // G5_FormRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.G5_btnRegistrarCliente);
            this.Controls.Add(this.G5_txtCelular);
            this.Controls.Add(this.G5_lblCelular);
            this.Controls.Add(this.G5_txtDNI);
            this.Controls.Add(this.G5_lblDNI);
            this.Controls.Add(this.G5_txtNombreCliente);
            this.Controls.Add(this.G5_lblNombreCliente);
            this.Name = "G5_FormRegistrarCliente";
            this.Text = "Registrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label G5_lblNombreCliente;
        private System.Windows.Forms.TextBox G5_txtNombreCliente;
        private System.Windows.Forms.Label G5_lblDNI;
        private System.Windows.Forms.TextBox G5_txtDNI;
        private System.Windows.Forms.Label G5_lblCelular;
        private System.Windows.Forms.TextBox G5_txtCelular;
        private System.Windows.Forms.Button G5_btnRegistrarCliente;
    }
}