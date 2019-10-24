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
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();
        DataTable dr;
        int kontrol,kontrol2 ;
        public void KelimeGetir()
        {
         

           






            kontrol = 0;
            kontrol2 = 0;
            int makskelime = db.kayitsayisi();
            int[] dizi = new int[db.Ogrenilenkelimesayisi()];
            for (int i = 0; i < db.Ogrenilenkelimesayisi(); i++)
            {
                dizi[i] = Convert.ToInt32(db.OgrenilenIdler().Rows[i][0]);
            }
            if(dizi.Length==makskelime)
            {
                //MessageBox.Show("Yeni Kelime yok");
                txtiKelime.Text = "";
                txttKelime.Text = "";
                txtOrnekCumle.Text = "";
            }
            for (int i = 0; i < makskelime; i++)
            {

                if (kontrol2 == 1) break;
                Random rkelime = new Random();
                int rastgele = 0;
                rastgele = rkelime.Next(1, makskelime + 1);
                dr = db.KelimeListeleme(rastgele);
                for (int j = 0; j < dizi.Length; j++)
                {
                   
                    if (dizi[j] == Convert.ToInt32(dr.Rows[0][0]))
                    {
                        kontrol = 1;
                        break;
                    }
                    else
                    {
                        
                        kontrol = 0;
                        kontrol2 = 1;
                        
                    }
                }               
            }
            if (kontrol == 0)
            {
                Ogrenme.ogrenilenid = Convert.ToInt32(dr.Rows[0][0]);
                txtiKelime.Text = dr.Rows[0][1].ToString();
                txttKelime.Text = dr.Rows[0][2].ToString();
                txtOrnekCumle.Text = dr.Rows[0][3].ToString();
            }
            /*else
            {
                txtiKelime.Text = "";
                txttKelime.Text = "";
                txtOrnekCumle.Text = "";
 
            }*/
        } 




        private void FrmMain_Load(object sender, EventArgs e)
        {
            Hatirlatma frm = new Hatirlatma();
            
            db.KelimeHatirlatma();
            if(Ogrenme.hatirlatmakontroldegiskeni==1)
            {

                this.Visible=false;
                frm.Show();
                


            }

            KelimeGetir();
            metroGrid1.DataSource = "";
            metroGrid1.DataSource = db.GridDoldur();

            lbltoplam.Text = db.Ogrenilenkelimesayisi().ToString();



            int ay = Convert.ToInt32(dateTimePicker1.Value.Month.ToString());
            lblAylıkToplam.Text =  db.AyaGoreKelimeSayisi(ay).ToString();
            int yil = Convert.ToInt32(dateTimePicker1.Value.Year.ToString());
            lblYilliktoplam.Text = db.YılaGoreKelimeSayisi(yil).ToString();





        }

        private void BtnÖğren_Click(object sender, EventArgs e)
        {

            if (CboxOgr.Checked == true)
            {
                db.KelimeOgrenme(Ogrenme.ogrenilenid, Ogrenme.ogrenenid);
                KelimeGetir();
                lbltoplam.Text = db.Ogrenilenkelimesayisi().ToString();
                int ay = Convert.ToInt32(dateTimePicker1.Value.Month.ToString());
                lblAylıkToplam.Text = db.AyaGoreKelimeSayisi(ay).ToString();
                int yil = Convert.ToInt32(dateTimePicker1.Value.Year.ToString());
                lblYilliktoplam.Text = db.YılaGoreKelimeSayisi(yil).ToString();

            }
            else
            {

                KelimeGetir();
            }


            



















        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            KelimeGetir();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(dateTimePicker1.Value.Month.ToString());
            lblAylıkToplam.Text = db.AyaGoreKelimeSayisi(ay).ToString();
            int yil = Convert.ToInt32(dateTimePicker1.Value.Year.ToString());
            lblYilliktoplam.Text = db.YılaGoreKelimeSayisi(yil).ToString();
        }


        private void metroTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            metroGrid1.DataSource = "";
            metroGrid1.DataSource = db.GridDoldur();
        }
    }
}