namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class PedidosNextUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosNextUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.finalizar = new System.Windows.Forms.Button();
            this.msgerror = new System.Windows.Forms.Label();
            this.msgCorrect = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // producto
            // 
            this.producto.Enabled = false;
            this.producto.Location = new System.Drawing.Point(85, 28);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(126, 20);
            this.producto.TabIndex = 3;
            // 
            // cantidad
            // 
            this.cantidad.Enabled = false;
            this.cantidad.Location = new System.Drawing.Point(289, 28);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(26, 20);
            this.cantidad.TabIndex = 4;
            // 
            // precio
            // 
            this.precio.Enabled = false;
            this.precio.Location = new System.Drawing.Point(385, 28);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(26, 20);
            this.precio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.Enabled = false;
            this.usuario.Location = new System.Drawing.Point(85, 84);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(126, 20);
            this.usuario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(302, 84);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(109, 20);
            this.password.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(85, 144);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(326, 20);
            this.direccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(85, 194);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(198, 20);
            this.fecha.TabIndex = 13;
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(314, 194);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(97, 23);
            this.finalizar.TabIndex = 14;
            this.finalizar.Text = "Finalizar pedido";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgerror
            // 
            this.msgerror.AutoSize = true;
            this.msgerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msgerror.ForeColor = System.Drawing.Color.Red;
            this.msgerror.Location = new System.Drawing.Point(50, 229);
            this.msgerror.Name = "msgerror";
            this.msgerror.Size = new System.Drawing.Size(44, 20);
            this.msgerror.TabIndex = 15;
            this.msgerror.Text = "Error";
            this.msgerror.Visible = false;
            // 
            // msgCorrect
            // 
            this.msgCorrect.AutoSize = true;
            this.msgCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msgCorrect.ForeColor = System.Drawing.Color.Green;
            this.msgCorrect.Location = new System.Drawing.Point(50, 229);
            this.msgCorrect.Name = "msgCorrect";
            this.msgCorrect.Size = new System.Drawing.Size(233, 20);
            this.msgCorrect.TabIndex = 16;
            this.msgCorrect.Text = "Pedido realizado correctamente";
            this.msgCorrect.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PedidosNextUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgCorrect);
            this.Controls.Add(this.msgerror);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PedidosNextUser";
            this.Text = "PedidosNextUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Label msgerror;
        private System.Windows.Forms.Label msgCorrect;
        private System.Windows.Forms.Button button1;
    }
}