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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        marketEntities baglanti = new marketEntities();
        public void listele() //listeleme methodu
        {
            dataGridView1.DataSource = baglanti.elemanlistele().ToList();//listeleme prosedürünü sqlden çekme
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            elemanlar ekle = new elemanlar();
            ekle.elemanno = Convert.ToInt32(textBox1.Tag);
            ekle.elemanadi = textBox1.Text;
            ekle.elemanpozisyon = textBox2.Text;
            ekle.elemanmaas = Convert.ToDecimal(textBox3.Text);
            ekle.elemanstatu = textBox4.Text;
            ekle.gorevno = Convert.ToInt32(textBox5.Text);
            baglanti.elemanekle(ekle.elemanadi, ekle.elemanpozisyon, ekle.elemanmaas, ekle.elemanstatu,ekle.gorevno);
            baglanti.SaveChanges();
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["elemanno"].Value.ToString();
            textBox1.Text = satir.Cells["elemanadi"].Value.ToString();
            textBox2.Text = satir.Cells["elemanpozisyon"].Value.ToString();
            textBox3.Text = satir.Cells["elemanmaas"].Value.ToString();
            textBox4.Text = satir.Cells["elemanstatu"].Value.ToString();
            textBox5.Text = satir.Cells["gorevno"].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            elemanlar yenile = new elemanlar();
            yenile.elemanno = Convert.ToInt32(textBox1.Tag);
            yenile.elemanadi = textBox1.Text;
            yenile.elemanpozisyon = textBox2.Text;
            yenile.elemanmaas = Convert.ToDecimal(textBox3.Text);
            yenile.elemanstatu = textBox4.Text;
            yenile.gorevno = Convert.ToInt32(textBox5.Text);
            baglanti.elemanyenile(yenile.elemanno, yenile.elemanadi, yenile.elemanpozisyon, yenile.elemanmaas, yenile.elemanstatu,yenile.gorevno);
            baglanti.SaveChanges();
            listele();

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            //arama prosedürünü çekme
            elemanlar ara = new elemanlar();
            ara.elemanadi = textBox1.Text;
            var getir = baglanti.elemanara(ara.elemanadi);
            dataGridView1.DataSource = getir.ToList();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            elemanlar sil = new elemanlar();
            sil.elemanno = Convert.ToInt32(textBox1.Tag);
            baglanti.elemansil(sil.elemanno);
            baglanti.SaveChanges();
            listele();

        }

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            raporlar git = new raporlar();
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

        }
    }
}
