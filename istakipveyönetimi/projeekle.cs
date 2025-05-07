using IsTakipSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace istakipveyönetimi
{
    public partial class projeekle : Form
    {
        public projeekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string mekan = textBox2.Text;
            string tarih = dateTimePicker1.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(mekan))
            {
                MessageBox.Show("Proje Adı ve Mekanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string projeBilgisi = $"Proje Adı: {ad}, Proje Mekanı: {mekan}, Proje Tarihi: {tarih}";
            veri.projeListesi.Add(projeBilgisi);

            MessageBox.Show("Proje başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Proje ekledikten sonra proje.cs sayfasına dönelim
            proje prj = new proje();
            prj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proje proje = new proje();
            proje.Show();
            this.Hide();
        }
    }
}
