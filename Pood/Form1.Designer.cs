namespace Pood
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nimeBox = new System.Windows.Forms.TextBox();
            this.hindBox = new System.Windows.Forms.TextBox();
            this.kogusBox = new System.Windows.Forms.TextBox();
            this.toodelbl = new System.Windows.Forms.Label();
            this.koguslbl = new System.Windows.Forms.Label();
            this.hindlbl = new System.Windows.Forms.Label();
            this.kategoorialbl = new System.Windows.Forms.Label();
            this.katBox = new System.Windows.Forms.ComboBox();
            this.toodePilt = new System.Windows.Forms.PictureBox();
            this.piltBtn = new System.Windows.Forms.Button();
            this.liisaBtn = new System.Windows.Forms.Button();
            this.kustutaBtn = new System.Windows.Forms.Button();
            this.uuendaBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LisaBtn = new System.Windows.Forms.Button();
            this.KatKstBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toodePilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nimeBox
            // 
            this.nimeBox.Location = new System.Drawing.Point(121, 36);
            this.nimeBox.Name = "nimeBox";
            this.nimeBox.Size = new System.Drawing.Size(174, 20);
            this.nimeBox.TabIndex = 0;
            this.nimeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hindBox
            // 
            this.hindBox.Location = new System.Drawing.Point(121, 88);
            this.hindBox.Name = "hindBox";
            this.hindBox.Size = new System.Drawing.Size(174, 20);
            this.hindBox.TabIndex = 2;
            this.hindBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // kogusBox
            // 
            this.kogusBox.Location = new System.Drawing.Point(121, 62);
            this.kogusBox.Name = "kogusBox";
            this.kogusBox.Size = new System.Drawing.Size(174, 20);
            this.kogusBox.TabIndex = 3;
            this.kogusBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // toodelbl
            // 
            this.toodelbl.AutoSize = true;
            this.toodelbl.Location = new System.Drawing.Point(24, 39);
            this.toodelbl.Name = "toodelbl";
            this.toodelbl.Size = new System.Drawing.Size(77, 13);
            this.toodelbl.TabIndex = 4;
            this.toodelbl.Text = "Toode nimetus";
            this.toodelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // koguslbl
            // 
            this.koguslbl.AutoSize = true;
            this.koguslbl.Location = new System.Drawing.Point(64, 65);
            this.koguslbl.Name = "koguslbl";
            this.koguslbl.Size = new System.Drawing.Size(37, 13);
            this.koguslbl.TabIndex = 5;
            this.koguslbl.Text = "Kogus";
            this.koguslbl.Click += new System.EventHandler(this.koguslbl_Click);
            // 
            // hindlbl
            // 
            this.hindlbl.AutoSize = true;
            this.hindlbl.Location = new System.Drawing.Point(72, 91);
            this.hindlbl.Name = "hindlbl";
            this.hindlbl.Size = new System.Drawing.Size(29, 13);
            this.hindlbl.TabIndex = 6;
            this.hindlbl.Text = "Hind";
            // 
            // kategoorialbl
            // 
            this.kategoorialbl.AutoSize = true;
            this.kategoorialbl.Location = new System.Drawing.Point(43, 117);
            this.kategoorialbl.Name = "kategoorialbl";
            this.kategoorialbl.Size = new System.Drawing.Size(58, 13);
            this.kategoorialbl.TabIndex = 7;
            this.kategoorialbl.Text = "Kategooria";
            // 
            // katBox
            // 
            this.katBox.FormattingEnabled = true;
            this.katBox.Location = new System.Drawing.Point(121, 114);
            this.katBox.Name = "katBox";
            this.katBox.Size = new System.Drawing.Size(174, 21);
            this.katBox.TabIndex = 8;
            // 
            // toodePilt
            // 
            this.toodePilt.Location = new System.Drawing.Point(327, 16);
            this.toodePilt.Name = "toodePilt";
            this.toodePilt.Size = new System.Drawing.Size(439, 216);
            this.toodePilt.TabIndex = 9;
            this.toodePilt.TabStop = false;
            this.toodePilt.Click += new System.EventHandler(this.toodePilt_Click);
            // 
            // piltBtn
            // 
            this.piltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.piltBtn.Location = new System.Drawing.Point(664, 238);
            this.piltBtn.Name = "piltBtn";
            this.piltBtn.Size = new System.Drawing.Size(86, 28);
            this.piltBtn.TabIndex = 10;
            this.piltBtn.Text = "Otsi fail";
            this.piltBtn.UseVisualStyleBackColor = true;
            this.piltBtn.Click += new System.EventHandler(this.piltBtn_Click);
            // 
            // liisaBtn
            // 
            this.liisaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.liisaBtn.Location = new System.Drawing.Point(572, 238);
            this.liisaBtn.Name = "liisaBtn";
            this.liisaBtn.Size = new System.Drawing.Size(86, 28);
            this.liisaBtn.TabIndex = 11;
            this.liisaBtn.Text = "Liisa";
            this.liisaBtn.UseVisualStyleBackColor = true;
            this.liisaBtn.Click += new System.EventHandler(this.liisaBtn_Click);
            // 
            // kustutaBtn
            // 
            this.kustutaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kustutaBtn.Location = new System.Drawing.Point(388, 238);
            this.kustutaBtn.Name = "kustutaBtn";
            this.kustutaBtn.Size = new System.Drawing.Size(86, 28);
            this.kustutaBtn.TabIndex = 12;
            this.kustutaBtn.Text = "Kustuta";
            this.kustutaBtn.UseVisualStyleBackColor = true;
            this.kustutaBtn.Click += new System.EventHandler(this.kustutaBtn_Click);
            // 
            // uuendaBtn
            // 
            this.uuendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.uuendaBtn.Location = new System.Drawing.Point(480, 238);
            this.uuendaBtn.Name = "uuendaBtn";
            this.uuendaBtn.Size = new System.Drawing.Size(86, 28);
            this.uuendaBtn.TabIndex = 13;
            this.uuendaBtn.Text = "Uuenda";
            this.uuendaBtn.UseVisualStyleBackColor = true;
            this.uuendaBtn.Click += new System.EventHandler(this.uuendaBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 164);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // LisaBtn
            // 
            this.LisaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LisaBtn.Location = new System.Drawing.Point(208, 151);
            this.LisaBtn.Name = "LisaBtn";
            this.LisaBtn.Size = new System.Drawing.Size(98, 35);
            this.LisaBtn.TabIndex = 15;
            this.LisaBtn.Text = "Liisa kategooria";
            this.LisaBtn.UseVisualStyleBackColor = true;
            this.LisaBtn.Click += new System.EventHandler(this.LisaBtn_Click);
            // 
            // KatKstBtn
            // 
            this.KatKstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KatKstBtn.Location = new System.Drawing.Point(104, 151);
            this.KatKstBtn.Name = "KatKstBtn";
            this.KatKstBtn.Size = new System.Drawing.Size(98, 35);
            this.KatKstBtn.TabIndex = 16;
            this.KatKstBtn.Text = "Kustuta kategooria";
            this.KatKstBtn.UseVisualStyleBackColor = true;
            this.KatKstBtn.Click += new System.EventHandler(this.KatKstBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KatKstBtn);
            this.Controls.Add(this.LisaBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uuendaBtn);
            this.Controls.Add(this.kustutaBtn);
            this.Controls.Add(this.liisaBtn);
            this.Controls.Add(this.piltBtn);
            this.Controls.Add(this.toodePilt);
            this.Controls.Add(this.katBox);
            this.Controls.Add(this.kategoorialbl);
            this.Controls.Add(this.hindlbl);
            this.Controls.Add(this.koguslbl);
            this.Controls.Add(this.toodelbl);
            this.Controls.Add(this.kogusBox);
            this.Controls.Add(this.hindBox);
            this.Controls.Add(this.nimeBox);
            this.Name = "Form1";
            this.Text = "Pood";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toodePilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nimeBox;
        private System.Windows.Forms.TextBox hindBox;
        private System.Windows.Forms.TextBox kogusBox;
        private System.Windows.Forms.Label toodelbl;
        private System.Windows.Forms.Label koguslbl;
        private System.Windows.Forms.Label hindlbl;
        private System.Windows.Forms.Label kategoorialbl;
        private System.Windows.Forms.ComboBox katBox;
        private System.Windows.Forms.PictureBox toodePilt;
        private System.Windows.Forms.Button piltBtn;
        private System.Windows.Forms.Button liisaBtn;
        private System.Windows.Forms.Button kustutaBtn;
        private System.Windows.Forms.Button uuendaBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LisaBtn;
        private System.Windows.Forms.Button KatKstBtn;
    }
}

