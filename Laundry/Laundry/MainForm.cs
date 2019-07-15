using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class MainForm : Form
    {
        ManageEmployee me;
        ManagePackage mp;
        ManageService ms;
        PackageForm fp;
        Transaction_Deposit td;
        ViewTransaction vt;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MM_Emp_Click(object sender, EventArgs e)
        {
            if (me == null)
            {
                me = new ManageEmployee();
                me.MdiParent = this;
                me.FormClosed += new FormClosedEventHandler(Me_FormClosed);
                me.Show();
            }
            else
            {
                me.Activate();
            }
        }

        private void Me_FormClosed(object sender, FormClosedEventArgs e)
        {
            me = null;
        }

        private void MM_service_Click(object sender, EventArgs e)
        {
            if (ms == null)
            {
                ms = new ManageService();
                ms.MdiParent = this;
                ms.FormClosed += new FormClosedEventHandler(Ms_FormClosed);
                ms.Show();
            }
            else
            {
                ms.Activate();

            }
        }

        private void Ms_FormClosed(object sender, FormClosedEventArgs e)
        {
            ms = null;
        }

        private void MM_pack_Click(object sender, EventArgs e)
        {
            if (mp == null)
            {
                mp = new ManagePackage();
                mp.MdiParent = this;
                mp.FormClosed += new FormClosedEventHandler(Mp_FormClosed);
                mp.Show();
            }
            else
            {
                mp.Activate();

            }
        }

        private void Mp_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp = null;
        }

        private void MT_trandepo_Click(object sender, EventArgs e)
        {
            if (td == null)
            {
                td = new Transaction_Deposit();
                td.MdiParent = this;
                td.FormClosed += new FormClosedEventHandler(Td_FormClosed);
                td.Show();
            }
            else
            {
                td.Activate();
            }
        }

        private void Td_FormClosed(object sender, FormClosedEventArgs e)
        {
            td = null;
        }

        private void MT_Prepaid_Click(object sender, EventArgs e)
        {
            if (fp==null)
            {
                fp = new PackageForm();
                fp.MdiParent = this;
                fp.FormClosed += new FormClosedEventHandler(Fp_FormClosed);
                fp.Show();
            }
            else
            {
                fp.Activate();
            }
        }

        private void Fp_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp = null;
        }

        private void MT_View_Click(object sender, EventArgs e)
        {
            if (vt== null)
            {
                vt = new ViewTransaction();
                vt.MdiParent = this;
                vt.FormClosed += new FormClosedEventHandler(Vt_FormClosed);
                vt.Show();

            }
            else
            {
                vt.Activate();
            }
        }

        private void Vt_FormClosed(object sender, FormClosedEventArgs e)
        {
            vt = null;
        }

        private void MF_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login l = new Login();
            l.Show();
        }

        private void MF_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
