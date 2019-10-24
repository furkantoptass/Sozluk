namespace Sozluk
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
            this.txtIsim = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.BtnGiris = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            // 
            // 
            // 
            this.txtIsim.CustomButton.Image = null;
            this.txtIsim.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtIsim.CustomButton.Name = "";
            this.txtIsim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIsim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIsim.CustomButton.TabIndex = 1;
            this.txtIsim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIsim.CustomButton.UseSelectable = true;
            this.txtIsim.CustomButton.Visible = false;
            this.txtIsim.Lines = new string[0];
            this.txtIsim.Location = new System.Drawing.Point(106, 73);
            this.txtIsim.MaxLength = 32767;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PasswordChar = '\0';
            this.txtIsim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIsim.SelectedText = "";
            this.txtIsim.SelectionLength = 0;
            this.txtIsim.SelectionStart = 0;
            this.txtIsim.ShortcutsEnabled = true;
            this.txtIsim.Size = new System.Drawing.Size(100, 23);
            this.txtIsim.TabIndex = 3;
            this.txtIsim.UseSelectable = true;
            this.txtIsim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIsim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(106, 115);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(100, 23);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(106, 144);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(100, 23);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giris";
            this.BtnGiris.UseSelectable = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "İsim";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 231);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtIsim;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton BtnGiris;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

