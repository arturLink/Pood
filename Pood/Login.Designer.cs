namespace Pood
{
    partial class Login
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
            this.paroolBox = new System.Windows.Forms.TextBox();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.SisParool = new System.Windows.Forms.Label();
            this.KasNimi = new System.Windows.Forms.Label();
            this.logBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paroolBox
            // 
            this.paroolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.paroolBox.Location = new System.Drawing.Point(279, 97);
            this.paroolBox.Name = "paroolBox";
            this.paroolBox.Size = new System.Drawing.Size(153, 26);
            this.paroolBox.TabIndex = 9;
            // 
            // nimiBox
            // 
            this.nimiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nimiBox.Location = new System.Drawing.Point(279, 61);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.Size = new System.Drawing.Size(153, 26);
            this.nimiBox.TabIndex = 8;
            // 
            // SisParool
            // 
            this.SisParool.AutoSize = true;
            this.SisParool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SisParool.Location = new System.Drawing.Point(60, 97);
            this.SisParool.Name = "SisParool";
            this.SisParool.Size = new System.Drawing.Size(174, 26);
            this.SisParool.TabIndex = 7;
            this.SisParool.Text = "Sisestage parool";
            this.SisParool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KasNimi
            // 
            this.KasNimi.AutoSize = true;
            this.KasNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.KasNimi.Location = new System.Drawing.Point(22, 61);
            this.KasNimi.Name = "KasNimi";
            this.KasNimi.Size = new System.Drawing.Size(212, 26);
            this.KasNimi.TabIndex = 6;
            this.KasNimi.Text = "Sisesta kasutajanimi";
            this.KasNimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logBtn.Location = new System.Drawing.Point(120, 245);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(254, 51);
            this.logBtn.TabIndex = 11;
            this.logBtn.Text = "Pole kontot? Registreeri";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.regBtn.Location = new System.Drawing.Point(161, 166);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(156, 51);
            this.regBtn.TabIndex = 10;
            this.regBtn.Text = "Logi sisse";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.paroolBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.SisParool);
            this.Controls.Add(this.KasNimi);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paroolBox;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.Label SisParool;
        private System.Windows.Forms.Label KasNimi;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button regBtn;
    }
}