namespace Laundry
{
    partial class ManageService
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
            this.t_harga = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_eid = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.t_kira2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_kira2)).BeginInit();
            this.SuspendLayout();
            // 
            // t_harga
            // 
            this.t_harga.Location = new System.Drawing.Point(494, 290);
            this.t_harga.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(171, 20);
            this.t_harga.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(407, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(671, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "/ Per Unit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(407, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Estimation Time";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(122, 315);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(223, 20);
            this.t_name.TabIndex = 51;
            // 
            // t_eid
            // 
            this.t_eid.Enabled = false;
            this.t_eid.Location = new System.Drawing.Point(122, 285);
            this.t_eid.Name = "t_eid";
            this.t_eid.Size = new System.Drawing.Size(223, 20);
            this.t_eid.TabIndex = 49;
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.Teal;
            this.b_save.ForeColor = System.Drawing.Color.White;
            this.b_save.Location = new System.Drawing.Point(480, 393);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(83, 31);
            this.b_save.TabIndex = 48;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Teal;
            this.b_delete.ForeColor = System.Drawing.Color.White;
            this.b_delete.Location = new System.Drawing.Point(623, 356);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(83, 31);
            this.b_delete.TabIndex = 47;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.Teal;
            this.b_cancel.ForeColor = System.Drawing.Color.White;
            this.b_cancel.Location = new System.Drawing.Point(594, 393);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(83, 31);
            this.b_cancel.TabIndex = 46;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_update
            // 
            this.b_update.BackColor = System.Drawing.Color.Teal;
            this.b_update.ForeColor = System.Drawing.Color.White;
            this.b_update.Location = new System.Drawing.Point(534, 356);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(83, 31);
            this.b_update.TabIndex = 45;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = false;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_insert
            // 
            this.b_insert.BackColor = System.Drawing.Color.Teal;
            this.b_insert.ForeColor = System.Drawing.Color.White;
            this.b_insert.Location = new System.Drawing.Point(445, 356);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(83, 31);
            this.b_insert.TabIndex = 44;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = false;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Service Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ServiceID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 187);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(572, 59);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(179, 20);
            this.t_cari.TabIndex = 35;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Manage Service";
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(122, 344);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(223, 21);
            this.cmb_category.TabIndex = 62;
            // 
            // cmb_unit
            // 
            this.cmb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Location = new System.Drawing.Point(122, 379);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(223, 21);
            this.cmb_unit.TabIndex = 63;
            // 
            // t_kira2
            // 
            this.t_kira2.Location = new System.Drawing.Point(494, 324);
            this.t_kira2.Maximum = new decimal(new int[] {
            8640,
            0,
            0,
            0});
            this.t_kira2.Name = "t_kira2";
            this.t_kira2.Size = new System.Drawing.Size(171, 20);
            this.t_kira2.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(671, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Hours";
            // 
            // ManageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(765, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_kira2);
            this.Controls.Add(this.cmb_unit);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.t_harga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.t_eid);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageService";
            this.Text = "ManageService";
            this.Load += new System.EventHandler(this.ManageService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_harga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_kira2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown t_harga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_eid;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_unit;
        private System.Windows.Forms.NumericUpDown t_kira2;
        private System.Windows.Forms.Label label7;
    }
}