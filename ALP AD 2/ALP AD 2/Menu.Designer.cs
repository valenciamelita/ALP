namespace ALP_AD_2
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_show = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_hi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sidemenu = new System.Windows.Forms.Panel();
            this.label_search = new System.Windows.Forms.Label();
            this.label_logout = new System.Windows.Forms.Label();
            this.label_cart = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_dashboard = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel_show);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_sidemenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 501);
            this.panel1.TabIndex = 0;
            // 
            // panel_show
            // 
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(225, 100);
            this.panel_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1091, 401);
            this.panel_show.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label_hi);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 100);
            this.panel2.TabIndex = 1;
            // 
            // label_hi
            // 
            this.label_hi.AutoSize = true;
            this.label_hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hi.Location = new System.Drawing.Point(126, 27);
            this.label_hi.Name = "label_hi";
            this.label_hi.Size = new System.Drawing.Size(398, 29);
            this.label_hi.TabIndex = 8;
            this.label_hi.Text = "Hi, NAMA! Welcome to Medishop";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ALP_AD_2.Properties.Resources.shopping_cart;
            this.pictureBox2.Location = new System.Drawing.Point(994, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALP_AD_2.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_sidemenu
            // 
            this.panel_sidemenu.AutoScroll = true;
            this.panel_sidemenu.BackColor = System.Drawing.Color.Silver;
            this.panel_sidemenu.Controls.Add(this.label_search);
            this.panel_sidemenu.Controls.Add(this.label_logout);
            this.panel_sidemenu.Controls.Add(this.label_cart);
            this.panel_sidemenu.Controls.Add(this.pictureBox3);
            this.panel_sidemenu.Controls.Add(this.label_dashboard);
            this.panel_sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidemenu.Location = new System.Drawing.Point(0, 0);
            this.panel_sidemenu.Name = "panel_sidemenu";
            this.panel_sidemenu.Size = new System.Drawing.Size(225, 501);
            this.panel_sidemenu.TabIndex = 2;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.Location = new System.Drawing.Point(3, 394);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(95, 29);
            this.label_search.TabIndex = 7;
            this.label_search.Text = "Search";
            // 
            // label_logout
            // 
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logout.ForeColor = System.Drawing.Color.Red;
            this.label_logout.Location = new System.Drawing.Point(38, 640);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(111, 40);
            this.label_logout.TabIndex = 6;
            this.label_logout.Text = "Logout";
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cart.Location = new System.Drawing.Point(3, 338);
            this.label_cart.Name = "label_cart";
            this.label_cart.Size = new System.Drawing.Size(61, 29);
            this.label_cart.TabIndex = 5;
            this.label_cart.Text = "Cart";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ALP_AD_2.Properties.Resources.Elegant_and_Minimalist_Medical_Logo_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(31, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(147, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label_dashboard
            // 
            this.label_dashboard.AutoSize = true;
            this.label_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dashboard.Location = new System.Drawing.Point(3, 280);
            this.label_dashboard.Name = "label_dashboard";
            this.label_dashboard.Size = new System.Drawing.Size(140, 29);
            this.label_dashboard.TabIndex = 3;
            this.label_dashboard.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_sidemenu.ResumeLayout(false);
            this.panel_sidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_sidemenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_dashboard;
        private System.Windows.Forms.Label label_logout;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_hi;
        private System.Windows.Forms.Panel panel_show;
    }
}