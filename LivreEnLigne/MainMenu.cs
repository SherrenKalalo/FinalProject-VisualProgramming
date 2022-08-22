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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel_konten_Paint(object sender, PaintEventArgs e)
        {
            Home formHome = new Home();
            formHome.TopLevel = false;
            panel_konten.Controls.Add(formHome);
            formHome.BringToFront();
            formHome.Show();

        }


        private void switchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jual formJual = new Jual();
            formJual.TopLevel = false;
            panel_konten.Controls.Add(formJual);
            formJual.BringToFront();
            formJual.Show();
        }

        private void button_cart_Click(object sender, EventArgs e)
        {
            Keranjang formKeranjang = new Keranjang();
            formKeranjang.TopLevel = false;
            panel_konten.Controls.Add(formKeranjang);
            formKeranjang.BringToFront();
            formKeranjang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CategoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home formHome = new Home();
            formHome.TopLevel = false;
            panel_konten.Controls.Add(formHome);
            formHome.BringToFront();
            formHome.Show();
        }

        private void myOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOrder formMyOrder = new MyOrder();
            formMyOrder.TopLevel = false;
            panel_konten.Controls.Add(formMyOrder);
            formMyOrder.BringToFront();
            formMyOrder.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formForm1 = new Form1();
            this.Hide();
            formForm1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void switchAccToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    
}
