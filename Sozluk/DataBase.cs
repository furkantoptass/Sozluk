using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
namespace Sozluk
{
    public class DataBase
    {

        public  SqlConnection con;
        SqlCommand cmd;
        

        public SqlConnection connectDataBase()
        { 
            con = new SqlConnection("Server=Desktop-BOMMP45;Database=sozluk;Trusted_Connection=True; Initial Catalog=sozluk;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
            return con;
        }

        public DataTable KelimeListeleme(int id)
        {
            con = connectDataBase();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id,tKelime,iKelime,OrnekCumle from Kelime Where id="+id, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable OgrenilenKelime(int id)
        {
            con = connectDataBase();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id,OgrenilenId,OgrenenId,Tarih,Seviye from OgrenilenKelime Where id=" + id, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable OgrenilenKelime2(int id)
        {
            con = connectDataBase();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from OgrenilenKelime Where OgrenenId=" + id, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public int kayitsayisi()
        {
            int kayitsayisi = -1;
            con = connectDataBase();
            con.Open();
            cmd = new SqlCommand("select count(*) from Kelime ", con);
            kayitsayisi = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return kayitsayisi;
        }
        public void KelimeOgrenme(int ogrenilenid,int ogrenenid)
        {
            con = connectDataBase();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into OgrenilenKelime (OgrenilenId,OgrenenId,Tarih,Seviye) Values('" + ogrenilenid +"','" + ogrenenid + "','" + DateTime.Now + "','" + 1 +  "')", con);
            cmd.ExecuteScalar();
            con.Close();
        }
        public int Ogrenilenkelimesayisi()
        {
            int kayitsayisi = -1;
            con = connectDataBase();
            con.Open();
            cmd = new SqlCommand("select count(*) from OgrenilenKelime Where OgrenenId='"+Ogrenme.ogrenenid + "'", con);
            kayitsayisi = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return kayitsayisi;
        }

        public DataTable OgrenilenIdler()
        {
            con = connectDataBase();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT OgrenilenId from OgrenilenKelime Where OgrenenId='" + Ogrenme.ogrenenid + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
       
            con.Close();
            return dt;
        }
        
        public DataTable GridDoldur()
        {
            DataTable dt = new DataTable();
            int[] dizi = new int[Ogrenilenkelimesayisi()];
            for (int i = 0; i < Ogrenilenkelimesayisi(); i++)
            {
                dizi[i] = Convert.ToInt32(OgrenilenIdler().Rows[i][0]);
               
            }
            for (int i = 0; i < Ogrenilenkelimesayisi(); i++)
            {
                con = connectDataBase();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT tkelime,ikelime,OrnekCumle from Kelime  Where id='" + dizi[i] + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            con.Close();
            return dt;

        }
        public void KelimeHatirlatma()
        {
            int[] dizi = new int[Ogrenilenkelimesayisi()];
            for (int i = 0; i < Ogrenilenkelimesayisi(); i++)
            {
                dizi[i] = Convert.ToInt32(OgrenilenIdler().Rows[i][0]);
            }


            int kontrol = 0;
            if (kontrol!=Ogrenilenkelimesayisi())
            {

            
            for (int i = 0; i <= Ogrenilenkelimesayisi(); i++)
            {
                DataTable dt = OgrenilenKelime2(Ogrenme.ogrenenid);
               // DataTable dt   = OgrenilenKelime(i);
                Ogrenme.hatirlatmakontroldegiskeni = 0;
                int seviye = Convert.ToInt32(dt.Rows[0][4]);
                DateTime tarih = Convert.ToDateTime(dt.Rows[0][3]);
                if (seviye == 1 && DateTime.Now.AddDays(-1) > tarih)
                {
                    Ogrenme.hatirlatmaid = Convert.ToInt32(dt.Rows[0][1]);
                    Ogrenme.hatirlatmakontroldegiskeni = 1;
                    break;
                    
                }
                if (seviye == 2 && DateTime.Now.AddDays(-7) > tarih)
                {
                    Ogrenme.hatirlatmaid = Convert.ToInt32(dt.Rows[0][1]);
                    Ogrenme.hatirlatmakontroldegiskeni = 1;
                    break;
                }
                if (seviye == 3 && DateTime.Now.AddMonths(-1) > tarih)
                {
                    Ogrenme.hatirlatmaid = Convert.ToInt32(dt.Rows[0][1]);
                    Ogrenme.hatirlatmakontroldegiskeni = 1;
                    break;
                }
                if (seviye == 4 && DateTime.Now.AddYears(-1) > tarih)
                {
                    Ogrenme.hatirlatmaid = Convert.ToInt32(dt.Rows[0][1]);
                    Ogrenme.hatirlatmakontroldegiskeni = 1;
                    break;
                }

                }

        }
        }



        public int AyaGoreKelimeSayisi(int ay)
        {
            int sayac = 0;


            for (int i = 1; i <= Ogrenilenkelimesayisi(); i++)
            {
                con = connectDataBase();
                
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Tarih from OgrenilenKelime Where id=" + i, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                DateTime dbtarih = Convert.ToDateTime(dt.Rows[0][0]);
                int dbtarihh = Convert.ToInt32(dbtarih.Month);

                if (ay==dbtarihh)
                {
                    sayac++;
                }
                
            }
            return sayac;
        }
        public int YılaGoreKelimeSayisi(int yil)
        {
            int sayac = 0;


            for (int i = 1; i <= Ogrenilenkelimesayisi(); i++)
            {
                con = connectDataBase();

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Tarih from OgrenilenKelime Where id=" + i, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                DateTime dbtarih = Convert.ToDateTime(dt.Rows[0][0]);
                int dbtarihh = Convert.ToInt32(dbtarih.Year);

                if (yil == dbtarihh)
                {
                    sayac++;
                }

            }
            return sayac;
        }

        public void SeviyeYukseltme(int seviye,int gelenid)
        {
            con = connectDataBase();
            con.Open();
            seviye += 1;
            SqlCommand cmd = new SqlCommand("UPDATE OgrenilenKelime SET Seviye ='" + seviye + "' WHERE OgrenilenId =" + gelenid, con);
            cmd.ExecuteScalar();
            con.Close();
        }
        public void SeviyeDusurme(int seviye, int gelenid)
        {
            con = connectDataBase();
            con.Open();
            seviye += 1;
            SqlCommand cmd = new SqlCommand("UPDATE OgrenilenKelime SET Seviye =" + 1 +",Tarih='" + DateTime.Now +    "' WHERE OgrenilenId =" + gelenid, con);
            cmd.ExecuteScalar();
            con.Close();
        }


    }
}
