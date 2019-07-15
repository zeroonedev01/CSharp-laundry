using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laundry
{
    public partial class PackageForm : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        public PackageForm()
        {
            InitializeComponent();
            auto();
            fillCombo();
           
            bersih();
            
        }

        private void PackageForm_Load(object sender, EventArgs e)
        {

        }
        private void fillCombo()
        {
            try
            {
                cmd = new SqlCommand("SELECT * from v_package", con.Buka());
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmb_package.Items.Add(reader[1].ToString() + "-"+ reader[2].ToString()+"-"+ reader[3].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Tutup();
            }
        }
        private void auto()
        {
            try
            {
                cmd = new SqlCommand("SELECT * from tb_customer", con.Buka());
                using (reader = cmd.ExecuteReader())
                {
                    AutoCompleteStringCollection at = new AutoCompleteStringCollection();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            at.Add((string)reader["PhoneNumber"].ToString());

                        }
                        t_phone.AutoCompleteCustomSource = at;
                        t_phone.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        t_phone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Tutup();
            }
        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            if (t_cari.TextLength==0)
            {
                con.Tampil("SELECT Id,Customer,(select concat(Service ,'-',TotalUnit,'-',Unit)) as Package ,Price from v_ppackage; ", dataGridView1);
            }
            else
            {
                con.Cari("SELECT Id,Customer,(select concat(Service ,'-',TotalUnit,'-',Unit)) as Package ,Price from v_ppackage  where Customer like '%" + t_cari.Text+ "%' or Service like'%"+ t_cari.Text+"%'", dataGridView1);
            }
            
        }

        private void t_phone_Leave(object sender, EventArgs e)
        {
            con.Fill("SELECT Name, Adrress from tb_customer where PhoneNumber = '" + t_phone.Text + "'", t_nama, t_alamat);
        }

        private void cmb_package_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] service = cmb_package.SelectedItem.ToString().Split('-'); 
            cmd = new SqlCommand("SELECT * from tb_package where IdService = (SELECT Id from tb_service where Name = '"+service[0]+"') and TotalUnit = '"+service[1]+"'", con.Buka());
            using (reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        t_harga.Value = 0;
                        t_harga.Value = (int)reader["Price"];
                    }
                }
            }
            con.Tutup();
        }

        private void t_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.Fill("SELECT Name, Adrress from tb_customer where PhoneNumber = '" + t_phone.Text + "'", t_nama, t_alamat);
            }
        }
        private void b_insert_Click(object sender, EventArgs e)
        {
            if ((string)cmb_package.SelectedItem ==""|| t_harga.Value ==0||t_phone.TextLength==0)
            {
                MessageBox.Show("Please FILL all box!","Informasi");
            }
            else
            {
                string[] service = cmb_package.SelectedItem.ToString().Split('-');
                con.CUD("INSERT into tb_Prepaidpackage (IdCustomer,IdPackage,Price,StartDatetime) values((SELECT Id from tb_customer where PhoneNumber = '" + t_phone.Text + "'),(SELECT Id from tb_package where IdService = (SELECT Id from tb_service where Name = '" + service[0] + "') and TotalUnit = '" + service[1] + "'), '" + t_harga.Value + "',GETDATE())", "Sukses Menambah Data");
                bersih();


            }
        }
        private void bersih()
        {
            t_phone.Clear();
            t_nama.Text = "[Nama]";
            t_alamat.Text = "[Nama]";
            t_harga.Value = 0;
            cmb_package.SelectedIndex = 0;
            con.Tampil("SELECT Id,Customer,(select concat(Service ,'-',TotalUnit,'-',Unit)) as Package ,Price from v_ppackage; ", dataGridView1);

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAdd f = new FAdd();
            f.ShowDialog();
            auto();
        }
    }
}
