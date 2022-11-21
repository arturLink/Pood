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
        SqlDataAdapter adapter_Stat;
        DataTable dt_Stat;
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection cn;
        public registratsioon()
        {
            InitializeComponent();
        }

        public void Naita_Stat()
        {
            comboBox1.Items.Add("Omanik");
            comboBox1.Items.Add("Kasutaja");
        }

        private void registratsioon_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\source\repos\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
            cn.Open();
            Naita_Stat();
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
                        cmd = new SqlCommand("INSERT INTO LoginTable (username,password,staatus)" +
                        " VALUES (@name,@pass,@staat)", cn); //oma lause!!!!!!!!!!!!!!!!!!!!!!
                        cmd.Parameters.AddWithValue("@name", nimiBox.Text);
                        cmd.Parameters.AddWithValue("@pass", paroolBox.Text);
                        cmd.Parameters.AddWithValue("@staat", comboBox1.SelectedIndex);
                        cmd.ExecuteNonQuery(); //oshibka s staatusId(logintable) ili Id(staatus)
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
