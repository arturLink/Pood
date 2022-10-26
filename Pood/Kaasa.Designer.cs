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
            this.katBox = new System.Windows.Forms.ComboBox();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.hindBox = new System.Windows.Forms.TextBox();
            this.kogusBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodePlt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // toodePlt
            // 
            this.toodePlt.Location = new System.Drawing.Point(404, 12);
            this.toodePlt.Name = "toodePlt";
            this.toodePlt.Size = new System.Drawing.Size(356, 229);
            this.toodePlt.TabIndex = 1;
            this.toodePlt.TabStop = false;
            // 
            // liisaKorvBtn
            // 
            this.liisaKorvBtn.Location = new System.Drawing.Point(44, 192);
            this.liisaKorvBtn.Name = "liisaKorvBtn";
            this.liisaKorvBtn.Size = new System.Drawing.Size(97, 49);
            this.liisaKorvBtn.TabIndex = 2;
            this.liisaKorvBtn.Text = "Liisa Toode Korvi";
            this.liisaKorvBtn.UseVisualStyleBackColor = true;
            // 
            // ostaBtn
            // 
            this.ostaBtn.Location = new System.Drawing.Point(280, 192);
            this.ostaBtn.Name = "ostaBtn";
            this.ostaBtn.Size = new System.Drawing.Size(97, 49);
            this.ostaBtn.TabIndex = 3;
            this.ostaBtn.Text = "Osta";
            this.ostaBtn.UseVisualStyleBackColor = true;
            // 
            // toodeTxt
            // 
            this.toodeTxt.AutoSize = true;
            this.toodeTxt.Location = new System.Drawing.Point(41, 26);
            this.toodeTxt.Name = "toodeTxt";
            this.toodeTxt.Size = new System.Drawing.Size(61, 13);
            this.toodeTxt.TabIndex = 4;
            this.toodeTxt.Text = "Toode Nimi";
            // 
            // hindTxt
            // 
            this.hindTxt.AutoSize = true;
            this.hindTxt.Location = new System.Drawing.Point(41, 53);
            this.hindTxt.Name = "hindTxt";
            this.hindTxt.Size = new System.Drawing.Size(29, 13);
            this.hindTxt.TabIndex = 5;
            this.hindTxt.Text = "Hind";
            // 
            // kogusTxt
            // 
            this.kogusTxt.AutoSize = true;
            this.kogusTxt.Location = new System.Drawing.Point(41, 86);
            this.kogusTxt.Name = "kogusTxt";
            this.kogusTxt.Size = new System.Drawing.Size(37, 13);
            this.kogusTxt.TabIndex = 6;
            this.kogusTxt.Text = "Kogus";
            // 
            // katTxt
            // 
            this.katTxt.AutoSize = true;
            this.katTxt.Location = new System.Drawing.Point(41, 120);
            this.katTxt.Name = "katTxt";
            this.katTxt.Size = new System.Drawing.Size(58, 13);
            this.katTxt.TabIndex = 7;
            this.katTxt.Text = "Kategooria";
            // 
            // katBox
            // 
            this.katBox.FormattingEnabled = true;
            this.katBox.Location = new System.Drawing.Point(139, 117);
            this.katBox.Name = "katBox";
            this.katBox.Size = new System.Drawing.Size(152, 21);
            this.katBox.TabIndex = 8;
            // 
            // nimiBox
            // 
            this.nimiBox.Location = new System.Drawing.Point(139, 23);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.Size = new System.Drawing.Size(152, 20);
            this.nimiBox.TabIndex = 9;
            // 
            // hindBox
            // 
            this.hindBox.Location = new System.Drawing.Point(139, 50);
            this.hindBox.Name = "hindBox";
            this.hindBox.Size = new System.Drawing.Size(152, 20);
            this.hindBox.TabIndex = 10;
            // 
            // kogusBox
            // 
            this.kogusBox.Location = new System.Drawing.Point(139, 83);
            this.kogusBox.Name = "kogusBox";
            this.kogusBox.Size = new System.Drawing.Size(152, 20);
            this.kogusBox.TabIndex = 11;
            // 
            // Kaasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kogusBox);
            this.Controls.Add(this.hindBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.katBox);
            this.Controls.Add(this.katTxt);
            this.Controls.Add(this.kogusTxt);
            this.Controls.Add(this.hindTxt);
            this.Controls.Add(this.toodeTxt);
            this.Controls.Add(this.ostaBtn);
            this.Controls.Add(this.liisaKorvBtn);
            this.Controls.Add(this.toodePlt);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.ComboBox katBox;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.TextBox hindBox;
        private System.Windows.Forms.TextBox kogusBox;
    }
}