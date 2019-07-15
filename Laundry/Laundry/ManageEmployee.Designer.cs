namespace Laundry
{
    partial class ManageEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.b_insert = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.t_eid = new System.Windows.Forms.TextBox();
            this.t_alamat = new System.Windows.Forms.RichTextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_lahir = new System.Windows.Forms.DateTimePicker();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.t_cpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.t_gaji = new System.Windows.Forms.NumericUpDown();
            this.cmb_job = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_gaji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(499, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(571, 60);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(179, 20);
            this.t_cari.TabIndex = 3;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 187);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phune Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(442, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Job";
            // 
            // b_insert
            // 
            this.b_insert.BackColor = System.Drawing.Color.Teal;
            this.b_insert.ForeColor = System.Drawing.Color.White;
            this.b_insert.Location = new System.Drawing.Point(437, 434);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(83, 31);
            this.b_insert.TabIndex = 15;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = false;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_update
            // 
            this.b_update.BackColor = System.Drawing.Color.Teal;
            this.b_update.ForeColor = System.Drawing.Color.White;
            this.b_update.Location = new System.Drawing.Point(526, 434);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(83, 31);
            this.b_update.TabIndex = 16;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.Teal;
            this.b_cancel.ForeColor = System.Drawing.Color.White;
            this.b_cancel.Location = new System.Drawing.Point(586, 471);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(83, 31);
            this.b_cancel.TabIndex = 17;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Teal;
            this.b_delete.ForeColor = System.Drawing.Color.White;
            this.b_delete.Location = new System.Drawing.Point(615, 434);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(83, 31);
            this.b_delete.TabIndex = 17;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.Teal;
            this.b_save.ForeColor = System.Drawing.Color.White;
            this.b_save.Location = new System.Drawing.Point(472, 471);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(83, 31);
            this.b_save.TabIndex = 18;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // t_eid
            // 
            this.t_eid.Enabled = false;
            this.t_eid.Location = new System.Drawing.Point(121, 286);
            this.t_eid.Name = "t_eid";
            this.t_eid.Size = new System.Drawing.Size(223, 20);
            this.t_eid.TabIndex = 19;
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(121, 405);
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(223, 60);
            this.t_alamat.TabIndex = 20;
            this.t_alamat.Text = "";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(121, 316);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(223, 20);
            this.t_name.TabIndex = 21;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(121, 346);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(223, 20);
            this.t_email.TabIndex = 22;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(121, 376);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(223, 20);
            this.t_hp.TabIndex = 23;
            // 
            // t_lahir
            // 
            this.t_lahir.CustomFormat = "yyyy-MM-dd";
            this.t_lahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.t_lahir.Location = new System.Drawing.Point(121, 477);
            this.t_lahir.Name = "t_lahir";
            this.t_lahir.Size = new System.Drawing.Size(223, 20);
            this.t_lahir.TabIndex = 24;
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(502, 353);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(223, 20);
            this.t_pass.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(420, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Password";
            // 
            // t_cpass
            // 
            this.t_cpass.Location = new System.Drawing.Point(502, 380);
            this.t_cpass.Name = "t_cpass";
            this.t_cpass.Size = new System.Drawing.Size(223, 20);
            this.t_cpass.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(382, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(430, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Salary";
            // 
            // t_gaji
            // 
            this.t_gaji.Location = new System.Drawing.Point(502, 321);
            this.t_gaji.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.t_gaji.Name = "t_gaji";
            this.t_gaji.Size = new System.Drawing.Size(223, 20);
            this.t_gaji.TabIndex = 31;
            // 
            // cmb_job
            // 
            this.cmb_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_job.FormattingEnabled = true;
            this.cmb_job.Location = new System.Drawing.Point(502, 290);
            this.cmb_job.Name = "cmb_job";
            this.cmb_job.Size = new System.Drawing.Size(223, 21);
            this.cmb_job.TabIndex = 32;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(765, 522);
            this.Controls.Add(this.cmb_job);
            this.Controls.Add(this.t_gaji);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t_cpass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t_lahir);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_alamat);
            this.Controls.Add(this.t_eid);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_gaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox t_eid;
        private System.Windows.Forms.RichTextBox t_alamat;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.DateTimePicker t_lahir;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox t_cpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown t_gaji;
        private System.Windows.Forms.ComboBox cmb_job;
    }
}