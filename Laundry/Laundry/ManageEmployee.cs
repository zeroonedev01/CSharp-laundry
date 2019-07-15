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
    public partial class ManageEmployee : Form
    {
        Config con = new Config();
        bool kondisi = false;
        int action =0;
        public ManageEmployee()
        {
            InitializeComponent();
            con.fillCcmb("SELECT * from tb_job", "Name", cmb_job);
            con.Tampil("SELECT * from v_employee", dataGridView1);
            bersih();
            setup();
        }
        private void bersih()
        {
            t_alamat.Clear();
            t_cpass.Clear();
            t_email.Clear();
            t_gaji.Value = 0;
            t_hp.Clear();
            t_lahir.ResetText();
            t_name.Clear();
            t_pass.Clear();
            t_eid.Clear();
            cmb_job.SelectedIndex=0;
        }
        private void setup()
        {
            if (kondisi==false)
            {
                t_alamat.Enabled = false;
                t_cpass.Enabled = false;
                t_email.Enabled = false;
                t_gaji.Enabled = false;
                t_hp.Enabled = false;
                t_lahir.Enabled = false;
                t_name.Enabled = false;
                t_pass.Enabled = false;
                cmb_job.Enabled = false;
                b_save.Enabled = false;
                b_cancel.Enabled = false;
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
                t_alamat.Enabled = true;
                t_cpass.Enabled = true;
                t_email.Enabled = true;
                t_gaji.Enabled = true;
                t_hp.Enabled = true;
                t_lahir.Enabled = true;
                t_name.Enabled = true;
                t_pass.Enabled = true;
                cmb_job.Enabled = true;
                kondisi = false;
            }
        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {

        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            con.Cari("SELECT * from v_employee where Name like'%"+t_cari.Text+"%' or Email like '%"+t_cari.Text+"%' or PhoneNumber like '%"+t_cari.Text+"%'", dataGridView1);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_eid.Text = dr.Cells[0].Value.ToString();
            t_name.Text = dr.Cells[2].Value.ToString();
            t_email.Text = dr.Cells[3].Value.ToString();
            t_hp.Text = dr.Cells[5].Value.ToString();
            t_alamat.Text = dr.Cells[4].Value.ToString();
            t_lahir.Text = dr.Cells[6].Value.ToString();
            cmb_job.SelectedItem = dr.Cells[7].Value.ToString();
            t_gaji.Text = dr.Cells[8].Value.ToString();
            t_pass.Text = dr.Cells[1].Value.ToString();
            t_cpass.Text = dr.Cells[1].Value.ToString();



        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            bersih();
            setup();
            t_name.Focus();
            action = 1;
            
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            bool cek = con.validEmail(t_email.Text);
            if (t_name.Text == "" || t_email.Text == "" || t_cpass.Text == "" || t_alamat.Text == "" || t_hp.Text == "" || t_pass.Text == "" || cmb_job.SelectedIndex<0)
            {
                MessageBox.Show("Please Fill all Box!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cek == false)
            {
                MessageBox.Show("Unvalid Email Format!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!t_hp.Text.Contains("+"))
            {
                MessageBox.Show("Unvalid Phone Number Format!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(t_pass.Text != t_cpass.Text){
                MessageBox.Show("Password Not Same!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (action==1)
                {
                    con.CUD("INSERT INTO tb_employee(Password,Name,Email,Address,PhoneNumber,DateofBirth,IdJob,Salaray) values('"+t_pass.Text+ "','" + t_name.Text + "','" + t_email.Text + "','" + t_alamat.Text + "','" + t_hp.Text + "','" + t_lahir.Text + "',(SELECT Id from tb_job where Name='"+cmb_job.SelectedItem+"'),'" + t_gaji.Value + "')", "Success Added data");
                    con.Tampil("SELECT * from tb_employee", dataGridView1);
                    
                }
                else
                {
                    con.CUD("UPDATE tb_employee set Password = '" + t_pass.Text+ "',Name='" + t_name.Text + "',Email='" + t_email.Text + "',Address='" + t_alamat.Text + "',PhoneNumber='" + t_hp.Text + "',DateofBirth = '" + t_lahir.Text + "',IdJob =(SELECT Id from tb_job where Name='" + cmb_job.SelectedItem + "') ,Salaray= '"+t_gaji.Value+"' where Id = '" + t_eid.Text+"'","Success update Data!");
                    con.Tampil("SELECT * from tb_employee", dataGridView1);
                }
                action = 0;
                setup();
                bersih();
            }
            
            
            
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                setup();
                action = 2;
            }
            else
            {
                MessageBox.Show("Please select row to be Edited!","Informasi!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete it!", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.CUD("DELETE from tb_employee where Id = '" + t_eid.Text + "'", "Success Deleted!");
                    con.Tampil("SELECT * from tb_employee", dataGridView1);

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
    }
}
