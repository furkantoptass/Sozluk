namespace Sozluk
{
    partial class Hatirlatma
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.sorulbl = new MetroFramework.Controls.MetroLabel();
            this.btniki = new MetroFramework.Controls.MetroButton();
            this.btnbir = new MetroFramework.Controls.MetroButton();
            this.btnuc = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(203, 103);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kelime";
            // 
            // sorulbl
            // 
            this.sorulbl.AutoSize = true;
            this.sorulbl.Location = new System.Drawing.Point(405, 103);
            this.sorulbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sorulbl.Name = "sorulbl";
            this.sorulbl.Size = new System.Drawing.Size(0, 0);
            this.sorulbl.TabIndex = 0;
            // 
            // btniki
            // 
            this.btniki.Location = new System.Drawing.Point(356, 192);
            this.btniki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniki.Name = "btniki";
            this.btniki.Size = new System.Drawing.Size(100, 28);
            this.btniki.TabIndex = 1;
            this.btniki.UseSelectable = true;
            this.btniki.Click += new System.EventHandler(this.btniki_Click);
            // 
            // btnbir
            // 
            this.btnbir.Location = new System.Drawing.Point(203, 192);
            this.btnbir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbir.Name = "btnbir";
            this.btnbir.Size = new System.Drawing.Size(100, 28);
            this.btnbir.TabIndex = 2;
            this.btnbir.Text = " ";
            this.btnbir.UseSelectable = true;
            this.btnbir.Click += new System.EventHandler(this.btnbir_Click);
            // 
            // btnuc
            // 
            this.btnuc.Location = new System.Drawing.Point(513, 192);
            this.btnuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnuc.Name = "btnuc";
            this.btnuc.Size = new System.Drawing.Size(100, 28);
            this.btnuc.TabIndex = 3;
            this.btnuc.Text = " ";
            this.btnuc.UseSelectable = true;
            this.btnuc.Click += new System.EventHandler(this.btnuc_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(91, 28);
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem1});
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ssToolStripMenuItem.Text = "ss";
            // 
            // ssToolStripMenuItem1
            // 
            this.ssToolStripMenuItem1.Name = "ssToolStripMenuItem1";
            this.ssToolStripMenuItem1.Size = new System.Drawing.Size(96, 26);
            this.ssToolStripMenuItem1.Text = "ss";
            // 
            // Hatirlatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 331);
            this.Controls.Add(this.btnuc);
            this.Controls.Add(this.btnbir);
            this.Controls.Add(this.btniki);
            this.Controls.Add(this.sorulbl);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hatirlatma";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Hatirlatma";
            this.Load += new System.EventHandler(this.Hatirlatma_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel sorulbl;
        private MetroFramework.Controls.MetroButton btniki;
        private MetroFramework.Controls.MetroButton btnbir;
        private MetroFramework.Controls.MetroButton btnuc;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem1;
    }
}