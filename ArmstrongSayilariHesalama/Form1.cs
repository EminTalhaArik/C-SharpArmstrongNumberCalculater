using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmstrongSayilariHesalama
{
    public partial class frm_armstrong : Form
    {
        public frm_armstrong()
        {
            InitializeComponent();
        }

        int basamakSayisi = 0;
        int sonToplam = 0;
        int sayi = 0;
        int baslangic = 0;
        int bitis = 0;

        private int BasamakHesapla(int sayi)
        {
            int sayac = 0;

            while (sayi > 0)
            {
                sayi = sayi / 10;
                sayac++;
            }
            return sayac;
        }

        private void SayidanHesapla()
        {
            if (tbx_sayi.Text != "")
            {
                try
                {
                    sayi = Convert.ToInt32(tbx_sayi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Tam Sayı Giriniz!");
                    return;
                }
                sonToplam = 0;
                basamakSayisi = BasamakHesapla(sayi);

                foreach (var item in sayi.ToString())
                {
                    sonToplam += Convert.ToInt32(Math.Pow(int.Parse(item.ToString()), basamakSayisi));
                }

                if (sonToplam == sayi)
                {
                    MessageBox.Show("Girdiğiniz sayı armstrong bir sayıdır! " + sayi);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sayı armstrong bir sayı değildir! " + sonToplam);
                }
            }
            tbx_baslangic.Text = "";
            tbx_bitis.Text = "";
            tbx_sayi.Text = "";
            lbx_sayilar.Items.Clear();
        }

        private void AraliktanHesapla()
        {
            basamakSayisi = 0;

            if (tbx_baslangic.Text != "" && tbx_bitis.Text != "")
            {
                try
                {
                    baslangic = Convert.ToInt32(tbx_baslangic.Text);
                    bitis = Convert.ToInt32(tbx_bitis.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Tam Sayı Giriniz!");
                    return;
                }

                for (int i = baslangic; i < bitis; i++)
                {
                    basamakSayisi = BasamakHesapla(i);
                    sonToplam = 0;

                    foreach (var item in i.ToString())
                    {
                        sonToplam += Convert.ToInt32(Math.Pow(int.Parse(item.ToString()), basamakSayisi));
                    }

                    if (sonToplam == i)
                    {
                        lbx_sayilar.Items.Add(i);
                    }
                    else
                    {
                        Console.WriteLine("Sayı Armstrong Bir Sayı Değildir! " + i + " " + sonToplam);
                    }
                }

                tbx_baslangic.Text = "";
                tbx_bitis.Text = "";
                tbx_sayi.Text = "";
                lbx_sayilar.Items.Clear();
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (rBtn_aralikBelirt.Checked)
            {
                AraliktanHesapla();
            }
            else
            {
                SayidanHesapla();
            }
        }

        private void rBtn_sayiGir_CheckedChanged(object sender, EventArgs e)
        {
            gbx_sayi.Enabled = true;
            btn_hesapla.Enabled = true;
            lbx_sayilar.Enabled = false;
            gbx_sayiaraligi.Enabled = false;
        }

        private void rBtn_aralikBelirt_CheckedChanged(object sender, EventArgs e)
        {
            gbx_sayiaraligi.Enabled = true;
            btn_hesapla.Enabled = true;
            lbx_sayilar.Enabled = true;
            gbx_sayi.Enabled = false;
        }
    }
}
