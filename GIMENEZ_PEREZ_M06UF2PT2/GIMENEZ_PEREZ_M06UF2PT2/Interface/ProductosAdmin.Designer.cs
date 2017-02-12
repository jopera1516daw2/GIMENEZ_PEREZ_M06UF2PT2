namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class ProductosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosAdmin));
            this.btnAtras = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.RadioButton();
            this.crear = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lprecio = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(38, 214);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(74, 23);
            this.btnAtras.TabIndex = 26;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // eliminar
            // 
            this.eliminar.AutoSize = true;
            this.eliminar.Location = new System.Drawing.Point(177, 49);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(61, 17);
            this.eliminar.TabIndex = 25;
            this.eliminar.TabStop = true;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.CheckedChanged += new System.EventHandler(this.eliminar_CheckedChanged);
            // 
            // crear
            // 
            this.crear.AutoSize = true;
            this.crear.Checked = true;
            this.crear.Location = new System.Drawing.Point(84, 49);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(50, 17);
            this.crear.TabIndex = 24;
            this.crear.TabStop = true;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.CheckedChanged += new System.EventHandler(this.crear_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Location = new System.Drawing.Point(67, 140);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(37, 13);
            this.lprecio.TabIndex = 22;
            this.lprecio.Text = "Precio";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(119, 137);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Producto";
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(119, 95);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(100, 20);
            this.producto.TabIndex = 19;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msg.ForeColor = System.Drawing.Color.Green;
            this.msg.Location = new System.Drawing.Point(29, 177);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(224, 20);
            this.msg.TabIndex = 27;
            this.msg.Text = "Usuario creado correctamente";
            this.msg.Visible = false;
            // 
            // ProductosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lprecio);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductosAdmin";
            this.Text = "ProductosAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.RadioButton eliminar;
        private System.Windows.Forms.RadioButton crear;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Label msg;
    }
}