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
namespace Sozluk
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader dr;
            db.connectDataBase();
            cmd = new SqlCommand();
            cmd.Connection = db.connectDataBase();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM kullanici where Isim='" + txtIsim.Text + "' AND Sifre='" + txtSifre.Text + "' AND YetkiTuru='" + '1' + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SqlConnection con;
                con = db.connectDataBase();
                con.Open();
                string sorgu = "SELECT id  FROM kullanici where Isim='" + txtIsim.Text + "' AND Sifre='" + txtSifre.Text + "' AND YetkiTuru='" + '1' + "'";
                SqlCommand cmd2 = new SqlCommand(sorgu, con);
                Ogrenme.ogrenenid = Convert.ToInt32(cmd2.ExecuteScalar());
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
        }
    }
}
