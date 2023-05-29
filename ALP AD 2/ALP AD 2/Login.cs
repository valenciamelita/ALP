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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.Dock = DockStyle.Fill;
            signup.TopLevel = false;
            signup.ControlBox = false;
            signup.FormBorderStyle = FormBorderStyle.None;
            this.panel_show.Controls.Clear();
            this.panel_show.Controls.Add(signup);
            signup.Show();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
            Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //cek akun jika tidak ada di database

            /*if (*//*akun gaada di database*//*)
            {
                
            }*/

            //cek akun jika ada di database
            /*  else (*//*akun ada di database*//*)
              {
                  if(*//*password salah*//*)
                  {
                      MessageBox.Show("Password is incorrect","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                  }
                  else
                  {

                  }
              }*/



        }

        private void button_login_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button_login_MouseLeave(object sender, EventArgs e)
        {
            button_login.BackColor = Color.White;
            Cursor = Cursors.Default;
        }


        //buat langsung buka main menu
        private void Login_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

    }
}
