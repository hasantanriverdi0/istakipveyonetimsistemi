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
    public partial class proje : Form
    {
        public proje()
        {
            InitializeComponent();
        }

        private void proje_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();
            foreach (string proje in veri.projeListesi)
            {
                listBox1.Items.Add(proje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projeekle prjEkle = new projeekle();
            prjEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Bir öğe seçildiyse
            {
                // Seçili projenin indeksini al
                int secilenIndex = listBox1.SelectedIndex;

                // Listeden kalıcı olarak sil
                veri.projeListesi.RemoveAt(secilenIndex);

                // Listeyi güncelle
                ListeyiGuncelle();

                MessageBox.Show("Proje başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir proje seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
