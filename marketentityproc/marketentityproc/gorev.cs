using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketentityproc
{
    public partial class gorev : Form
    {
        public gorev()
        {
            InitializeComponent();
        }
        marketEntities baglanti=new marketEntities();
        public void listele() //listeleme methodu
        {
            dataGridView1.DataSource = baglanti.gorevlistele().ToList();//listeleme prosedürünü sqlden çekme
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["gorevno"].Value.ToString();
            textBox1.Text = satir.Cells["gorevadi"].Value.ToString();
            textBox2.Text = satir.Cells["gorevtanimi"].Value.ToString();
            textBox3.Text = satir.Cells["gorevfiyat"].Value.ToString();
            textBox4.Text = satir.Cells["gorevsuresi"].Value.ToString();
            textBox5.Text = satir.Cells["gorevdurum"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            gorevler ekle = new gorevler();
            ekle.gorevno = Convert.ToInt32(textBox1.Tag);
            ekle.gorevadi = textBox1.Text;
            ekle.gorevtanimi = textBox2.Text;
            ekle.gorevfiyat = Convert.ToDecimal(textBox3.Text);
            ekle.gorevsuresi = textBox4.Text;
            ekle.gorevdurum = textBox5.Text;
            baglanti.gorevekle(ekle.gorevadi, ekle.gorevtanimi, ekle.gorevfiyat, ekle.gorevsuresi, ekle.gorevdurum);
            baglanti.SaveChanges();
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            gorevler yenile = new gorevler();
            yenile.gorevno = Convert.ToInt32(textBox1.Tag);
            yenile.gorevadi = textBox1.Text;
            yenile.gorevtanimi = textBox2.Text;
            yenile.gorevfiyat = Convert.ToDecimal(textBox3.Text);
            yenile.gorevsuresi = textBox4.Text;
            yenile.gorevdurum = textBox5.Text;
            baglanti.gorevyenile(yenile.gorevno, yenile.gorevadi, yenile.gorevtanimi, yenile.gorevfiyat, yenile.gorevsuresi, yenile.gorevdurum);
            baglanti.SaveChanges();
            listele();
        }

        private void btnara_Click(object sender, EventArgs e)
        {

            //arama prosedürünü çekme
            gorevler ara = new gorevler();
            ara.gorevadi = textBox1.Text;
            var getir = baglanti.gorevara(ara.gorevadi);
            dataGridView1.DataSource = getir.ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            gorevler sil = new gorevler();
            sil.gorevno = Convert.ToInt32(textBox1.Tag);
            baglanti.gorevsil(sil.gorevno);
            baglanti.SaveChanges();
            listele();
        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git=new raporlar();
            git.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa git = new anasayfa();
            git.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
