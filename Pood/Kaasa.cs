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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Pood
{
    public partial class Kaasa : Form
    {
        SqlDataAdapter adapter_toode;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\artur\source\repos\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
        public Kaasa()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
            Naita_Andmed();
        }
        int Id;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            nimiBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kogusBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            hindBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                toodePlt.Image = Image.FromFile(@"..\..\images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                toodePlt.Image = Image.FromFile(@"..\..\images\Info.png");
                MessageBox.Show("Fail puudub");
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "1")
            {
                katBox.Text = "Manguasjad";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "2")
            {
                katBox.Text = "Ajatooded";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "3")
            {
                katBox.Text = "Toidutooded";
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "4")
            {
                katBox.Text = "Materjalid";
            }
        }

        List<string> tooded = new List<string>();
        List<int> hindeid = new List<int>();
        private void liisaKorvBtn_Click(object sender, EventArgs e)
        {
            //if (Int32.Parse(kogusBox.Text) < 0 && Int32.Parse(kogusBox.Text) > Int32.Parse(dataGridView1.Rows[2].Cells[columnindex].Value.ToString()))
            //{
            //    MessageBox.Show("Palun sissesta korektselt andmed");
            //}
            //else
            //{
            //    MessageBox.Show("Kõik on korras");
            //}

            for (int i = 0; i < Int32.Parse(kogusBox.Text); i++)
            {
                tooded.Add(nimiBox.Text);
            }

            for (int i = 0; i < Int32.Parse(kogusBox.Text); i++)
            {
                hindeid.Add(Int32.Parse(hindBox.Text));
            }
            int sumHind = hindeid.Sum();

            

        }

        private void ostaBtn_Click(object sender, EventArgs e)
        {
            int yt=100;
            int yh = 100;
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Tšek";
            PdfPage page = document.AddPage();
            XFont font = new XFont("Arial", 14);
            XGraphics graphics = XGraphics.FromPdfPage(page);

            graphics.DrawString("Tšek",new XFont("Arial",40), XBrushes.Black, new XPoint(245, 70));
            for (int i = 0; i < tooded.Count; i++)
            {
                graphics.DrawString(tooded[i], new XFont("Arial", 14), XBrushes.Black, new XPoint(120, yt));
                yt += 15;
            }
            graphics.DrawString("Summarne hind:", new XFont("Arial", 14), XBrushes.Black, new XPoint(120, yt+10));
            for (int i = 0; i < hindeid.Count; i++)
            {
                graphics.DrawString(hindeid[i].ToString(), new XFont("Arial", 14), XBrushes.Black, new XPoint(410, yh));
                yh += 15;
            }
            graphics.DrawString(hindeid.Sum().ToString(), new XFont("Arial", 14), XBrushes.Black, new XPoint(410, yh+10));
            string time=DateTime.Now.ToString("HH.mm.ss");
            string fileName = "tsek_"+time+".pdf";

            document.Save("C:\\Users\\artur\\source\\repos\\Pood\\Pood\\tsekid\\"+fileName);
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
            //Naita_Kategooria();

        }

        private void kstTooded_Click(object sender, EventArgs e)
        {
            tooded.Clear();
            hindeid.Clear();
        }
    }
}
