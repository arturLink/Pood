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
using ZetPDF;

namespace Pood
{
    public partial class Kaasa : Form
    {
        SqlDataAdapter adapter_toode, adapter_kat;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
        public Kaasa()
        {
            InitializeComponent();
            Naita_Andmed();
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
        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            //cmd = new SqlCommand("SELECT * FROM Toodetable");
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;


            toodePlt.Image = Image.FromFile("../../images/Info.png");
            toodePlt.SizeMode = PictureBoxSizeMode.StretchImage;
            connect.Close();
            Naita_Kategooria();

        }

    }
}
