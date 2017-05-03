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
    public partial class ProgramKayıt : Form
    {
        public ProgramKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
        public void veriEkle()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");
            baglan.Open();
            string kayit = "update BiletUcret set yetiskin=@yt,ogrenci=@og";
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@yt", textBox1.Text);
            komut.Parameters.AddWithValue("@og", textBox3.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ücret Yapılandırma İşlemi Tamamlandı.", "Sinema Otomasyonu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProgramKayıt.ActiveForm.Hide();
            Bilet ac = new Bilet();
            ac.ShowDialog();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Seans Giriniz.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        baglan.Open();
                        SqlCommand komut = new SqlCommand("insert into Seans(seans)values('" + textBox4.Text.ToString() + "')", baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        MessageBox.Show("Seans Başarı ile Eklendi.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Tarihi Giriniz.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        baglan.Open();
                        SqlCommand komut = new SqlCommand("insert into Tarih(Tarih)values('" + textBox5.Text.ToString() + "')", baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        MessageBox.Show("Tarih Başarı ile Eklendi.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
         
        }
    }
}
