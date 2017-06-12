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
namespace SinemaOtomasyon
{
    public partial class BiletSatıs : Form
    {
        string _szFilmAdi = "";
        string _szSeans = "";
        string _szTarih = "";

        public BiletSatıs()
        {
            InitializeComponent();
           
        }
      
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
      

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
        public void verilerigoruntuler()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from FilmEkle ", baglan);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ad"]);


            }
            baglan.Close();

        }
        public void FilmDetay()
        {
            if (comboBox2.SelectedItem == null) {
                MessageBox.Show("LÜtfen Film Seçiniz.", "Uyarı", MessageBoxButtons.OK);
            } else {
                baglan.Open();
                string con = "SELECT * FROM FilmEkle WHERE ad=@fa";
                SqlCommand cmd = new SqlCommand(con, baglan);
                string film = comboBox2.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@fa", film);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        textBox1.Text = dr["ad"].ToString();
                        textBox2.Text = dr["yapım"].ToString();
                        textBox3.Text = dr["yonetmen"].ToString();
                        textBox4.Text = dr["oyuncu"].ToString();
                        textBox5.Text = dr["tur"].ToString();
                        textBox6.Text = dr["sure"].ToString();
                    }
                }
                baglan.Close();
            }
        }
        private void verilerSeans()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Seans ", baglan);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["seans"]);

            }
            baglan.Close();
        }
        private void verilerTarih()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Tarih ", baglan);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["Tarih"]);

            }
            baglan.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BiletSatıs.ActiveForm.Hide();
            Bilet ac = new Bilet();
            ac.ShowDialog();
        }

        private void BiletSatıs_Load(object sender, EventArgs e)
        {

            verilerigoruntuler();
            verilerTarih();
            verilerSeans();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _szFilmAdi = comboBox2.Text.ToString();
            _szSeans = comboBox1.Text.ToString();
            _szTarih = comboBox3.Text.ToString();
            BiletSatıs.ActiveForm.Hide();
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Silinecek Filmi Seçiniz.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BiletSatıs ac = new BiletSatıs();
                        ac.ShowDialog();
                        break;
                        
                    }
                    else
                    {
                        Koltuk ac = new Koltuk(_szFilmAdi, _szSeans, _szTarih);
                        ac.ShowDialog();
                    }
                }

            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilmDetay();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
