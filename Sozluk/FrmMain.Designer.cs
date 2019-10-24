namespace Sozluk
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.BtnÖğren = new MetroFramework.Controls.MetroButton();
            this.CboxOgr = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtOrnekCumle = new MetroFramework.Controls.MetroLabel();
            this.txttKelime = new MetroFramework.Controls.MetroLabel();
            this.txtiKelime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lblAylıkToplam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbltoplam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblYilliktoplam = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 24);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(551, 272);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroTabControl1_MouseClick);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.BtnÖğren);
            this.metroTabPage1.Controls.Add(this.CboxOgr);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtOrnekCumle);
            this.metroTabPage1.Controls.Add(this.txttKelime);
            this.metroTabPage1.Controls.Add(this.txtiKelime);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(543, 230);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Kelime Öğren";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(6, 204);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Yeni Kelime";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnÖğren
            // 
            this.BtnÖğren.Location = new System.Drawing.Point(105, 204);
            this.BtnÖğren.Name = "BtnÖğren";
            this.BtnÖğren.Size = new System.Drawing.Size(75, 23);
            this.BtnÖğren.TabIndex = 7;
            this.BtnÖğren.Text = "Öğrendim";
            this.BtnÖğren.UseSelectable = true;
            this.BtnÖğren.Click += new System.EventHandler(this.BtnÖğren_Click);
            // 
            // CboxOgr
            // 
            this.CboxOgr.AutoSize = true;
            this.CboxOgr.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CboxOgr.Location = new System.Drawing.Point(148, 170);
            this.CboxOgr.Name = "CboxOgr";
            this.CboxOgr.Size = new System.Drawing.Size(32, 15);
            this.CboxOgr.TabIndex = 6;
            this.CboxOgr.Text = "   ";
            this.CboxOgr.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(70, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Öğrendim";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 119);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Ornek Cümle";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Türkçesi";
            // 
            // txtOrnekCumle
            // 
            this.txtOrnekCumle.AutoSize = true;
            this.txtOrnekCumle.Location = new System.Drawing.Point(159, 119);
            this.txtOrnekCumle.Name = "txtOrnekCumle";
            this.txtOrnekCumle.Size = new System.Drawing.Size(21, 19);
            this.txtOrnekCumle.TabIndex = 2;
            this.txtOrnekCumle.Text = "ttt";
            // 
            // txttKelime
            // 
            this.txttKelime.AutoSize = true;
            this.txttKelime.Location = new System.Drawing.Point(159, 74);
            this.txttKelime.Name = "txttKelime";
            this.txttKelime.Size = new System.Drawing.Size(21, 19);
            this.txttKelime.TabIndex = 2;
            this.txttKelime.Text = "ttt";
            // 
            // txtiKelime
            // 
            this.txtiKelime.AutoSize = true;
            this.txtiKelime.Location = new System.Drawing.Point(159, 28);
            this.txtiKelime.Name = "txtiKelime";
            this.txtiKelime.Size = new System.Drawing.Size(21, 19);
            this.txtiKelime.TabIndex = 2;
            this.txtiKelime.Text = "ttt";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kelime";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(543, 230);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Öğrendiğim Kelimeler";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 13);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(540, 214);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.dateTimePicker1);
            this.metroTabPage3.Controls.Add(this.lblAylıkToplam);
            this.metroTabPage3.Controls.Add(this.lblYilliktoplam);
            this.metroTabPage3.Controls.Add(this.metroLabel9);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.lbltoplam);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(543, 230);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Bilgilerim";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lblAylıkToplam
            // 
            this.lblAylıkToplam.AutoSize = true;
            this.lblAylıkToplam.Location = new System.Drawing.Point(3, 158);
            this.lblAylıkToplam.Name = "lblAylıkToplam";
            this.lblAylıkToplam.Size = new System.Drawing.Size(190, 19);
            this.lblAylıkToplam.TabIndex = 2;
            this.lblAylıkToplam.Text = "Aylık Öğrendiğim Kelime Sayısı";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(190, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Aylık Öğrendiğim Kelime Sayısı";
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(304, 21);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(206, 19);
            this.lbltoplam.TabIndex = 2;
            this.lbltoplam.Text = "Toplam Öğrendiğim Kelime Sayısı";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(206, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Toplam Öğrendiğim Kelime Sayısı";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(305, 120);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(189, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Yıllık Öğrendiğim Kelime Sayısı";
            // 
            // lblYilliktoplam
            // 
            this.lblYilliktoplam.AutoSize = true;
            this.lblYilliktoplam.Location = new System.Drawing.Point(304, 158);
            this.lblYilliktoplam.Name = "lblYilliktoplam";
            this.lblYilliktoplam.Size = new System.Drawing.Size(190, 19);
            this.lblYilliktoplam.TabIndex = 2;
            this.lblYilliktoplam.Text = "Aylık Öğrendiğim Kelime Sayısı";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroCheckBox CboxOgr;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel txtOrnekCumle;
        private MetroFramework.Controls.MetroLabel txttKelime;
        private MetroFramework.Controls.MetroLabel txtiKelime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnÖğren;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lblAylıkToplam;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbltoplam;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblYilliktoplam;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}