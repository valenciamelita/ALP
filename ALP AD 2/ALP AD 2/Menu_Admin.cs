using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_AD_2
{
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {
            panel_sidemenu.Hide();
        }

        bool menuisshown;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (panel_sidemenu.Visible)
                menuisshown = false;

            else
            {
                menuisshown = true;
                panel_sidemenu.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuisshown)
            {
                if (panel_sidemenu.Width >= 150)
                    timer1.Stop();
                panel_sidemenu.Width += 30;
            }
            else
            {
                if (panel_sidemenu.Width <= 0)
                {
                    timer1.Stop();
                    panel_sidemenu.Hide();
                }

                panel_sidemenu.Width -= 30;

            }
        }

        private void label_add_Click(object sender, EventArgs e)
        {
            Add_Medicine addmedicine = new Add_Medicine();
            addmedicine.Show();
            this.Hide();
        }
    }
}
