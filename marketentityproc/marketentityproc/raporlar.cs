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
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
        }
        marketEntities baglanti=new marketEntities();
        private void btnraporlar_Click(object sender, EventArgs e)
        {
            /*Görevler tablosundan kasa sorumlusu olan elemanların adlarını desc sırala ve maaşlarını getiren prosedür*/
            dataGridView1.DataSource = baglanti.goreveleman().ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*Görevler tablosundan statüsü stajyer olan elemanları gorev durumuna göre desc sıralayan prosedür*/
            dataGridView1.DataSource = baglanti.goreveleman3().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Görevi kasa sorumlusu olan elemanların maaşları toplamını getiren prosedür*/
            dataGridView1.DataSource = baglanti.gorev1().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Görev süresi 8 saatten az olanları görev durumuna göre sıralayan prosedür*/
           dataGridView1.DataSource = baglanti.gorevsure().ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Maaşı 3500 den fazla olan elemanların görevlerini getiren prosedür*/
           dataGridView1.DataSource = baglanti.gorevmaas().ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Statüsü stajyer olanların maaş ortalamalarını getiren prosedür */
           dataGridView1.DataSource = baglanti.gorevstatü().ToList();
        }
    }
}
