namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class PrincipalAdmin
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
            this.btAdminUser = new System.Windows.Forms.Button();
            this.btAdminProductos = new System.Windows.Forms.Button();
            this.btAdminFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAdminUser
            // 
            this.btAdminUser.Location = new System.Drawing.Point(102, 46);
            this.btAdminUser.Name = "btAdminUser";
            this.btAdminUser.Size = new System.Drawing.Size(75, 23);
            this.btAdminUser.TabIndex = 0;
            this.btAdminUser.Text = "Usuarios";
            this.btAdminUser.UseVisualStyleBackColor = true;
            // 
            // btAdminProductos
            // 
            this.btAdminProductos.Location = new System.Drawing.Point(102, 109);
            this.btAdminProductos.Name = "btAdminProductos";
            this.btAdminProductos.Size = new System.Drawing.Size(75, 23);
            this.btAdminProductos.TabIndex = 1;
            this.btAdminProductos.Text = "Productos";
            this.btAdminProductos.UseVisualStyleBackColor = true;
            // 
            // btAdminFactura
            // 
            this.btAdminFactura.Location = new System.Drawing.Point(102, 171);
            this.btAdminFactura.Name = "btAdminFactura";
            this.btAdminFactura.Size = new System.Drawing.Size(75, 23);
            this.btAdminFactura.TabIndex = 2;
            this.btAdminFactura.Text = "Facturas";
            this.btAdminFactura.UseVisualStyleBackColor = true;
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btAdminFactura);
            this.Controls.Add(this.btAdminProductos);
            this.Controls.Add(this.btAdminUser);
            this.Name = "PrincipalAdmin";
            this.Text = "PrincipalAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdminUser;
        private System.Windows.Forms.Button btAdminProductos;
        private System.Windows.Forms.Button btAdminFactura;
    }
}