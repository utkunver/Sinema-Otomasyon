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
    public partial class FilmKaldır : Form
    {
        public FilmKaldır()
        {
            InitializeComponent();
        }
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
        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox2.Text.ToString();
        }

        private void FilmKaldır_Load(object sender, EventArgs e)
        {
            verilerigoruntuler();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show("Lütfen Silinecek Filmi Seçiniz.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        DialogResult secenek = MessageBox.Show("Seçilen Filmi Kaldırmak İstediğinizden Emin minisiniz ?", "Sinema Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (secenek == DialogResult.Yes)
                        {
                            baglan.Open();
                            string sql = "Delete  from FilmEkle where ad='" + comboBox2.Text.ToString() + "'";
                            SqlCommand cmd = new SqlCommand(sql, baglan);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Film Başarı İle Kaldırıldı.", "Sinema Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FilmKaldır.ActiveForm.Hide();
                            Bilet ac = new Bilet();
                            ac.ShowDialog();

                            baglan.Close();
                        }
                        else
                        {
                            FilmKaldır.ActiveForm.Hide();
                            Bilet ac = new Bilet();
                            ac.ShowDialog();
                        }
                    }
                }
            }
           
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FilmKaldır.ActiveForm.Hide();
            Bilet ac = new Bilet();
            ac.ShowDialog();
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void comboBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
