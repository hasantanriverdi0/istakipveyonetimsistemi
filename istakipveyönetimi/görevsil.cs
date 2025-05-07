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
    public partial class görevsil : Form
    {
        public görevsil()
        {
            InitializeComponent();
        }

        private void gorevsil_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
        private void ListeyiGuncelle()
        {
            listBox1.Items.Clear();
            foreach (string gorev in veri.gorevListesi)
            {
                listBox1.Items.Add(gorev);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void görevsil_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Bir görev seçildiyse
            {
                DialogResult sonuc = MessageBox.Show("Seçilen görevi silmek istediğinize emin misiniz?", "Görev Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    int secilenIndex = listBox1.SelectedIndex;

                    // Seçilen görevi veri.gorevListesi listesinden kalıcı olarak sil
                    veri.gorevListesi.RemoveAt(secilenIndex);

                    // Listeyi güncelle
                    ListeyiGuncelle();

                    MessageBox.Show("Görev başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
