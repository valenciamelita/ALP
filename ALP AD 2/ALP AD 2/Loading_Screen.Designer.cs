﻿namespace ALP_AD_2
{
    partial class Loading_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.persen = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_show = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1123, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to MediShop!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(483, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 440);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1111, 20);
            this.progressBar1.TabIndex = 3;
            // 
            // persen
            // 
            this.persen.AutoSize = true;
            this.persen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persen.ForeColor = System.Drawing.Color.Teal;
            this.persen.Location = new System.Drawing.Point(592, 404);
            this.persen.Name = "persen";
            this.persen.Size = new System.Drawing.Size(49, 25);
            this.persen.TabIndex = 5;
            this.persen.Text = "0 %";
            this.persen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_show
            // 
            this.panel_show.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_show.Controls.Add(this.pictureBox1);
            this.panel_show.Controls.Add(this.label1);
            this.panel_show.Controls.Add(this.progressBar1);
            this.panel_show.Controls.Add(this.persen);
            this.panel_show.Controls.Add(this.label2);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 0);
            this.panel_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(1103, 462);
            this.panel_show.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALP_AD_2.Properties.Resources.Elegant_and_Minimalist_Medical_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(375, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Loading_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1103, 462);
            this.Controls.Add(this.panel_show);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Loading_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Loading_Screen_Load);
            this.panel_show.ResumeLayout(false);
            this.panel_show.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label persen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

