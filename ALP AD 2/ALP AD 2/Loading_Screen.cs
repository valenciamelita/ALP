using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_AD_2
{
    public partial class Loading_Screen : Form
    {
        public string connectionstring = "server=localhost;uid=root;pwd=junior123;database=premier_league";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public MySqlDataReader sqlDataReader;
        public string query;
        public Loading_Screen()
        {
            try
            {
                string connection = "server=localhost;uid=root;pwd=junior123;database=premier_league";
                sqlConnect = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int detik = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            detik++;

            //jadiin 100 dulu biar cpt
            progressBar1.Value = 100;

            //progressBar1.Value = 100;
            persen.Text = detik + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Dock = DockStyle.Fill;
                login.TopLevel = false;
                login.ControlBox = false;
                login.FormBorderStyle = FormBorderStyle.None;
                this.panel_show.Controls.Clear();
                this.panel_show.Controls.Add(login);
                login.Show();

                Menu_Admin menuadmin = new Menu_Admin();
                menuadmin.Show();
            }
            // query = "";
            // sqlConnect = new MySqlConnection(connectionstring);
            // sqlCommand = new MySqlCommand(query, sqlConnect);
            // sqlAdapter = new MySqlDataAdapter(sqlCommand);
        }
    }
}
