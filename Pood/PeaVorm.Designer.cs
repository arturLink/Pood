namespace Pood
{
    partial class PeaVorm
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
            this.juhtimineRunBtn = new System.Windows.Forms.Button();
            this.kaasaRunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // juhtimineRunBtn
            // 
            this.juhtimineRunBtn.Location = new System.Drawing.Point(94, 138);
            this.juhtimineRunBtn.Name = "juhtimineRunBtn";
            this.juhtimineRunBtn.Size = new System.Drawing.Size(261, 168);
            this.juhtimineRunBtn.TabIndex = 0;
            this.juhtimineRunBtn.Text = "Juhtimine";
            this.juhtimineRunBtn.UseVisualStyleBackColor = true;
            this.juhtimineRunBtn.Click += new System.EventHandler(this.juhtimineRunBtn_Click);
            // 
            // kaasaRunBtn
            // 
            this.kaasaRunBtn.Location = new System.Drawing.Point(448, 138);
            this.kaasaRunBtn.Name = "kaasaRunBtn";
            this.kaasaRunBtn.Size = new System.Drawing.Size(261, 168);
            this.kaasaRunBtn.TabIndex = 1;
            this.kaasaRunBtn.Text = "Kaasa";
            this.kaasaRunBtn.UseVisualStyleBackColor = true;
            this.kaasaRunBtn.Click += new System.EventHandler(this.kaasaRunBtn_Click);
            // 
            // PeaVorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kaasaRunBtn);
            this.Controls.Add(this.juhtimineRunBtn);
            this.Name = "PeaVorm";
            this.Text = "PeaVorm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button juhtimineRunBtn;
        private System.Windows.Forms.Button kaasaRunBtn;
    }
}