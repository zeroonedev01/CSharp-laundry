namespace Laundry
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESEMKA LAUNDRY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(156, 89);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(237, 20);
            this.t_email.TabIndex = 3;
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(156, 131);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(237, 20);
            this.t_pass.TabIndex = 4;
            this.t_pass.UseSystemPasswordChar = true;
            this.t_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_pass_KeyDown);
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.Teal;
            this.b_login.ForeColor = System.Drawing.Color.White;
            this.b_login.Location = new System.Drawing.Point(317, 178);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(76, 36);
            this.b_login.TabIndex = 5;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(475, 269);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Esemka Laundry : Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.Button b_login;
    }
}