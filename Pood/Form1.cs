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
using System.IO;

namespace Pood
{
    public partial class Form1 : Form
    {
        SqlConnection connect=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Pood\Pood\AppData\ToodedDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode,adapter_kat;
        OpenFileDialog piltValiDialog;
        SaveFileDialog saveValiDialog;
        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        public void Lisa_Andmed()
        {
            //CONSTRAINT [FK_Toodetable_ToTable] ([KategooriaID]) REFERENCES [dbo].[KategooriaTable] ([Id])
            if (nimeBox.Text.Trim()!=string.Empty && kogusBox.Text.Trim() != string.Empty &&
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
                hindBox.Text.Trim() != string.Empty && katBox.SelectedItem != null && Int32.Parse(hindBox.Text) > 0 && Int32.Parse(kogusBox.Text) > 0)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (ToodeNimetus,Kogus,Hind,KategooriaID)" +
                        " VALUES (@toode,@kogus,@hind,@kat)", connect); //@pilt, //Pilt
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", nimeBox.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogusBox.Text);
                    cmd.Parameters.AddWithValue("@hind", hindBox.Text);
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
                MessageBox.Show("Sissesta korektselt andmeid");
            }
        }

        private void kustutaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Toodetable WHERE Id = @rowID";

            using(SqlCommand deletedRecord = new SqlCommand(sql, connect)) 
                {
                    connect.Open();
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowId = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);
                    deletedRecord.Parameters.Add("@rowID",SqlDbType.Int).Value = rowId;
                    deletedRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    connect.Close();
                }
        }

        private void KatKstBtn_Click(object sender, EventArgs e)
        {
            if (katBox.Text=="")
                return;

            string sql = "DELETE FROM KategooriaTable WHERE KategooriaNimetus = @nimi";

            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                connect.Open();
                cmd.Parameters.AddWithValue("@nimi", katBox.Text);
                cmd.ExecuteNonQuery();
                connect.Close();

                Kustuta_Andmed();
                Naita_Kategooria();
            }
        }


        Random rnd = new Random();
        private void piltBtn_Click(object sender, EventArgs e)
        {
            piltValiDialog = new OpenFileDialog();

            piltValiDialog.InitialDirectory = @"C:\Users\opilane\Downloads";
            piltValiDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            FileInfo open_info = new FileInfo(@"C:\Users\opilane\Downloads\" + piltValiDialog.FileName);
            if (piltValiDialog.ShowDialog() == DialogResult.OK && nimeBox != null)
            {
                saveValiDialog = new SaveFileDialog();
                saveValiDialog.InitialDirectory = Path.GetFullPath(@"..\..\images");
                saveValiDialog.FileName = nimeBox.Text + Path.GetExtension(piltValiDialog.FileName); //".jpg";            
                saveValiDialog.Filter = "Image Files" + Path.GetExtension(piltValiDialog.FileName) + "|" + Path.GetExtension(piltValiDialog.FileName);


                if (saveValiDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(piltValiDialog.FileName, saveValiDialog.FileName);
                    saveValiDialog.RestoreDirectory = true;
                    toodePilt.Image = Image.FromFile(saveValiDialog.FileName);
                }
            }
        }
        int Id;
        private void uuendaBtn_Click(object sender, EventArgs e) //sdelat UPDATE
        {
            if (nimeBox.Text != "" && kogusBox.Text != "" &&
                hindBox.Text != "" && toodePilt.Image !=null)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Toodetable SET ToodeNimetus=@toode,Kogus=@kogus,Hind=@hind WHERE Id=@id", connect); //,Pilt = @pilt
                    connect.Open();
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@toode", nimeBox.Text);
                    cmd.Parameters.AddWithValue("@hind", hindBox.Text.Replace(",",".")); 
                    cmd.Parameters.AddWithValue("@kogus", kogusBox.Text);
                    //string file_pilt = nimeBox.Text + ".jpg";
                    //cmd.Parameters.AddWithValue("@pilt", file_pilt); 
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_Andmed();
                    Kustuta_Andmed();
                    MessageBox.Show("Andmed uuendatud");
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

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            nimeBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kogusBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            hindBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                toodePilt.Image = Image.FromFile(@"..\..\images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                toodePilt.Image = Image.FromFile(@"..\..\images\Info.png");
                MessageBox.Show("Fail puudub");
            }
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            katBox.SelectedIndex = Int32.Parse(v) - 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toodePilt_Click(object sender, EventArgs e)
        {

        }
    }
}
