﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sonraki_Soru(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 30);
            string soruDosyasi = File.ReadAllText("./Assets/sorular.json");
            List<Sorular> sorular = JsonConvert.DeserializeObject<List<Sorular>>(soruDosyasi);
            //lblSoru.Text = soruDosyasi;
            textSoru.Text = sorular[rastgeleSayi].soru.ToString();
            List<string> cevapListesi = new List<string>()
            {
                sorular[rastgeleSayi].cevapDogru,
                sorular[rastgeleSayi].cevap1,
                sorular[rastgeleSayi].cevap2,
                sorular[rastgeleSayi].cevap3,
                sorular[rastgeleSayi].cevap4
            };
            cevapListesi.Karistir();
            //textCevap.Text = konular[rastgeleSayi].tanim.ToString();
        }

        private void onceki_Soru(object sender, EventArgs e)
        {

        }



        class Sorular
        {
            public int itemID { get; set; }
            public string soru { get; set; }
            public string cevapDogru { get; set; }
            public string cevap1 { get; set; }
            public string cevap2 { get; set; }
            public string cevap3 { get; set; }
            public string cevap4 { get; set; }
        }
    }
    static class Metodlar
    {
        private static Random soruKaristir = new Random();
        public static void Karistir<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = soruKaristir.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
