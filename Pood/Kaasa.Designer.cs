namespace Pood
{
    partial class Kaasa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toodePlt = new System.Windows.Forms.PictureBox();
            this.liisaKorvBtn = new System.Windows.Forms.Button();
            this.ostaBtn = new System.Windows.Forms.Button();
            this.toodeTxt = new System.Windows.Forms.Label();
            this.hindTxt = new System.Windows.Forms.Label();
            this.kogusTxt = new System.Windows.Forms.Label();
            this.katTxt = new System.Windows.Forms.Label();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.hindBox = new System.Windows.Forms.TextBox();
            this.kogusBox = new System.Windows.Forms.TextBox();
            this.katBox = new System.Windows.Forms.TextBox();
            this.kstTooded = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodePlt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 405);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // toodePlt
            // 
            this.toodePlt.Location = new System.Drawing.Point(606, 18);
            this.toodePlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toodePlt.Name = "toodePlt";
            this.toodePlt.Size = new System.Drawing.Size(534, 352);
            this.toodePlt.TabIndex = 1;
            this.toodePlt.TabStop = false;
            // 
            // liisaKorvBtn
            // 
            this.liisaKorvBtn.Location = new System.Drawing.Point(66, 244);
            this.liisaKorvBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.liisaKorvBtn.Name = "liisaKorvBtn";
            this.liisaKorvBtn.Size = new System.Drawing.Size(161, 126);
            this.liisaKorvBtn.TabIndex = 2;
            this.liisaKorvBtn.Text = "Liisa Toode Korvi";
            this.liisaKorvBtn.UseVisualStyleBackColor = true;
            this.liisaKorvBtn.Click += new System.EventHandler(this.liisaKorvBtn_Click);
            // 
            // ostaBtn
            // 
            this.ostaBtn.Location = new System.Drawing.Point(273, 244);
            this.ostaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ostaBtn.Name = "ostaBtn";
            this.ostaBtn.Size = new System.Drawing.Size(161, 126);
            this.ostaBtn.TabIndex = 3;
            this.ostaBtn.Text = "Osta";
            this.ostaBtn.UseVisualStyleBackColor = true;
            this.ostaBtn.Click += new System.EventHandler(this.ostaBtn_Click);
            // 
            // toodeTxt
            // 
            this.toodeTxt.AutoSize = true;
            this.toodeTxt.Location = new System.Drawing.Point(62, 40);
            this.toodeTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toodeTxt.Name = "toodeTxt";
            this.toodeTxt.Size = new System.Drawing.Size(88, 20);
            this.toodeTxt.TabIndex = 4;
            this.toodeTxt.Text = "Toode Nimi";
            // 
            // hindTxt
            // 
            this.hindTxt.AutoSize = true;
            this.hindTxt.Location = new System.Drawing.Point(62, 82);
            this.hindTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hindTxt.Name = "hindTxt";
            this.hindTxt.Size = new System.Drawing.Size(42, 20);
            this.hindTxt.TabIndex = 5;
            this.hindTxt.Text = "Hind";
            // 
            // kogusTxt
            // 
            this.kogusTxt.AutoSize = true;
            this.kogusTxt.Location = new System.Drawing.Point(62, 132);
            this.kogusTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kogusTxt.Name = "kogusTxt";
            this.kogusTxt.Size = new System.Drawing.Size(54, 20);
            this.kogusTxt.TabIndex = 6;
            this.kogusTxt.Text = "Kogus";
            // 
            // katTxt
            // 
            this.katTxt.AutoSize = true;
            this.katTxt.Location = new System.Drawing.Point(62, 185);
            this.katTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.katTxt.Name = "katTxt";
            this.katTxt.Size = new System.Drawing.Size(86, 20);
            this.katTxt.TabIndex = 7;
            this.katTxt.Text = "Kategooria";
            // 
            // nimiBox
            // 
            this.nimiBox.Location = new System.Drawing.Point(208, 35);
            this.nimiBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.ReadOnly = true;
            this.nimiBox.Size = new System.Drawing.Size(226, 26);
            this.nimiBox.TabIndex = 9;
            // 
            // hindBox
            // 
            this.hindBox.Location = new System.Drawing.Point(208, 77);
            this.hindBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hindBox.Name = "hindBox";
            this.hindBox.ReadOnly = true;
            this.hindBox.Size = new System.Drawing.Size(226, 26);
            this.hindBox.TabIndex = 10;
            // 
            // kogusBox
            // 
            this.kogusBox.Location = new System.Drawing.Point(208, 128);
            this.kogusBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kogusBox.Name = "kogusBox";
            this.kogusBox.Size = new System.Drawing.Size(226, 26);
            this.kogusBox.TabIndex = 11;
            // 
            // katBox
            // 
            this.katBox.Location = new System.Drawing.Point(208, 179);
            this.katBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.katBox.Name = "katBox";
            this.katBox.ReadOnly = true;
            this.katBox.Size = new System.Drawing.Size(226, 26);
            this.katBox.TabIndex = 12;
            // 
            // kstTooded
            // 
            this.kstTooded.Location = new System.Drawing.Point(455, 40);
            this.kstTooded.Name = "kstTooded";
            this.kstTooded.Size = new System.Drawing.Size(134, 80);
            this.kstTooded.TabIndex = 13;
            this.kstTooded.Text = "Kustuta Tooded Korvis";
            this.kstTooded.UseVisualStyleBackColor = true;
            this.kstTooded.Click += new System.EventHandler(this.kstTooded_Click);
            // 
            // Kaasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.kstTooded);
            this.Controls.Add(this.katBox);
            this.Controls.Add(this.kogusBox);
            this.Controls.Add(this.hindBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.katTxt);
            this.Controls.Add(this.kogusTxt);
            this.Controls.Add(this.hindTxt);
            this.Controls.Add(this.toodeTxt);
            this.Controls.Add(this.ostaBtn);
            this.Controls.Add(this.liisaKorvBtn);
            this.Controls.Add(this.toodePlt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kaasa";
            this.Text = "Kaasa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodePlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox toodePlt;
        private System.Windows.Forms.Button liisaKorvBtn;
        private System.Windows.Forms.Button ostaBtn;
        private System.Windows.Forms.Label toodeTxt;
        private System.Windows.Forms.Label hindTxt;
        private System.Windows.Forms.Label kogusTxt;
        private System.Windows.Forms.Label katTxt;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.TextBox hindBox;
        private System.Windows.Forms.TextBox kogusBox;
        private System.Windows.Forms.TextBox katBox;
        private System.Windows.Forms.Button kstTooded;
    }
}