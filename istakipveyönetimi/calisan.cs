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
    public partial class calisan : Form
    {
        public calisan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanekle clsEkle = new calisanekle();
            clsEkle.Show();
            this.Hide();
        }
        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();
            foreach (string calisan in veri.calisanListesi)
            {
                listBox1.Items.Add(calisan);
            }
        }

        private void calisan_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           anasayfa anasayfa = new anasayfa();
           anasayfa.Show();
           this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Bir çalışan seçildiyse
            {
                int secilenIndex = listBox1.SelectedIndex;

                // Seçilen çalışanı veri.calisanListesi listesinden kalıcı olarak sil
                veri.calisanListesi.RemoveAt(secilenIndex);

                // Listeyi güncelle
                ListeyiGuncelle();

                MessageBox.Show("Çalışan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
