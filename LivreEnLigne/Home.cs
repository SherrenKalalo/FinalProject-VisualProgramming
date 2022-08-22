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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            refreshtable();
            //label_id_user.Text = ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lbl_judul.Text = row.Cells["judul"].Value.ToString();
                lbl_penulis.Text = row.Cells["penulis"].Value.ToString();
                lbl_pemakaian.Text = row.Cells["lama_pemakaian"].Value.ToString();
                lbl_kategori.Text = row.Cells["kategori"].Value.ToString();
                lbl_harga.Text = row.Cells["harga"].Value.ToString();
                lbl_deskripsi.Text = row.Cells["deskripsi"].Value.ToString();
                label_id_user.Text = row.Cells["id_buku"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refreshtable()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select judul, penulis, harga, deskripsi, kategori, lama_pemakaian,id_buku, status_buku from livre_enligne.book WHERE status_buku=0;", myConn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into livre_enligne.transaksi (id_transaksi,id_user,id_buku,pembeli,judul,penulis,tanggal_transaksi,total,no_hp) values('','1','" + this.label_id_user.Text + "','" + this.textBox_pembeli.Text + "','" + this.lbl_judul.Text + "','" + this.lbl_penulis.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + this.lbl_harga.Text + "','" + this.textBox_hp.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("ThankYou!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //status_buku_off(Convert.ToInt32 (label_status_buku.Text) );
            /*         ctrl+shift+/        */
        }


        /*void status_buku_off(int id_buku)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE livre_enligne.book SET status_buku= '1' WHERE  id_buku='" + id_buku + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM livre_enligne.book;", myConn);
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

                DataView DV = new DataView(dbdataset);
                DV.RowFilter = string.Format("judul LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = DV;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_pembeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_hp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
            

}

