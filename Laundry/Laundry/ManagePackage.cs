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
    public partial class ManagePackage : Form
    {
        Config con = new Config();
        bool kondisi = false;
        int action = 0;
        public ManagePackage()
        {
            InitializeComponent();
            con.fillCcmb("SELECT * from tb_service", "Name", cmb_service);
            con.Tampil("SELECT * from v_package", dataGridView1);
            setup();
            bersih();
        }
        private void setup()
        {
            if (kondisi == false)
            {
                cmb_service.Enabled = false;
                t_total.Enabled = false;
                t_price.Enabled = false;
                b_cancel.Enabled = false;
                b_save.Enabled = false;
                b_insert.Enabled = true;
                b_update.Enabled = true;
                b_delete.Enabled = true;
                kondisi = true;
            }
            else
            {
                b_insert.Enabled = false;
                b_update.Enabled = false;
                b_delete.Enabled = false;
                b_save.Enabled = true;
                b_cancel.Enabled = true;
                cmb_service.Enabled = true;
                t_total.Enabled = true;
                t_price.Enabled = true;
                kondisi = false;
            }
        }
        private void bersih()
        {
            t_eid.Clear();
            cmb_service.SelectedIndex = 0;
            t_total.Value = 0;
            t_price.Value = 0;
        }
        private void ManagePackage_Load(object sender, EventArgs e)
        {

        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            con.Cari("SELECT * from v_package where Name like'%" + t_cari.Text + "%' or TotalUnit like '%" + t_cari.Text + "%' or Price like '%" + t_cari.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_eid.Text = dr.Cells[0].Value.ToString();
            cmb_service.SelectedItem = dr.Cells[1].Value.ToString();
            t_total.Value = (int)dr.Cells[2].Value;
            t_price.Value = (int)dr.Cells[3].Value;

        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            bersih();
            setup();
            cmb_service.Focus();
            action = 1;
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            if (t_eid.TextLength != 0)
            {
                setup();
                action = 2;
            }
            else
            {
                MessageBox.Show("Please select row to be Edited!", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            if (t_eid.TextLength != 0)
            {
                if (MessageBox.Show("Are you sure to delete it!", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.CUD("DELETE from tb_Package where Id = '" + t_eid.Text + "'", "Success Deleted!");
                    con.Tampil("SELECT * from v_package", dataGridView1);

                }

            }
            else
            {
                MessageBox.Show("Please select row to be Edited!", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            setup();
            bersih();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (cmb_service.SelectedIndex < 0 || t_price.Value == 0 || t_total.Value == 0)
            {
                MessageBox.Show("Please Fill all Box!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (action == 1)
                {
                    con.CUD("INSERT INTO tb_Package (IdService,TotalUnit,Price) values((Select Id from tb_service where Name = '" + cmb_service.SelectedItem + "'),'" + t_total.Value + "','" +t_price.Value + "')", "Success Added data");
                    con.Tampil("SELECT * from v_package", dataGridView1);

                }
                else
                {
                    con.CUD("UPDATE tb_Package set IdService = (Select Id from tb_service where Name = '" + cmb_service.SelectedItem + "'),TotalUnit='" + t_total.Value + "',Price= '" + t_price.Value + "' where Id = '" + t_eid.Text + "'", "Success update Data!");
                    con.Tampil("SELECT * from v_package", dataGridView1);
                }
                action = 0;
                setup();
                bersih();
            }
        }
    }
}
