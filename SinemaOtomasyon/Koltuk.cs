using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaOtomasyon
{
    public partial class Koltuk : Form
    {
        private string _szFilmAdi = "";
        private string _szSeans = "";
        private string _szTarih = "";

        public Koltuk(string szFilm, string szSeans,string szTarih)
        {
            _szFilmAdi = szFilm;
            _szSeans = szSeans;
            _szTarih = szTarih;
            InitializeComponent();
            
        }
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
        public void verileriAl()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from BiletUcret ", baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                label8.Text = (string)dr["yetiskin"];
                label11.Text = (string)dr["ogrenci"];

            }
            baglanti.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button82_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("İşlemi İptal Etmekte Emin misiniz ?", "Sinema Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Koltuk.ActiveForm.Hide();
                BiletSatıs ac = new BiletSatıs();
                ac.ShowDialog();
               
            }
            else
            {
                Koltuk.ActiveForm.Show();
            }

        }
        public void KoltukSecimi(Button refButn)
        {
            if (refButn is Button)
            {

                if (refButn.Tag.ToString().Contains("Koltuk"))
                {

                    if (((Button)refButn).BackColor == Color.Red)
                    {
                        ((Button)refButn).BackColor = Color.WhiteSmoke;
                    }
                    else if (((Button)refButn).BackColor == Color.WhiteSmoke)
                    {
                        ((Button)refButn).BackColor = Color.Red;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            KoltukSecimi(btt1);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btt1.BackColor = Color.BlueViolet;
        }

        private void button61_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button81_Click(object sender, EventArgs e)
        {
            foreach (Control item_ in this.Controls)
            {
                if (item_ is Label)
                {
                    if (item_.Text == "")
                    {
                        MessageBox.Show("Lütfen Bilet Türü ve Sayısıni Girdikten Sonra Ücrete Tıklayınız.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        List<string> satilacakKoltuklar = new List<string>();
                        foreach (Control item in this.Controls)
                        {
                            if (item is Button)
                            {
                                if (((Button)item).BackColor == Color.Red)
                                {
                                    satilacakKoltuklar.Add(item.Tag.ToString());
                                }
                            }
                        }

                        BiletSatıs frmBiletSatir = new BiletSatıs();
                        frmBiletSatir.baglanti.Open();
                        string szQuerrey = "";
                        foreach (string szKoltuk in satilacakKoltuklar)
                        {
                            szQuerrey += " Insert into KoltukTb (FilmAdi,KoltukAdi,Tutar,Seans,Tarih) Values('" + _szFilmAdi + "','" + szKoltuk + "','" + label14.Text + "','" + _szSeans + "','" + _szTarih + "')";
                        }
                        SqlCommand komut = new SqlCommand(szQuerrey, frmBiletSatir.baglanti);
                        komut.ExecuteNonQuery();
                        frmBiletSatir.baglanti.Close();

                        MessageBox.Show("Seçilen Koltuklar Satıldı.", "Sinema Otomasyonu");
                        Koltuk.ActiveForm.Hide();
                        BiletSatıs ac = new BiletSatıs();
                        ac.ShowDialog();

                    }
                }

                }
            }
      
        List<string> SatilanKoltuklar = new List<string>();
        private void Koltuk_Load(object sender, EventArgs e)
            {

                BiletSatıs frm = new BiletSatıs();
                frm.baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select*From KoltukTb Where FilmAdi=@fa And Seans=@se And Tarih=@ta", frm.baglanti);
                cmd.Parameters.AddWithValue("@fa", " ");
                cmd.Parameters.AddWithValue("@se", " ");
                cmd.Parameters.AddWithValue("@ta", " ");
                SqlDataReader okuyucu = cmd.ExecuteReader();
                while (okuyucu.Read())
                {
                    SatilanKoltuklar.Add(okuyucu["KoltukAdi"].ToString());
                }

                verileriAl(); 
        

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KoltukSecimi(btt3);
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            KoltukSecimi(btt2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button10);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button13);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button12);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button11);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button30);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button29);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button21);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button51);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button52);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button53);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button54);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button55);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button56);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button57);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button58);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button59);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button60);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button50);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button49);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button39);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button40);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button80);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button79);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button70);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            KoltukSecimi(button69);
        }

        private void Koltuk_Shown(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
            
            baglanti.Open();
            try {
                List<object> liststr = new List<object>();
                SqlDataAdapter adptr = new SqlDataAdapter("Select * From KoltukTb where FilmAdi = '" + _szFilmAdi + "' AND Seans = '" + _szSeans + "'AND Tarih = '" + _szTarih+ "'", baglanti);
                DataSet ds = new DataSet();
                adptr.Fill(ds, "KoltukAdi");
                foreach (DataRow drKoltuk in ds.Tables[0].Rows)
                {
                    liststr.Add(drKoltuk["KoltukAdi"].ToString());
                 }
                foreach (string szKoltuk in liststr)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is Button)
                        {
                            if (item.Tag != null && item.Tag.ToString().Contains("Koltuk"))
                            {
                                if (szKoltuk.Equals(item.Tag.ToString()))
                                {
                                    Control cnt = this.Controls[item.Name.ToString()];
                                     cnt.BackColor = Color.Green;
                                }
                            }
                        }
                    }
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int sonuc;
                sonuc = (Convert.ToInt32(label8.Text) * Convert.ToInt32(textBox1.Text)) + (Convert.ToInt32(label11.Text) * Convert.ToInt32(textBox3.Text));
                label14.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Satış.");
                Koltuk.ActiveForm.Hide();
                BiletSatıs ac = new BiletSatıs();
                ac.ShowDialog();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update BiletUcret set yetiskin=@yt,ogrenci=@og";
         
            SqlCommand komut = new SqlCommand(kayit, baglanti);
          
            komut.Parameters.AddWithValue("@yt", textBox1.Text);
            komut.Parameters.AddWithValue("@og", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
