using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        MSDButton[,] butonlar;
        int satir, sutun, mayinSayisi;
        int puan = 0;
        int kalanBayrak = 0;
        Timer oyunZamanlayici;
        int gecenSure = 0;

        public Form1()
        {
            InitializeComponent();
            // Zamanlayıcıyı ayarla
            oyunZamanlayici = new Timer();
            oyunZamanlayici.Interval = 1000;
            oyunZamanlayici.Tick += OyunZamanlayici_Tick;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            string zorluk = cmbZorluk.Text;

            switch (zorluk)
            {
                case "Kolay": satir = 8; sutun = 8; mayinSayisi = 10; break;
                case "Orta": satir = 12; sutun = 12; mayinSayisi = 20; break;
                case "Zor": satir = 16; sutun = 16; mayinSayisi = 40; break;
                default:
                    MessageBox.Show("Lütfen bir zorluk seçiniz.");
                    return;
            }

            puan = 0;
            kalanBayrak = mayinSayisi;
            lblPuan.Text = "Puan: 0";
            lblBayrak.Text = $"Bayrak: 0 / {mayinSayisi}";
            lblSure.Text = "Süre: 0";
            gecenSure = 0;
            oyunZamanlayici.Start();

            OyunAlaniOlustur();
        }

        private void OyunAlaniOlustur()
        {
            panelOyun.Controls.Clear();
            butonlar = new MSDButton[satir, sutun];
            Random rnd = new Random();

            List<Point> mayinKonumlari = new List<Point>();
            while (mayinKonumlari.Count < mayinSayisi)
            {
                int x = rnd.Next(satir);
                int y = rnd.Next(sutun);
                Point p = new Point(x, y);
                if (!mayinKonumlari.Contains(p))
                    mayinKonumlari.Add(p);
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    MSDButton btn = new MSDButton();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.X = i;
                    btn.Y = j;
                    btn.Left = j * 30;
                    btn.Top = i * 30;
                    btn.Click += KareyeTiklandi;
                    btn.MouseUp += KareyeSagTik;
                    if (mayinKonumlari.Contains(new Point(i, j)))
                        btn.MayinMi = true;

                    panelOyun.Controls.Add(btn);
                    butonlar[i, j] = btn;
                }
            }

            panelOyun.Width = sutun * 30;
            panelOyun.Height = satir * 30;

                
            this.Width = panelOyun.Width + 40;
            this.Height = panelOyun.Height + panelUst.Height + 60;

        }

        private void KareyeTiklandi(object sender, EventArgs e)
        {
            MSDButton btn = sender as MSDButton;
            if (btn.MayinMi)
            {
                btn.BackColor = Color.Red;
                oyunZamanlayici.Stop();
                MessageBox.Show("Mayına bastın! Oyun bitti.");
                TumMayinlariGoster();
                panelOyun.Enabled = false;
                return;
            }

            int sayi = MayinSay(btn.X, btn.Y);
            if (sayi > 0)
                btn.Text = sayi.ToString();
            else
                btn.Enabled = false;

            btn.BackColor = Color.LightGray;
            btn.AcildiMi = true;
            btn.Enabled = false;

            puan++;
            lblPuan.Text = "Puan: " + puan;

            if (puan == (satir * sutun - mayinSayisi))
            {
                oyunZamanlayici.Stop();
                MessageBox.Show("Tebrikler! Oyunu kazandınız!");
                panelOyun.Enabled = false;
            }
        }

        private void KareyeSagTik(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MSDButton btn = sender as MSDButton;
                if (btn.Text == "")
                {
                    if (kalanBayrak > 0)
                    {
                        btn.Text = "⚑";
                        kalanBayrak--;
                    }
                }
                else if (btn.Text == "⚑")
                {
                    btn.Text = "";
                    kalanBayrak++;
                }

                lblBayrak.Text = $"Bayrak: {mayinSayisi - kalanBayrak} / {mayinSayisi}";
            }
        }

        private int MayinSay(int x, int y)
        {
            int say = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && j >= 0 && i < satir && j < sutun)
                    {
                        if (butonlar[i, j].MayinMi)
                            say++;
                    }
                }
            }
            return say;
        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void TumMayinlariGoster()
        {
            foreach (var btn in butonlar)
            {
                if (btn.MayinMi)
                    btn.Text = "*";
            }
        }

        private void OyunZamanlayici_Tick(object sender, EventArgs e)
        {
            gecenSure++;
            lblSure.Text = "Süre: " + gecenSure + " sn";
        }
    }
}
