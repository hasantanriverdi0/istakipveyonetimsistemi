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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            proje prj = new proje();
            prj.Show();
            this.Hide(); // anasayfa gizlensin
        }

        // panel2 - calisan.cs formuna gider
        private void panel2_Click(object sender, EventArgs e)
        {
            calisan cls = new calisan();
            cls.Show();
            this.Hide();
        }

        // panel4 - gorevata.cs formuna gider
        private void panel4_Click(object sender, EventArgs e)
        {
            görevata gta = new görevata();
            gta.Show();
            this.Hide();
        }

        // panel3 - gorevsil.cs formuna gider
        private void panel3_Click(object sender, EventArgs e)
        {
            görevsil gsl = new görevsil();
            gsl.Show();
            this.Hide();
        }
    }
}
