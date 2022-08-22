
namespace LivreEnLigne
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel_atas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_cart = new System.Windows.Forms.Button();
            this.panel_konten = new System.Windows.Forms.Panel();
            this.panel_atas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_atas
            // 
            this.panel_atas.BackColor = System.Drawing.Color.Wheat;
            this.panel_atas.Controls.Add(this.pictureBox1);
            this.panel_atas.Controls.Add(this.menuStrip1);
            this.panel_atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_atas.Location = new System.Drawing.Point(0, 0);
            this.panel_atas.Name = "panel_atas";
            this.panel_atas.Size = new System.Drawing.Size(838, 43);
            this.panel_atas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryToolStripMenuItem,
            this.switchAccountToolStripMenuItem,
            this.myOrderToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(254, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.CategoryToolStripMenuItem.Text = "Home";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click_1);
            // 
            // switchAccountToolStripMenuItem
            // 
            this.switchAccountToolStripMenuItem.Name = "switchAccountToolStripMenuItem";
            this.switchAccountToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.switchAccountToolStripMenuItem.Text = "My Store";
            this.switchAccountToolStripMenuItem.Click += new System.EventHandler(this.switchAccountToolStripMenuItem_Click);
            // 
            // myOrderToolStripMenuItem
            // 
            this.myOrderToolStripMenuItem.Name = "myOrderToolStripMenuItem";
            this.myOrderToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.myOrderToolStripMenuItem.Text = "My Order";
            this.myOrderToolStripMenuItem.Click += new System.EventHandler(this.myOrderToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // button_cart
            // 
            this.button_cart.Image = ((System.Drawing.Image)(resources.GetObject("button_cart.Image")));
            this.button_cart.Location = new System.Drawing.Point(808, 115);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(30, 23);
            this.button_cart.TabIndex = 1;
            this.button_cart.UseVisualStyleBackColor = true;
            this.button_cart.Click += new System.EventHandler(this.button_cart_Click);
            // 
            // panel_konten
            // 
            this.panel_konten.BackColor = System.Drawing.SystemColors.Control;
            this.panel_konten.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_konten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel_konten.Location = new System.Drawing.Point(0, 43);
            this.panel_konten.Name = "panel_konten";
            this.panel_konten.Size = new System.Drawing.Size(838, 439);
            this.panel_konten.TabIndex = 1;
            this.panel_konten.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_konten_Paint);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 482);
            this.Controls.Add(this.panel_konten);
            this.Controls.Add(this.panel_atas);
            this.Controls.Add(this.button_cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel_atas.ResumeLayout(false);
            this.panel_atas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_atas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem switchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.Panel panel_konten;
    }
}