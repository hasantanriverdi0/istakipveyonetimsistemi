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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false; // Şifre görünür
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;  // Şifre gizli
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Admin adı ve şifre kontrolü
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide(); // Giriş formunu gizle
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
