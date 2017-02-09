namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class UsersAdmin
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
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.crear = new System.Windows.Forms.RadioButton();
            this.eliminar = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(119, 95);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(119, 137);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // crear
            // 
            this.crear.AutoSize = true;
            this.crear.Checked = true;
            this.crear.Location = new System.Drawing.Point(84, 49);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(50, 17);
            this.crear.TabIndex = 5;
            this.crear.TabStop = true;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.CheckedChanged += new System.EventHandler(this.crear_CheckedChanged);
            // 
            // eliminar
            // 
            this.eliminar.AutoSize = true;
            this.eliminar.Location = new System.Drawing.Point(177, 49);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(61, 17);
            this.eliminar.TabIndex = 6;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.CheckedChanged += new System.EventHandler(this.eliminar_CheckedChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(38, 214);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(74, 23);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msg.ForeColor = System.Drawing.Color.Green;
            this.msg.Location = new System.Drawing.Point(34, 178);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(224, 20);
            this.msg.TabIndex = 19;
            this.msg.Text = "Usuario creado correctamente";
            this.msg.Visible = false;
            // 
            // UsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Name = "UsersAdmin";
            this.Text = "UsersAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton crear;
        private System.Windows.Forms.RadioButton eliminar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label msg;
    }
}