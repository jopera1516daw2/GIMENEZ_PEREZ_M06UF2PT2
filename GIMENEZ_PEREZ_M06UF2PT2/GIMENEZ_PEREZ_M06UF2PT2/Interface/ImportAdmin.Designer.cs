namespace GIMENEZ_PEREZ_M06UF2PT2.Interface
{
    partial class ImportAdmin
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
            this.button2 = new System.Windows.Forms.Button();
            this.dropandcreate = new System.Windows.Forms.Button();
            this.merge = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dropandcreate
            // 
            this.dropandcreate.Location = new System.Drawing.Point(95, 78);
            this.dropandcreate.Name = "dropandcreate";
            this.dropandcreate.Size = new System.Drawing.Size(101, 23);
            this.dropandcreate.TabIndex = 20;
            this.dropandcreate.Text = "Drop and create";
            this.dropandcreate.UseVisualStyleBackColor = true;
            this.dropandcreate.Click += new System.EventHandler(this.dropandcreate_Click);
            // 
            // merge
            // 
            this.merge.Location = new System.Drawing.Point(92, 119);
            this.merge.Name = "merge";
            this.merge.Size = new System.Drawing.Size(101, 23);
            this.merge.TabIndex = 21;
            this.merge.Text = "Merge";
            this.merge.UseVisualStyleBackColor = true;
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(92, 158);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(101, 23);
            this.undo.TabIndex = 22;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = true;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msg.ForeColor = System.Drawing.Color.Green;
            this.msg.Location = new System.Drawing.Point(63, 206);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(161, 20);
            this.msg.TabIndex = 28;
            this.msg.Text = "Importación realizada";
            this.msg.Visible = false;
            // 
            // ImportAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.merge);
            this.Controls.Add(this.dropandcreate);
            this.Controls.Add(this.button2);
            this.Name = "ImportAdmin";
            this.Text = "ImportAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dropandcreate;
        private System.Windows.Forms.Button merge;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Label msg;
    }
}