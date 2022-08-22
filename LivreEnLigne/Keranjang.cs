using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LivreEnLigne
{
    public partial class Keranjang : Form
    {
        public Keranjang()
        {
            InitializeComponent();
        }

        private void Keranjang_Load(object sender, EventArgs e)
        {
            refresh_table();
            total_harga();
            //label_total.Text=harga+harga
        }

        public void total_harga()
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select count (total) from livre_enligne.transaksi;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                label_count_total.Text = Convert.ToString(bSource);
                int total = 0;
                int n = Convert.ToInt32(label_count_total.Text);
                for (int x = 1; x <= n; x++)
                {
                    string TotalHarga = dataGridView1.Rows[x].Cells[8].Value.ToString();
                    TotalHarga = total + TotalHarga;
                    total += Convert.ToInt32(TotalHarga);
                }
                label_total.Text = total.ToString();
                bSource.DataSource = dbdataset;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select id_transaksi,id_user,id_buku,pembeli,judul,penulis,tanggal_transaksi,total from livre_enligne.transaksi;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lbl_judul.Text = row.Cells["judul"].Value.ToString();
                lbl_harga.Text = row.Cells["total"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into livre_enligne.transaksi (id_transaksi,id_user,id_buku,pembeli,judul,penulis,tanggal_transaksi,total) values('','1','" + this.label_id_user.Text + "','" + this.lbl_judul.Text + "','Chris Alexander','" + this.lbl_penulis.Text + "','','" + this.lbl_harga.Text + "',);";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Added to Cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
