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
    public partial class Hatirlatma : MetroFramework.Forms.MetroForm
    {
        public Hatirlatma()
        {
            InitializeComponent();
        }

       


        public void yenileme()
        {
            DataBase db = new DataBase();
            Hatirlatma frm = new Hatirlatma();

            db.KelimeHatirlatma();
            if (Ogrenme.hatirlatmakontroldegiskeni == 1)
            {

                this.Close();
                frm.Show();



            }
            if(Ogrenme.hatirlatmakontroldegiskeni!=1)
            {
                this.Close();
                FrmMain frm2 = new FrmMain();
                frm2.Show();
                
            }



        }




        private void Hatirlatma_Load(object sender, EventArgs e)
        {
            int kontrol = 1,kontrol2=0;
            int rastgele1 = 0;
            int rastgele2 = 0;
            int rastgele3 = 0;
            DataBase db = new DataBase();
            Random rdn1 = new Random();

            rastgele1 = rdn1.Next(1, 4);
            int makskelime = db.kayitsayisi();
            rastgele2 = rdn1.Next(1, makskelime + 1);
            rastgele3 = rdn1.Next(1, makskelime + 1);

            while (kontrol!=0)
            {
                if(kontrol2==0)
                {
                    rastgele1 = rdn1.Next(1, 4);
                    rastgele2 = rdn1.Next(1, makskelime + 1);
                    rastgele3 = rdn1.Next(1, makskelime + 1);
                }

                if(rastgele1!=rastgele2 && rastgele1!=rastgele3 && rastgele2!= rastgele3 && rastgele1 != Ogrenme.hatirlatmaid && rastgele2 != Ogrenme.hatirlatmaid && rastgele3 != Ogrenme.hatirlatmaid)
                { 
                
                kontrol =0;
                kontrol2 = 1;
                }
            }


            sorulbl.Text = db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][2].ToString();

            if (rastgele1 == 1)
            {

                btnbir.Text = db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString();
                btniki.Text = db.KelimeListeleme(rastgele2).Rows[0][1].ToString();
                btnuc.Text = db.KelimeListeleme(rastgele3).Rows[0][1].ToString();
            }
            if (rastgele1==2 )
            {
                btniki.Text = db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString();
                btnbir.Text = db.KelimeListeleme(rastgele2).Rows[0][1].ToString();
                btnuc.Text = db.KelimeListeleme(rastgele3).Rows[0][1].ToString();
            }
            if (rastgele1==3 )
            {
                btnuc.Text = db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString();
                btniki.Text = db.KelimeListeleme(rastgele2).Rows[0][1].ToString();
                btnbir.Text = db.KelimeListeleme(rastgele3).Rows[0][1].ToString();
            }







        }
     
        private void btniki_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt = db.OgrenilenKelime(Ogrenme.hatirlatmaid);
     
            if (btniki.Text == db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString())
            {
                db.SeviyeYukseltme(Convert.ToInt32(dt.Rows[0][4]), Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye yükseldi");
                yenileme();
            }
            else
            {
                db.SeviyeDusurme(Convert.ToInt32(dt.Rows[0][4]), Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye dustu");
                yenileme();
            }
               
        }

        private void btnbir_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt = db.OgrenilenKelime(Ogrenme.hatirlatmaid);
         
            if (btnbir.Text == db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString())
            {

                db.SeviyeYukseltme(Convert.ToInt32(dt.Rows[0][4]),Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye yükseldi");
                yenileme();
            }
            else
            {
                db.SeviyeDusurme(Convert.ToInt32(dt.Rows[0][4]), Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye dustu");
                yenileme();
            }
        }

      

        private void btnuc_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable dt = db.OgrenilenKelime(Ogrenme.hatirlatmaid);
      
            if (btnuc.Text == db.KelimeListeleme(Ogrenme.hatirlatmaid).Rows[0][1].ToString())
            {
                db.SeviyeYukseltme(Convert.ToInt32(dt.Rows[0][4]), Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye yükseldi");
                yenileme();
            }
            else
            {
                db.SeviyeDusurme(Convert.ToInt32(dt.Rows[0][4]), Ogrenme.hatirlatmaid);
                MessageBox.Show("seviye dustu");
                yenileme();
            }
        }
    }
}
