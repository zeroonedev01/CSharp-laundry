namespace Laundry
{
    partial class Transaction_Deposit
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
            this.components = new System.ComponentModel.Container();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.t_price = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_harga = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cek_prepaid = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_alamat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_nama = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t_time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t_totalwaktu = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(103, 157);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(181, 21);
            this.cmb_category.TabIndex = 85;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // t_price
            // 
            this.t_price.Enabled = false;
            this.t_price.Location = new System.Drawing.Point(103, 188);
            this.t_price.Name = "t_price";
            this.t_price.Size = new System.Drawing.Size(181, 20);
            this.t_price.TabIndex = 80;
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.Teal;
            this.b_add.ForeColor = System.Drawing.Color.White;
            this.b_add.Location = new System.Drawing.Point(103, 268);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(83, 31);
            this.b_add.TabIndex = 78;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_submit
            // 
            this.b_submit.BackColor = System.Drawing.Color.Teal;
            this.b_submit.ForeColor = System.Drawing.Color.White;
            this.b_submit.Location = new System.Drawing.Point(791, 420);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(83, 31);
            this.b_submit.TabIndex = 74;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = false;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Total Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Price Per Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Service";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 187);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // t_harga
            // 
            this.t_harga.Location = new System.Drawing.Point(103, 218);
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(181, 20);
            this.t_harga.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(371, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Transaction Deposit";
            // 
            // cek_prepaid
            // 
            this.cek_prepaid.AutoSize = true;
            this.cek_prepaid.Enabled = false;
            this.cek_prepaid.ForeColor = System.Drawing.Color.White;
            this.cek_prepaid.Location = new System.Drawing.Point(103, 245);
            this.cek_prepaid.Name = "cek_prepaid";
            this.cek_prepaid.Size = new System.Drawing.Size(129, 17);
            this.cek_prepaid.TabIndex = 86;
            this.cek_prepaid.Text = "Use Prepaid package";
            this.cek_prepaid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_alamat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.t_nama);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.t_cari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 100);
            this.groupBox1.TabIndex = 87;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(460, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = " ";
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
            // t_cari
            // 
            this.t_cari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.t_cari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.t_cari.Location = new System.Drawing.Point(102, 29);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(181, 20);
            this.t_cari.TabIndex = 89;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            this.t_cari.Leave += new System.EventHandler(this.t_cari_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Service Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t_time
            // 
            this.t_time.AutoSize = true;
            this.t_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_time.ForeColor = System.Drawing.Color.White;
            this.t_time.Location = new System.Drawing.Point(142, 376);
            this.t_time.Name = "t_time";
            this.t_time.Size = new System.Drawing.Size(111, 18);
            this.t_time.TabIndex = 88;
            this.t_time.Text = "Current Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(586, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 89;
            this.label7.Text = "Total Pay :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(535, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 90;
            this.label10.Text = "Estimation Time :";
            // 
            // t_totalwaktu
            // 
            this.t_totalwaktu.AutoSize = true;
            this.t_totalwaktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_totalwaktu.ForeColor = System.Drawing.Color.White;
            this.t_totalwaktu.Location = new System.Drawing.Point(681, 387);
            this.t_totalwaktu.Name = "t_totalwaktu";
            this.t_totalwaktu.Size = new System.Drawing.Size(17, 18);
            this.t_totalwaktu.TabIndex = 92;
            this.t_totalwaktu.Text = "0";
            this.t_totalwaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_total
            // 
            this.t_total.AutoSize = true;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.ForeColor = System.Drawing.Color.White;
            this.t_total.Location = new System.Drawing.Point(681, 360);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(17, 18);
            this.t_total.TabIndex = 91;
            this.t_total.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 93;
            this.label13.Text = "Current Time:";
            // 
            // Transaction_Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(886, 457);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t_totalwaktu);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cek_prepaid);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.t_harga);
            this.Controls.Add(this.t_price);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Transaction_Deposit";
            this.Text = "Transaction_Deposit";
            this.Load += new System.EventHandler(this.Transaction_Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox t_price;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown t_harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cek_prepaid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label t_nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label t_alamat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label t_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label t_totalwaktu;
        private System.Windows.Forms.Label t_total;
        private System.Windows.Forms.Label label13;
    }
}