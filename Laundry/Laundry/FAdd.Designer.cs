namespace Laundry
{
    partial class FAdd
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
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_alamat = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(150, 110);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(244, 20);
            this.t_hp.TabIndex = 29;
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(150, 75);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(244, 20);
            this.t_name.TabIndex = 28;
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(150, 144);
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(244, 60);
            this.t_alamat.TabIndex = 27;
            this.t_alamat.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phune Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(63, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Add New";
            // 
            // b_insert
            // 
            this.b_insert.BackColor = System.Drawing.Color.Teal;
            this.b_insert.ForeColor = System.Drawing.Color.White;
            this.b_insert.Location = new System.Drawing.Point(311, 219);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(83, 31);
            this.b_insert.TabIndex = 31;
            this.b_insert.Text = "Add";
            this.b_insert.UseVisualStyleBackColor = false;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // FAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(480, 290);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_alamat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAdd";
            this.Text = "FAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.RichTextBox t_alamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_insert;
    }
}