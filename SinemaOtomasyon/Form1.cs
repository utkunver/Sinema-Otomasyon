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
    public partial class Giris : Form
    {
       
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-M6TUNL8;Initial Catalog=Sinema;Integrated Security=True");

        private void Yenipersonel_Click(object sender, EventArgs e)
        {
            YeniUye yeniuye = new YeniUye();
            yeniuye.ShowDialog();

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtKullanıcıAdi.Text = Properties.Settings.Default.K_adi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                baglan.Open();
                string sql = "Select * from YeniUye where tc=@adi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("@adi", txtKullanıcıAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("@sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                Giris.ActiveForm.Hide();
                Bilet bilet = new Bilet();
                bilet.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı adı veya şifre girdiniz. Lütfen tekrar deneyiniz.","Sinema Otomasyonu");                

                }
                baglan.Close();
            this.Close();
             
         
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboxBenihatırla_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxBenihatırla.Checked)
            {
                Properties.Settings.Default.K_adi = txtKullanıcıAdi.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.K_adi = null;
                Properties.Settings.Default.Save();
            }
           

        }

        private void txtKullanıcıAdi_TextChanged(object sender, EventArgs e)
        {
            txtKullanıcıAdi.MaxLength = 11;
        }
    }
}
