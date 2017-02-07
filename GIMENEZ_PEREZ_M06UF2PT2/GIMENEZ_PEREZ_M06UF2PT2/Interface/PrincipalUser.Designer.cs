namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class PrincipalUser
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
            this.btPedido = new System.Windows.Forms.Button();
            this.btFactura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPedido
            // 
            this.btPedido.Location = new System.Drawing.Point(90, 49);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(102, 23);
            this.btPedido.TabIndex = 0;
            this.btPedido.Text = "Hacer pedido";
            this.btPedido.UseVisualStyleBackColor = true;
            this.btPedido.Click += new System.EventHandler(this.btPedido_Click);
            // 
            // btFactura
            // 
            this.btFactura.Location = new System.Drawing.Point(90, 91);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(102, 23);
            this.btFactura.TabIndex = 1;
            this.btFactura.Text = "Consultar facturas";
            this.btFactura.UseVisualStyleBackColor = true;
            this.btFactura.Click += new System.EventHandler(this.btFactura_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PrincipalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.btPedido);
            this.Name = "PrincipalUser";
            this.Text = "PrincipalUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button btFactura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}