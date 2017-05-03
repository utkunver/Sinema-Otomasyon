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
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");

        private void FilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmEkle.ActiveForm.Hide();
            Bilet ac = new Bilet();
            ac.ShowDialog();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
               foreach (Control item in this.Controls)
           {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Film İsmini Giriniz.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        baglan.Open();
                        SqlCommand komut = new SqlCommand("insert into FilmEkle (ad,yapım,yonetmen,oyuncu,tur,sure) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "' )", baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        MessageBox.Show("Kayıt İşlemi Tamamlandı.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        Bilet ac = new Bilet();
                        ac.ShowDialog();
                     
                    }
                }
            }
            FilmEkle.ActiveForm.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
