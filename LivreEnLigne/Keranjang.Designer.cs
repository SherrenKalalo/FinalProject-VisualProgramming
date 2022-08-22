
namespace LivreEnLigne
{
    partial class Keranjang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_pembeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_penulis = new System.Windows.Forms.Label();
            this.label_status_buku = new System.Windows.Forms.Label();
            this.label_id_user = new System.Windows.Forms.Label();
            this.label_count_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Cart :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(80, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Judul :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(80, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Harga :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(72, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Continue Shoping";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(222, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(545, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rp.";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(469, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Buy";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_total.Location = new System.Drawing.Point(575, 267);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(12, 15);
            this.label_total.TabIndex = 29;
            this.label_total.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(68, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cart";
            // 
            // textBox_pembeli
            // 
            this.textBox_pembeli.Location = new System.Drawing.Point(512, 300);
            this.textBox_pembeli.Name = "textBox_pembeli";
            this.textBox_pembeli.Size = new System.Drawing.Size(75, 20);
            this.textBox_pembeli.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nama :";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_kategori.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_kategori.Location = new System.Drawing.Point(814, 415);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(12, 15);
            this.lbl_kategori.TabIndex = 36;
            this.lbl_kategori.Text = "-";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_harga.Location = new System.Drawing.Point(144, 301);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(12, 15);
            this.lbl_harga.TabIndex = 35;
            this.lbl_harga.Text = "-";
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_judul.Location = new System.Drawing.Point(144, 267);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(12, 15);
            this.lbl_judul.TabIndex = 34;
            this.lbl_judul.Text = "-";
            // 
            // lbl_penulis
            // 
            this.lbl_penulis.AutoSize = true;
            this.lbl_penulis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_penulis.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_penulis.Location = new System.Drawing.Point(814, 380);
            this.lbl_penulis.Name = "lbl_penulis";
            this.lbl_penulis.Size = new System.Drawing.Size(12, 15);
            this.lbl_penulis.TabIndex = 33;
            this.lbl_penulis.Text = "-";
            // 
            // label_status_buku
            // 
            this.label_status_buku.AutoSize = true;
            this.label_status_buku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_status_buku.ForeColor = System.Drawing.SystemColors.Control;
            this.label_status_buku.Location = new System.Drawing.Point(46, 415);
            this.label_status_buku.Name = "label_status_buku";
            this.label_status_buku.Size = new System.Drawing.Size(12, 15);
            this.label_status_buku.TabIndex = 38;
            this.label_status_buku.Text = "-";
            // 
            // label_id_user
            // 
            this.label_id_user.AutoSize = true;
            this.label_id_user.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_id_user.ForeColor = System.Drawing.SystemColors.Control;
            this.label_id_user.Location = new System.Drawing.Point(12, 415);
            this.label_id_user.Name = "label_id_user";
            this.label_id_user.Size = new System.Drawing.Size(12, 15);
            this.label_id_user.TabIndex = 37;
            this.label_id_user.Text = "-";
            // 
            // label_count_total
            // 
            this.label_count_total.AutoSize = true;
            this.label_count_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_count_total.Location = new System.Drawing.Point(466, 380);
            this.label_count_total.Name = "label_count_total";
            this.label_count_total.Size = new System.Drawing.Size(12, 15);
            this.label_count_total.TabIndex = 39;
            this.label_count_total.Text = "-";
            // 
            // Keranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 439);
            this.Controls.Add(this.label_count_total);
            this.Controls.Add(this.label_status_buku);
            this.Controls.Add(this.label_id_user);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.lbl_judul);
            this.Controls.Add(this.lbl_penulis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pembeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Keranjang";
            this.Text = "Keranjang";
            this.Load += new System.EventHandler(this.Keranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_pembeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Label lbl_penulis;
        private System.Windows.Forms.Label label_status_buku;
        private System.Windows.Forms.Label label_id_user;
        private System.Windows.Forms.Label label_count_total;
    }
}