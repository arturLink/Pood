using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pood
{
    public partial class Form1 : Form
    {
        SqlConnection connect=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode,adapter_kat;
        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        public void Lisa_Andmed()
        {
            if(nimeBox.Text.Trim()!=string.Empty && kogusBox.Text.Trim() != string.Empty &&
                hindBox.Text.Trim() != string.Empty && katBox.SelectedItem!= null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (ToodeNimetus,Kogus,Hind,Pilt,KategooriaID)" +
                        " VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode",nimeBox.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogusBox.Text);
                    cmd.Parameters.AddWithValue("@hind", hindBox.Text); //format andmebaasis võrdseb?
                    cmd.Parameters.AddWithValue("@pilt", nimeBox.Text); //pilt format?
                    cmd.Parameters.AddWithValue("@kat", katBox.SelectedIndex); //index?
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_Andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmeebaasi viga");
                }
            }
            else
            {
                MessageBox.Show("Sissesta andmeid");
            }
        }
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            //cmd = new SqlCommand("SELECT * FROM Toodetable");
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable",connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;
            

            toodePilt.Image = Image.FromFile("../../images/Info.png");
            toodePilt.SizeMode = PictureBoxSizeMode.StretchImage;
            connect.Close();
            Naita_Kategooria();

        }
        public void Kustuta_Andmed()
        {
            nimeBox.Text = "";
            hindBox.Text = "";
            kogusBox.Text = "";
            katBox.Items.Clear();
        }
        public void Lisa_Kategooria()
        {
            connect.Open();
            cmd = new SqlCommand("INSERT INTO KategooriaTable(KategooriaNimetus)" +
                "VALUES (@kat)",connect);
            cmd.Parameters.AddWithValue("@kat",katBox.Text);
            cmd.ExecuteNonQuery();
            connect.Close();

            Kustuta_Andmed();
            Naita_Kategooria();
        }
        public void Naita_Kategooria()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT KategooriaNimetus FROM KategooriaTable", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                katBox.Items.Add(nimetus["KategooriaNimetus"]);
            }
            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void koguslbl_Click(object sender, EventArgs e)
        {

        }

        private void LisaBtn_Click(object sender, EventArgs e)
        {
            Lisa_Kategooria();
        }

        private void liisaBtn_Click(object sender, EventArgs e)
        {
            if (nimeBox.Text.Trim() != string.Empty && kogusBox.Text.Trim() != string.Empty &&
                hindBox.Text.Trim() != string.Empty && katBox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (ToodeNimetus,Kogus,Hind,Pilt,KategooriaID)" +
                        " VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", nimeBox.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogusBox.Text);
                    cmd.Parameters.AddWithValue("@hind", hindBox.Text); //format andmebaasis võrdseb?
                    cmd.Parameters.AddWithValue("@pilt", nimeBox.Text+".jpg"); //pilt format?
                    cmd.Parameters.AddWithValue("@kat", katBox.SelectedIndex); //index?
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_Andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmeebaasi viga");
                }
            }
            else
            {
                MessageBox.Show("Sissesta andmeid");
            }
        }

        private void toodePilt_Click(object sender, EventArgs e)
        {

        }
    }
}
