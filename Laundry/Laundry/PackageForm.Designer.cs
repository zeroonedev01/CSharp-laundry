namespace Laundry
{
    partial class PackageForm
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
            this.cmb_package = new System.Windows.Forms.ComboBox();
            this.t_harga = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.t_eid = new System.Windows.Forms.TextBox();
            this.b_insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_alamat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_nama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_package
            // 
            this.cmb_package.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_package.FormattingEnabled = true;
            this.cmb_package.Location = new System.Drawing.Point(122, 327);
            this.cmb_package.Name = "cmb_package";
            this.cmb_package.Size = new System.Drawing.Size(349, 21);
            this.cmb_package.TabIndex = 85;
            this.cmb_package.SelectedIndexChanged += new System.EventHandler(this.cmb_package_SelectedIndexChanged);
            // 
            // t_harga
            // 
            this.t_harga.Location = new System.Drawing.Point(469, 297);
            this.t_harga.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(171, 20);
            this.t_harga.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(382, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Price";
            // 
            // t_eid
            // 
            this.t_eid.Enabled = false;
            this.t_eid.Location = new System.Drawing.Point(122, 297);
            this.t_eid.Name = "t_eid";
            this.t_eid.Size = new System.Drawing.Size(223, 20);
            this.t_eid.TabIndex = 79;
            // 
            // b_insert
            // 
            this.b_insert.BackColor = System.Drawing.Color.Teal;
            this.b_insert.ForeColor = System.Drawing.Color.White;
            this.b_insert.Location = new System.Drawing.Point(668, 291);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(83, 31);
            this.b_insert.TabIndex = 74;
            this.b_insert.Text = "Submit";
            this.b_insert.UseVisualStyleBackColor = false;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Package";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Prepaid ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 187);
            this.dataGridView1.TabIndex = 69;
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(572, 71);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(179, 20);
            this.t_cari.TabIndex = 68;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Search";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(236, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Transaction Prepaid Package";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_alamat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t_nama);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.t_phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(28, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 100);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // t_alamat
            // 
            this.t_alamat.AutoSize = true;
            this.t_alamat.ForeColor = System.Drawing.Color.White;
            this.t_alamat.Location = new System.Drawing.Point(460, 64);
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(45, 13);
            this.t_alamat.TabIndex = 94;
            this.t_alamat.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = " ";
            // 
            // t_nama
            // 
            this.t_nama.AutoSize = true;
            this.t_nama.ForeColor = System.Drawing.Color.White;
            this.t_nama.Location = new System.Drawing.Point(460, 36);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(35, 13);
            this.t_nama.TabIndex = 92;
            this.t_nama.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(375, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(375, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Name :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(18, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not Found ? Add New +";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // t_phone
            // 
            this.t_phone.Location = new System.Drawing.Point(102, 29);
            this.t_phone.Name = "t_phone";
            this.t_phone.Size = new System.Drawing.Size(181, 20);
            this.t_phone.TabIndex = 89;
            this.t_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_phone_KeyDown);
            this.t_phone.Leave += new System.EventHandler(this.t_phone_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(413, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Price";
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(765, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_package);
            this.Controls.Add(this.t_harga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t_eid);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "PackageForm";
            this.Text = "PackageForm";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_package;
        private System.Windows.Forms.NumericUpDown t_harga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t_eid;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label t_alamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t_nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox t_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}