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
        SqlCommand cmd,cmd2;
        SqlDataReader dr, dr2;
        SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }
        public void Naita_Stat()
        {
            comboBox1.Items.Add("Omanik");
            comboBox1.Items.Add("Kasutaja");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\source\repos\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
            cn.Open();
            Naita_Stat();
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
                if(comboBox1.Text == "Kasutaja")
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + nimiBox.Text + "' and password='" + paroolBox.Text + "'" + " and staatus='Kasutaja'", cn);
                }
                else if(comboBox1.Text == "Omanik")
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + nimiBox.Text + "' and password='" + paroolBox.Text + "'" + " and staatus='Omanik'", cn);
                }
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    if (comboBox1.Text=="Kasutaja")
                    {
                        Kaasa kaasa= new Kaasa();
                        kaasa.ShowDialog();
                    }
                    else if (comboBox1.Text == "Omanik")
                    {
                        PeaVorm pea = new PeaVorm();
                        pea.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kes sa oled?");
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //kasutaja sdelai izi variant s uto4neniem statusa
        }
    }
}
