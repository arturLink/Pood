namespace Pood
{
    partial class registratsioon
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
            this.KasNimi = new System.Windows.Forms.Label();
            this.SisParool = new System.Windows.Forms.Label();
            this.KinParool = new System.Windows.Forms.Label();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.kinnitaBox = new System.Windows.Forms.TextBox();
            this.paroolBox = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.omKaBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // KasNimi
            // 
            this.KasNimi.AutoSize = true;
            this.KasNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.KasNimi.Location = new System.Drawing.Point(66, 58);
            this.KasNimi.Name = "KasNimi";
            this.KasNimi.Size = new System.Drawing.Size(212, 26);
            this.KasNimi.TabIndex = 0;
            this.KasNimi.Text = "Sisesta kasutajanimi";
            this.KasNimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SisParool
            // 
            this.SisParool.AutoSize = true;
            this.SisParool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SisParool.Location = new System.Drawing.Point(104, 94);
            this.SisParool.Name = "SisParool";
            this.SisParool.Size = new System.Drawing.Size(174, 26);
            this.SisParool.TabIndex = 1;
            this.SisParool.Text = "Sisestage parool";
            this.SisParool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KinParool
            // 
            this.KinParool.AutoSize = true;
            this.KinParool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.KinParool.Location = new System.Drawing.Point(133, 129);
            this.KinParool.Name = "KinParool";
            this.KinParool.Size = new System.Drawing.Size(145, 26);
            this.KinParool.TabIndex = 2;
            this.KinParool.Text = "Kinnita parool";
            this.KinParool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nimiBox
            // 
            this.nimiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nimiBox.Location = new System.Drawing.Point(323, 58);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.Size = new System.Drawing.Size(153, 26);
            this.nimiBox.TabIndex = 3;
            // 
            // kinnitaBox
            // 
            this.kinnitaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kinnitaBox.Location = new System.Drawing.Point(323, 129);
            this.kinnitaBox.Name = "kinnitaBox";
            this.kinnitaBox.Size = new System.Drawing.Size(153, 26);
            this.kinnitaBox.TabIndex = 4;
            // 
            // paroolBox
            // 
            this.paroolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.paroolBox.Location = new System.Drawing.Point(323, 94);
            this.paroolBox.Name = "paroolBox";
            this.paroolBox.Size = new System.Drawing.Size(153, 26);
            this.paroolBox.TabIndex = 5;
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.regBtn.Location = new System.Drawing.Point(221, 223);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(156, 51);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Registreeri";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logBtn.Location = new System.Drawing.Point(167, 293);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(254, 51);
            this.logBtn.TabIndex = 7;
            this.logBtn.Text = "On juba konto? Logi sisse";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // omKaBox
            // 
            this.omKaBox.AutoSize = true;
            this.omKaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.omKaBox.Location = new System.Drawing.Point(104, 171);
            this.omKaBox.Name = "omKaBox";
            this.omKaBox.Size = new System.Drawing.Size(179, 26);
            this.omKaBox.TabIndex = 8;
            this.omKaBox.Text = "Omanik/Kasutaja";
            this.omKaBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(323, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // registratsioon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.omKaBox);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.paroolBox);
            this.Controls.Add(this.kinnitaBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.KinParool);
            this.Controls.Add(this.SisParool);
            this.Controls.Add(this.KasNimi);
            this.Name = "registratsioon";
            this.Text = "Logi";
            this.Load += new System.EventHandler(this.registratsioon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KasNimi;
        private System.Windows.Forms.Label SisParool;
        private System.Windows.Forms.Label KinParool;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.TextBox kinnitaBox;
        private System.Windows.Forms.TextBox paroolBox;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label omKaBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}