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
    public partial class Login : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        public static string id, nama;
        public Login()
        {
            InitializeComponent();
            con.Buka();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            t_email.Clear();
            t_pass.Clear();
        }
        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_email.Text=="" || t_pass.Text == "")
            {
                MessageBox.Show("Please Fill all Box!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool cek = con.validEmail(t_email.Text);
                if (cek==false)
                {
                    MessageBox.Show("Unvalid Email", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        cmd = new SqlCommand("SELECT Id, Name from tb_employee where Email='"+t_email.Text+"' and Password = '"+t_pass.Text+"' ", con.Buka());
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                              nama = reader["Name"].ToString();
                              id = reader["Id"].ToString();

                            }
                            MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm m = new MainForm();
                            m.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Pleasy Try Again, Your Data is No Valid!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                        con.Tutup();
                    }
                }
            }
            clear();
        }

        private void t_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b_login.PerformClick();
            }
        }
    }
}
