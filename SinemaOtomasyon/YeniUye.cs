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
    public partial class YeniUye : Form
    {
        public YeniUye()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into YeniUye (ad,soyad,tc,email,sifre,telefon,yanıt,adres) values ('"+ad.Text.ToString() + "','" + soyad.Text.ToString() + "' , '" + tc.Text.ToString() + "' , '" + email.Text.ToString() + "' , '" + sifre.Text.ToString() + "' , '" + telefon.Text.ToString() + "' , '" + yanıt.Text.ToString() + "' , '" + adres.Text.ToString()+ "' )", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt İşlemi Tamamlandı. Giriş yapabilirsiniz.", "Sinema ");
            this.Hide();

        }

        private void YeniUye_Load(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            telefon.MaxLength = 11;
        }
    }
}
