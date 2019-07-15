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
    public partial class ViewTransaction : Form
    {
        Config con = new Config();
        public ViewTransaction()
        {
            InitializeComponent();
            loadDeposit();
        }
        private void ViewTransaction_Load(object sender, EventArgs e)
        {   
        }
        private void loadDeposit()
        {
            con.Tampil("SELECT * from v_deposit", dataGridView1);
        }
        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            if (t_cari.TextLength ==0)
            {
                con.Cari("SELECT * from v_deposit",dataGridView1);
            }
            else
            {
                con.Cari("SELECT * from v_deposit where Customer like'%"+t_cari.Text+ "%' or Employee like'%" + t_cari.Text + "%' or TransactionDateTime like'%" + t_cari.Text + "%' ", dataGridView1);
            }
        }
        private void fillCOloumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Complete";
            btn.HeaderText = "Action";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.Columns.Clear();
            string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            con.Tampil("SELECT * from v_detaildeposit where IdDeposit = '" + id + "' ", dataGridView2);
            //con.Tampil("SELECT IdDeposit,ServiceName,IdPrepaidPackage,PriceUnit,TotalUnit,CompleteDateTime from v_detaildeposit where Id = '"+id+"' ", dataGridView2);
            fillCOloumn();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==7)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string id1 = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                    con.CUD("Update tb_Detail_Deposit set CompleteDateTime = GETDATE() where Id = '"+id1+"' ","Sukses!");
                    dataGridView2.Columns.Clear();
                    string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    con.Tampil("SELECT * from v_detaildeposit where IdDeposit = '" + id + "' ", dataGridView2);
                    fillCOloumn();
                }
            }
        }
    }
}
