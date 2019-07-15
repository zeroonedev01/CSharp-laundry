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
    public partial class Transaction_Deposit : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        string id;
        string num;
        string urut;
        int estimasi;

        public Transaction_Deposit()
        {
            InitializeComponent();
            timer1.Start();
            con.fillCcmb("SELECT Name from tb_service", "Name", cmb_category);
            Addcolom();
            auto();
            autonumber();
            MessageBox.Show(num);
        }
        private void bersihCus()
        {
            t_cari.Clear();
            t_nama.Text = "[Nama]";
            t_alamat.Text = "[Nama]";
            bersih();

        }
        private void bersih()
        {
            cek_prepaid.Checked = false;
            t_harga.Value = 0;
            t_price.Clear();
            cmb_category.SelectedIndex = 0;
        }
        private void Addcolom()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("", "Service");
            dataGridView1.Columns.Add("", "Prepaid Package");
            dataGridView1.Columns.Add("", "Price per Unit");
            dataGridView1.Columns.Add("", "Total Unit");
            dataGridView1.Columns.Add("", "Subtotal");
            dataGridView1.Columns.Add("", "EstimationTime");

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Delete";
            btn.HeaderText = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

        }
        private void Transaction_Deposit_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            t_time.Text = dt.ToString();
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {

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
                        t_cari.AutoCompleteCustomSource = at;
                        t_cari.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        t_cari.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            //con.AutosearchHp("SELECT * from tb_customer","PhoneNumber",t_cari);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAdd fa = new FAdd();
            fa.ShowDialog();
            auto();
        }

        private void t_cari_Leave(object sender, EventArgs e)
        {
            con.Fill("SELECT Name, Adrress from tb_customer where PhoneNumber = '" + t_cari.Text + "'", t_nama, t_alamat);
        }
        private void total()
        {
            int sumTotal = 0;
            int sumTime = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                sumTotal += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                sumTime += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            TimeSpan t = TimeSpan.FromHours(sumTime);
            t_total.Text = sumTotal.ToString();
            t_totalwaktu.Text = t.ToString(@"dd\.hh\:mm\:ss");

        }
        private void b_add_Click(object sender, EventArgs e)
        {
            if (t_cari.TextLength == 0 || t_harga.Value == 0)
            {
                MessageBox.Show("Please Fill All Data!");
            }
            else
            {

                if (cek_prepaid.Checked)
                {
                    dataGridView1.Rows.Add(cmb_category.SelectedItem, cmb_category.SelectedItem, t_harga.Value, t_price.Text, "");
                }
                else
                {
                    dataGridView1.Rows.Add(cmb_category.SelectedItem, "",  t_price.Text, t_harga.Value, (t_harga.Value * Convert.ToInt64(t_price.Text)),(estimasi * Convert.ToInt64(t_harga.Text)));
                }
                bersih();
                total();



            }
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * from tb_service where Name = '" + cmb_category.SelectedItem + "'", con.Buka());
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    t_price.Text = reader["PriceUnit"].ToString();
                    estimasi = (int)reader["EstimationDuration"];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns[5].Index)
            {

                dataGridView1.Rows.RemoveAt(e.RowIndex);
                dataGridView1.Refresh();
                total();
            }

        }
        private void autonumber()
        {
            int hitung;
            cmd = new SqlCommand("SELECT max(Id) from tb_Header_Deposit",con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = int.Parse(reader[0].ToString())+1;
                urut = hitung.ToString();
            }
            else
            {
                urut = "0";
            }
            num = urut;
           
        }
        private void simpanMaster()
        {
            string[] awal = t_totalwaktu.Text.Split('.');
            string[] time = awal[1].Split(':');
            DateTime dt = DateTime.Now;
            dt = dt.AddDays(Convert.ToDouble(awal[0]));
            dt = dt.AddHours(Convert.ToDouble(time[0]));
            dt = dt.AddMinutes(Convert.ToDouble(time[1]));
            dt = dt.AddSeconds(Convert.ToDouble(time[2]));
            string tgl = dt.ToString("s");
            con.CUD("Insert Into tb_Header_Deposit (IdCustomer,IdEmployee,TransactionDateTime,CompleteEstimationDatetime) values((SELECT Id from tb_customer where PhoneNumber = '"+t_cari.Text+"'),'"+Login.id+"', GETDATE(),(select cast('"+tgl+"' as datetime)))", "TRansaksi Berhasil");
        }
        private void simpanDetail()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {

                if (dataGridView1.Rows[i].Cells[1].Value.ToString() =="")
                {
                    con.CUDnoinfo("INSERT into tb_Detail_Deposit (IdDeposit,IdService,PriceUnit,TotalUnit) values ('" + num+ "',(SELECT  Id from tb_service where Name ='" + dataGridView1.Rows[i].Cells[0].Value + "'),'" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')");
                    //con.CUDnoinfo("INSERT into tb_Detail_Deposit (IdDeposit,IdService,IdPrepaidPackage,PriceUnit,TotalUnit) values ('" + urut + "',SELECT  Id from tb_service where Name ='" + dataGridView1.Rows[i].Cells[0].Value + "',(SELECT ),'" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')");
                }
                else{
                    con.CUDnoinfo("INSERT into tb_Detail_Deposit (IdDeposit,IdService,IdPrepaidPackage,PriceUnit,TotalUnit) values ('" + urut + "',SELECT  Id from tb_service where Name ='" + dataGridView1.Rows[i].Cells[0].Value + "',,'" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')");
                }
                
            }
        }
        private void b_submit_Click(object sender, EventArgs e)
        {
            if (t_cari.TextLength == 0 || dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("Please FIll all Data");
            }
            else
            {
                simpanMaster();
                simpanDetail();
                bersihCus();
                autonumber();
                dataGridView1.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(dt.ToString());
        }
    }
}
