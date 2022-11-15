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

namespace Pood
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
            cn.Open();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registratsioon registration = new registratsioon();
            registration.ShowDialog();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (paroolBox.Text != string.Empty || nimiBox.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + nimiBox.Text + "' and password='" + paroolBox.Text + "'", cn); //oma select lause!!!!!!!!!!!!!!!!!!
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    //Home home = new Home(); //oma dialog aken
                    //home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
