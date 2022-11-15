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
    public partial class registratsioon : Form
    {
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection cn;
        public registratsioon()
        {
            InitializeComponent();
        }

        private void registratsioon_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
            cn.Open();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (kinnitaBox.Text != string.Empty || paroolBox.Text != string.Empty || nimiBox.Text != string.Empty)
            {
                if (paroolBox.Text == kinnitaBox.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + nimiBox.Text + "'", cn); //oma lause!!!!!!!!!!!!!!!!!!!!!!
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn); //oma lause!!!!!!!!!!!!!!!!!!!!!!
                        cmd.Parameters.AddWithValue("username", nimiBox.Text);
                        cmd.Parameters.AddWithValue("password", paroolBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
