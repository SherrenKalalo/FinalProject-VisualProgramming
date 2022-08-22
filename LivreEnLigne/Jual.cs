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
    public partial class Jual : Form
    {
        public Jual()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Jual_Load(object sender, EventArgs e)
        {
            refresh_table();
        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select judul, penulis, harga, deskripsi, kategori, lama_pemakaian, status_buku, id_buku from livre_enligne.book WHERE id_user=1;", myConn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Insert formInsert = new Insert();
            formInsert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTransaksi formDataTransaksi = new DataTransaksi();
            formDataTransaksi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE livre_enligne.book SET judul= '" + this.textBox5.Text + "',penulis='" + this.textBox6.Text + "',kategori='" + this.textBox7.Text + "', deskripsi='" + this.textBox8.Text + "', Status_buku='" + this.textBox9.Text + "', harga='" + this.textBox4.Text + "', lama_pemakaian='" + this.textBox3.Text + "' WHERE id_buku= '" + this.label_idbuku.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "DELETE from livre_enligne.book WHERE  WHERE id_buku= '" + this.label_idbuku.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells["judul"].Value.ToString();
                textBox6.Text = row.Cells["penulis"].Value.ToString();
                textBox3.Text = row.Cells["lama_pemakaian"].Value.ToString();
                textBox7.Text = row.Cells["kategori"].Value.ToString();
                textBox4.Text = row.Cells["harga"].Value.ToString();
                textBox8.Text = row.Cells["deskripsi"].Value.ToString();
                textBox9.Text = row.Cells["status_buku"].Value.ToString();
                label_idbuku.Text = row.Cells["id_buku"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
