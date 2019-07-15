namespace Laundry
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_Emp = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_service = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_pack = new System.Windows.Forms.ToolStripMenuItem();
            this.MTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.MT_trandepo = new System.Windows.Forms.ToolStripMenuItem();
            this.MT_Prepaid = new System.Windows.Forms.ToolStripMenuItem();
            this.MT_View = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.t_nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFile,
            this.MManage,
            this.MTrans});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MFile
            // 
            this.MFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MF_logout,
            this.MF_Exit});
            this.MFile.Name = "MFile";
            this.MFile.Size = new System.Drawing.Size(37, 20);
            this.MFile.Text = "&File";
            // 
            // MF_logout
            // 
            this.MF_logout.Name = "MF_logout";
            this.MF_logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.MF_logout.Size = new System.Drawing.Size(152, 22);
            this.MF_logout.Text = "&LogOut";
            this.MF_logout.Click += new System.EventHandler(this.MF_logout_Click);
            // 
            // MF_Exit
            // 
            this.MF_Exit.Name = "MF_Exit";
            this.MF_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.MF_Exit.Size = new System.Drawing.Size(152, 22);
            this.MF_Exit.Text = "&Exit";
            this.MF_Exit.Click += new System.EventHandler(this.MF_Exit_Click);
            // 
            // MManage
            // 
            this.MManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MM_Emp,
            this.MM_service,
            this.MM_pack});
            this.MManage.Name = "MManage";
            this.MManage.Size = new System.Drawing.Size(62, 20);
            this.MManage.Text = "&Manage";
            // 
            // MM_Emp
            // 
            this.MM_Emp.Name = "MM_Emp";
            this.MM_Emp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.MM_Emp.Size = new System.Drawing.Size(162, 22);
            this.MM_Emp.Text = "&Employee";
            this.MM_Emp.Click += new System.EventHandler(this.MM_Emp_Click);
            // 
            // MM_service
            // 
            this.MM_service.Name = "MM_service";
            this.MM_service.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MM_service.Size = new System.Drawing.Size(162, 22);
            this.MM_service.Text = "&Service";
            this.MM_service.Click += new System.EventHandler(this.MM_service_Click);
            // 
            // MM_pack
            // 
            this.MM_pack.Name = "MM_pack";
            this.MM_pack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.MM_pack.Size = new System.Drawing.Size(162, 22);
            this.MM_pack.Text = "&Package";
            this.MM_pack.Click += new System.EventHandler(this.MM_pack_Click);
            // 
            // MTrans
            // 
            this.MTrans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MT_trandepo,
            this.MT_Prepaid,
            this.MT_View});
            this.MTrans.Name = "MTrans";
            this.MTrans.Size = new System.Drawing.Size(80, 20);
            this.MTrans.Text = "&Transaction";
            // 
            // MT_trandepo
            // 
            this.MT_trandepo.Name = "MT_trandepo";
            this.MT_trandepo.Size = new System.Drawing.Size(178, 22);
            this.MT_trandepo.Text = "&Transaction Deposit";
            this.MT_trandepo.Click += new System.EventHandler(this.MT_trandepo_Click);
            // 
            // MT_Prepaid
            // 
            this.MT_Prepaid.Name = "MT_Prepaid";
            this.MT_Prepaid.Size = new System.Drawing.Size(178, 22);
            this.MT_Prepaid.Text = "&Prepaid Package";
            this.MT_Prepaid.Click += new System.EventHandler(this.MT_Prepaid_Click);
            // 
            // MT_View
            // 
            this.MT_View.Name = "MT_View";
            this.MT_View.Size = new System.Drawing.Size(178, 22);
            this.MT_View.Text = "&View Transaction";
            this.MT_View.Click += new System.EventHandler(this.MT_View_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_nama});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // t_nama
            // 
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(39, 17);
            this.t_nama.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel t_nama;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem MFile;
        public System.Windows.Forms.ToolStripMenuItem MF_logout;
        public System.Windows.Forms.ToolStripMenuItem MF_Exit;
        public System.Windows.Forms.ToolStripMenuItem MManage;
        public System.Windows.Forms.ToolStripMenuItem MM_Emp;
        public System.Windows.Forms.ToolStripMenuItem MM_service;
        public System.Windows.Forms.ToolStripMenuItem MM_pack;
        public System.Windows.Forms.ToolStripMenuItem MTrans;
        public System.Windows.Forms.ToolStripMenuItem MT_trandepo;
        public System.Windows.Forms.ToolStripMenuItem MT_Prepaid;
        public System.Windows.Forms.ToolStripMenuItem MT_View;
    }
}



