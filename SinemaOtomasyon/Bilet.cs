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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Sinema Otomasyonu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {
                Bilet.ActiveForm.Hide();
                Bilet ac = new Bilet();
                ac.ShowDialog();
           
            }
            
        }

        private void blue(object sender, MouseEventArgs e)
        {

        }

        private void Bilet_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bilet.ActiveForm.Hide();
            FilmKaldır ac = new FilmKaldır();
            ac.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilet.ActiveForm.Hide();
            BiletSatıs ac = new BiletSatıs();
            ac.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bilet.ActiveForm.Hide();
            FilmEkle ac = new FilmEkle();
            ac.ShowDialog();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bilet.ActiveForm.Hide();
            ProgramKayıt ac = new ProgramKayıt();
            ac.ShowDialog();
           

        }

     
        
    }
}
