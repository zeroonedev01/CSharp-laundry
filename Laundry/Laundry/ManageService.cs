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
    public partial class ManageService : Form
    {
        Config con = new Config();
        bool kondisi = false;
        int action = 0;
        public ManageService()
        {
            InitializeComponent();
            con.fillCcmb("SELECT * from tb_category", "Name", cmb_category);
            con.fillCcmb("SELECT * from tb_Unit", "Name", cmb_unit);
            con.Tampil("SELECT * from v_service", dataGridView1);
            setup();
            bersih();
          
        }
        private void setup()
        {
            if (kondisi == false)
            {
                t_name.Enabled = false;
                cmb_category.Enabled = false;
                cmb_unit.Enabled = false;
                t_harga.Enabled = false;
                t_kira2.Enabled = false;
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
                t_name.Enabled = true;
                cmb_category.Enabled = true;
                cmb_unit.Enabled = true;
                t_harga.Enabled = true;
                t_kira2.Enabled = true;
                kondisi = false;
            }
        }
        private void bersih()
        {
            t_eid.Clear();
            t_name.Clear();
            cmb_category.SelectedIndex = 0;
            cmb_unit.SelectedIndex = 0;
            t_harga.Value = 0;
            t_kira2.Value=0;
        }
        private void ManageService_Load(object sender, EventArgs e)
        {
           
        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            con.Cari("SELECT * from v_service where Name like'%" + t_cari.Text + "%' or Category like '%" + t_cari.Text + "%' or Unit like '%" + t_cari.Text + "%' or PriceUnit like '%" + t_cari.Text + "%'", dataGridView1);
        }
        private void b_insert_Click(object sender, EventArgs e)
        {
            bersih();
            setup();
            t_name.Focus();
            action = 1;
        }
        private void b_update_Click(object sender, EventArgs e)
        {
            if (t_eid.TextLength!=0)
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
                    con.CUD("DELETE from tb_service where Id = '" + t_eid.Text + "'", "Success Deleted!");
                    con.Tampil("SELECT * from v_service", dataGridView1);

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
            action = 0;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (t_name.Text == "" || cmb_category.SelectedIndex < 0 || cmb_unit.SelectedIndex < 0 || t_kira2.Value == 0 || t_harga.Value == 0)
            {
                MessageBox.Show("Please Fill all Box!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (action == 1)
                {
                    con.CUD("INSERT INTO tb_service(Name,IdCategory,IdUnit,PriceUnit,EstimationDuration) values('" + t_name.Text + "',(Select Id from tb_category where Name = '"+cmb_category.SelectedItem+ "'),(Select Id from tb_Unit where Name = '" + cmb_unit.SelectedItem + "'),'" +t_harga.Value+ "','" + t_kira2.Value + "')", "Success Added data");
                    con.Tampil("SELECT * from v_service", dataGridView1);

                }
                else
                {
                    con.CUD("UPDATE tb_service set Name ='" + t_name.Text + "',IdCategory =(Select Id from tb_category where Name = '" + cmb_category.SelectedItem + "'),IdUnit =(Select Id from tb_Unit where Name = '" + cmb_unit.SelectedItem + "'),PriceUnit='" + t_harga.Value + "',EstimationDuration = '" + t_kira2.Value + "' where Id = '" + t_eid.Text + "'", "Success update Data!");
                    con.Tampil("SELECT * from tb_service", dataGridView1);
                }
                action = 0;
                setup();
                bersih();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_eid.Text = dr.Cells[0].Value.ToString();
            t_name.Text = dr.Cells[1].Value.ToString();
            cmb_category.SelectedItem = dr.Cells[2].Value.ToString();
            cmb_unit.SelectedItem = dr.Cells[3].Value.ToString();
            t_harga.Value = Convert.ToInt64(dr.Cells[4].Value.ToString());
            t_kira2.Value = Convert.ToInt64(dr.Cells[5].Value.ToString());


        }
    }
}
