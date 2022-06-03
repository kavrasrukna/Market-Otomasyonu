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
    public partial class kullanicigirisi : Form
    {
        public kullanicigirisi()
        {
            InitializeComponent();
        }
        marketEntities baglanti = new marketEntities();
        public bool Girisyap(string ad, string sifre)
        {
            var sorgu = from p in baglanti.kullanicilars where p.kullaniciadi == ad && p.sifre == sifre select p;

            if (sorgu.Any())//var mı diye bakar varsa true yoksa false döndürür
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            if (Girisyap(txtgkullaniciadi.Text, txtgsifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre doğru,anasayfaya yönlendiriliyorsunuz...");
                this.Hide();
                anasayfa git = new anasayfa();
                git.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre hatalı!");
                txtgkullaniciadi.Clear();
                txtgsifre.Clear();
            }
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {

            if (kayitkullaniciadi.Text == "" || kayitsifre.Text == "" || txtmail.Text == "" || maskedtxttel.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
                MessageBox.Show("Üyeliğiniz oluşturuldu.Giriş yapınız.");

                // veri ekleme komutu
                kullanicilar kullanicilar = new kullanicilar();
                kullanicilar.kullaniciadi = kayitkullaniciadi.Text;
                kullanicilar.sifre = kayitsifre.Text;
                kullanicilar.mail = txtmail.Text;
                kullanicilar.telefon = maskedtxttel.Text;
                baglanti.kullanicilars.Add(kullanicilar);
                baglanti.SaveChanges();
                kayitkullaniciadi.Clear();
                kayitsifre.Clear();
                txtmail.Clear();
                maskedtxttel.Clear();

            }
        }
            private void checkBoxkayit_CheckedChanged(object sender, EventArgs e)
            {
                kayitol.Visible = true;

            }
        }
}