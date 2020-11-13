/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Hilal YILDIZ 
**				ÖĞRENCİ NUMARASI.......: B171210019
**              DERSİN ALINDIĞI GRUP...: 2A
****************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NesneyeDayaliProgramlama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Kullanilan degiskenler
        string[] kelimeler;
        string[] satirlar;
        string tc;
        double TC;
        string isim;
        string soyisim;
        byte yas;
        byte calismasuresi;
        char evlilikdurumu;
        char escalismadururmu;
        byte cocuksayisi;
        double tabanmaas;
        double makamtazminati;
        double idarigorevtazminati;
        int fazlamesaisaati;
        double fazlamesaisaatiucreti;
        double vergimatrahi;
        string personelresmiyolu;
        double burutmaas;
        double damgavergisi;
        double gelirvergisi;
        double emeklikesintisi;
        double netmaas;
        double kesinti;

        // .txt dosyasinin okunmasi icin nesne olusturma
        OpenFileDialog file = new OpenFileDialog();
        // dosya okuma butonu 
        private void buttondosyaokuma_Click(object sender, EventArgs e)
        {
            //richtextboxi temizleyerek dosyayi okur ve richtextboxa yazar
            richTextBox1.Clear();
            StreamReader dosya = File.OpenText("kayitlar.txt");
            string s = dosya.ReadLine();
            while (s != null)
            {
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText(s);
                s = dosya.ReadLine();
            }
            dosya.Close();
        }

        // Tc verisini sorgulayarak maasi hesaplayan buton
        private void buttontcsorgulama_Click(object sender, EventArgs e)
        {
            // richtextboxa yazilan .txt dosyasini bir stringe kopyalar
            string hepsi = richTextBox1.Text;
            //kopyalanan metni satirlara parcalar
            satirlar = hepsi.Split('\n');

            //Satirlar icinde dolanarak textboxtaki girilen stringi arar
            for (int i = 0; i < satirlar.Length; i++)
            {

                if (satirlar[i].Length - i >= textBox1.Text.Length)
                {
                    // satirin basindan baslayarak textboxtaki girilen string uzunlugundaki veriyi tc degiskenine atar
                    tc = satirlar[i].Substring(0, textBox1.Text.Length);
                    {
                        // eger aranan stringi karsilastirir
                        if (tc == textBox1.Text)
                        {
                            //eger aranan string bulunmussa satiri kelimelere boler
                            richTextBox2.Text = satirlar[i] + "\n";
                            // ekrana yazdirma islemi yapilir
                            kelimeler = satirlar[i].Split(' ');
                            //gerekli tip donusumleri yapilir
                            TC = Convert.ToDouble(kelimeler[0]);
                            isim = Convert.ToString(kelimeler[1]);
                            soyisim = Convert.ToString(kelimeler[2]);
                            yas = Convert.ToByte(kelimeler[3]);
                            calismasuresi = Convert.ToByte(kelimeler[4]);
                            evlilikdurumu = Convert.ToChar(kelimeler[5]);
                            escalismadururmu = Convert.ToChar(kelimeler[6]);
                            cocuksayisi = Convert.ToByte(kelimeler[7]);
                            tabanmaas = Convert.ToDouble(kelimeler[8]);
                            makamtazminati = Convert.ToDouble(kelimeler[9]);
                            idarigorevtazminati = Convert.ToDouble(kelimeler[10]);
                            fazlamesaisaati = Convert.ToInt32(kelimeler[11]);
                            fazlamesaisaatiucreti = Convert.ToDouble(kelimeler[12]);
                            vergimatrahi = Convert.ToDouble(kelimeler[13]);
                            personelresmiyolu = Convert.ToString(kelimeler[14]);

                            // Calisanin evlilik durumu ve esinin calisma durumu goze alinarak burut maas hesaplanir
                            if (evlilikdurumu == 'B')
                            {
                                burutmaas = tabanmaas + makamtazminati + idarigorevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiucreti);
                            }
                            else if(evlilikdurumu=='E' && escalismadururmu == 'E')
                            {
                                burutmaas = tabanmaas + makamtazminati + idarigorevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiucreti);
                            }
                            else if(evlilikdurumu=='E' && escalismadururmu == 'H')
                            {
                                burutmaas = tabanmaas + makamtazminati + idarigorevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiucreti)+200;
                            }
                            // damga vergisi hesaplanir
                            damgavergisi = (burutmaas * 10) / 100;
                            // gelir vergisi hesaplanir
                            if (vergimatrahi < 10000)
                            {
                                gelirvergisi = (burutmaas * 15) / 100;
                            }
                           else  if(vergimatrahi>=10000 || vergimatrahi < 20000)
                            {
                                gelirvergisi = (burutmaas * 20) / 100;
                            }
                            else if(vergimatrahi >= 20000 || vergimatrahi < 30000)
                            {
                                gelirvergisi = (burutmaas * 25) / 100;
                            }
                            else
                            {
                                gelirvergisi = (burutmaas * 30) / 100;
                            }
                            // emekli kesintisi hesaplanir
                            emeklikesintisi = (burutmaas * 15) / 100;
                            // burut maastan dusulecek kesinti hesaplanir
                            kesinti=gelirvergisi + emeklikesintisi + damgavergisi;
                            //net maas hesaplanir
                            netmaas = burutmaas - kesinti;
                            // Ekrana yazdirma islemi yapilir
                            richTextBoxmaas.Text = "Net maaş " + kesinti.ToString() + " TL";
                            
                        }
                    }
                }
                }
        }

        private void richTextBoxmaas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
