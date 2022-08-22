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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into livre_enligne.user (id_user,username,password,first_name,last_name,gender,date_of_birth,domisili,email,no_hp) values('','" + this.textBox_username.Text + "','" + this.textBox_password.Text + "','" + this.textBox_firstname.Text + "','" + this.textBox_lastname.Text + "','" +gender+ "','" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + this.textBox_domisili.Text + "','" + this.textBox_email.Text + "','" + this.textBox_phone.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Inserted");
                textBox_username.Text = "";
                textBox_password.Text = "";
                textBox_phone.Text = "";
                textBox_lastname.Text = "";
                textBox_firstname.Text = "";
                textBox_email.Text = "";
                textBox_domisili.Text = "";
                radioButton_female.Checked = false;
                radioButton_male.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string gender;

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void comboBox_provinsi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formForm1 = new Form1();
            formForm1.Show();
            this.Hide();
        }

        private void textBox_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            radioButton_male.Checked = true;
        }
    }
}
