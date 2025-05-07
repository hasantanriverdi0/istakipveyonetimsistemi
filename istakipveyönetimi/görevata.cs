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
    public partial class görevata : Form
    {
        public görevata()
        {
            InitializeComponent();
        }

        private void görevata_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string proje in veri.projeListesi)
            {
                listBox1.Items.Add(proje);
            }

            // Çalışanları listBox2'ye yükle
            listBox2.Items.Clear();
            foreach (string calisan in veri.calisanListesi)
            {
                listBox2.Items.Add(calisan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                string secilenProje = listBox1.SelectedItem.ToString();
                string secilenCalisan = listBox2.SelectedItem.ToString();

                string gorev = $"Proje: {secilenProje} => Çalışan: {secilenCalisan}";

                DialogResult sonuc = MessageBox.Show($"{gorev}\n\nBu görevi atamak istiyor musunuz?", "Görev Atama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    veri.gorevListesi.Add(gorev);
                    MessageBox.Show("Görev başarıyla atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen hem proje hem de çalışan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
