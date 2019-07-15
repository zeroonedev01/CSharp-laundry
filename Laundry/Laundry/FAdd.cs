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
    public partial class FAdd : Form
    {
        Config con = new Config();
        public FAdd()
        {
            InitializeComponent();
        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            if (t_name.Text == "" || t_hp.Text == "" || t_alamat.Text =="")
            {
                MessageBox.Show("Fill ALL DATA!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!t_hp.Text.Contains("+"))
            {
                MessageBox.Show("Unvalid Phone Number Format!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.CUD("INSERT INTO tb_customer (Name,PhoneNumber,Adrress) values('"+t_name.Text+"', '"+t_hp.Text+"','"+t_alamat.Text+"')","Sukses Menambah Data!");
                this.Close();
            }
        }
    }
}
