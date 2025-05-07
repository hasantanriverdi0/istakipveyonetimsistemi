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
    public partial class calisanekle : Form
    {
        public calisanekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Ad ve Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string calisanBilgisi = $"Ad: {ad}, Soyad: {soyad}";
            veri.calisanListesi.Add(calisanBilgisi);

            MessageBox.Show("Çalışan başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            calisan cls = new calisan();
            cls.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisan calisan = new calisan();
            calisan.Show();
            this.Hide();
        }
    }
}
