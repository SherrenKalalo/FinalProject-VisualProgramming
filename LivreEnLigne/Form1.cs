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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from livre_enligne.user where username= '" + this.textBox_username.Text + "' and password='" + this.textBox_password.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    // MessageBox.Show("WELCOME");

                    MainMenu formMainMenu = new MainMenu();
                    formMainMenu.Show();
                    this.Hide();
                }
                else if (textBox_password.Text=="" || textBox_username.Text == "")
                {
                    MessageBox.Show("Username dan Password tidak boleh kosong!");
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost; port=3306; username=root; password="; //initial database
                MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
                myDataAdapter.SelectCommand = new MySqlCommand("select * livre_enligne.user;", myConn);// sql syntax
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter
                myConn.Open();// start connection

                DataSet ds = new DataSet();

                MessageBox.Show("Conected");

                myConn.Close();// end connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            CreateAccount formCreateAccount = new CreateAccount();
            formCreateAccount.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
