using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net.Mail;

namespace Laundry
{
    class Config
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlConnection cnn;
        SqlDataReader reader;
        private string strkoneksi = null;
        public SqlConnection Buka()
        {
            try
            {
                //strkoneksi = "Data Source = DESKTOP-A45DNAG\\SQLEXPRESS; Initial Catalog = laundry; uid = sa; password = dfjklap";
                strkoneksi = "Server =DESKTOP-A45DNAG\\SQLEXPRESS; Database = laundry; Integrated Security = SSPI";
                cnn = new SqlConnection(strkoneksi);
                cnn.Open();
                MessageBox.Show("Sukses!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return cnn;
        }
        public SqlConnection Tutup()
        {
            strkoneksi = null;
            cnn.Close();
            return cnn;
        }
        public bool CUD(string query, string info)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
                MessageBox.Show(info, "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Tutup();
            }
            return true;
        }
        public bool CUDnoinfo(string query)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Tutup();
            }
            return true;
        }
        public void Tampil(string query, DataGridView dgr)
        {
            cmd = new SqlCommand(query,Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgr.DataSource = dt;
            dgr.Refresh();
            Tutup();
        }
        public void Cari(string query, DataGridView dgr)
        {
            cmd = new SqlCommand(query, Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgr.DataSource = dt;
            dgr.Refresh();
            Tutup();
        }
        public bool validEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {

                return false;
            }
        }
        public void fillCcmb(string query, string param, ComboBox cmb)
        {
            try
            {
                cmd = new SqlCommand(query,Buka());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader[param].ToString();
                    cmb.Items.Add(a);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                Tutup();
            }
        }
         public void AutosearchHp(string query, string param, TextBox txt)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string a = reader[param].ToString();
                        txt.AutoCompleteCustomSource.Add(a);

                    }
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
        }
        public void Fill(string query, Label txt, Label txt2)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt.Text = reader["Name"].ToString();
                    txt2.Text = reader["Adrress"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
        }




    }
}
