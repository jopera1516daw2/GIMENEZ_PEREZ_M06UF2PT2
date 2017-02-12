namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class RestorePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorePass));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rpUser = new System.Windows.Forms.TextBox();
            this.rpNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgerror = new System.Windows.Forms.Label();
            this.msgconfirm = new System.Windows.Forms.Label();
            this.rpNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Modificar contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // rpUser
            // 
            this.rpUser.Location = new System.Drawing.Point(127, 70);
            this.rpUser.Name = "rpUser";
            this.rpUser.Size = new System.Drawing.Size(100, 20);
            this.rpUser.TabIndex = 9;
            // 
            // rpNewPassword
            // 
            this.rpNewPassword.Location = new System.Drawing.Point(127, 148);
            this.rpNewPassword.Name = "rpNewPassword";
            this.rpNewPassword.PasswordChar = '*';
            this.rpNewPassword.Size = new System.Drawing.Size(100, 20);
            this.rpNewPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nueva contraseña";
            // 
            // msgerror
            // 
            this.msgerror.AutoSize = true;
            this.msgerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msgerror.ForeColor = System.Drawing.Color.Red;
            this.msgerror.Location = new System.Drawing.Point(13, 182);
            this.msgerror.Name = "msgerror";
            this.msgerror.Size = new System.Drawing.Size(254, 20);
            this.msgerror.TabIndex = 16;
            this.msgerror.Text = "Usuario y/o contraseña incorrectos";
            this.msgerror.Visible = false;
            // 
            // msgconfirm
            // 
            this.msgconfirm.AutoSize = true;
            this.msgconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msgconfirm.ForeColor = System.Drawing.Color.Green;
            this.msgconfirm.Location = new System.Drawing.Point(67, 182);
            this.msgconfirm.Name = "msgconfirm";
            this.msgconfirm.Size = new System.Drawing.Size(177, 20);
            this.msgconfirm.TabIndex = 17;
            this.msgconfirm.Text = "Contraseña actualizada";
            this.msgconfirm.Visible = false;
            // 
            // rpNombre
            // 
            this.rpNombre.Location = new System.Drawing.Point(127, 109);
            this.rpNombre.Name = "rpNombre";
            this.rpNombre.PasswordChar = '*';
            this.rpNombre.Size = new System.Drawing.Size(100, 20);
            this.rpNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestorePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msgconfirm);
            this.Controls.Add(this.msgerror);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rpNewPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpNombre);
            this.Controls.Add(this.rpUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestorePass";
            this.Text = "RestorePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rpUser;
        private System.Windows.Forms.TextBox rpNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgerror;
        private System.Windows.Forms.Label msgconfirm;
        private System.Windows.Forms.TextBox rpNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}