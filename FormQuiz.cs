using System;
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
        public Stack<int> soruGecmisi = new Stack<int>();
        string soruDosyasi = File.ReadAllText("./Assets/sorular.json");
        public FormQuiz()
        {
            InitializeComponent();
            soruGecmisi.Clear();
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
            //string soruDosyasi = File.ReadAllText("./Assets/sorular.json");
            List<Sorular> sorular = JsonConvert.DeserializeObject<List<Sorular>>(soruDosyasi);
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
            lblCvp1.Text = cevapListesi[0];
            lblCvp2.Text = cevapListesi[1];
            lblCvp3.Text = cevapListesi[2];
            lblCvp4.Text = cevapListesi[3];
            lblCvp5.Text = cevapListesi[4];
            soruGecmisi.Push(rastgeleSayi);
            labelCevap.Text = "";
        }

        private void onceki_Soru(object sender, EventArgs e)
        {
            int sonSoru = soruGecmisi.FirstOrDefault();
            bool isEmpty = !soruGecmisi.Any();
            if (isEmpty)
            {
                Console.WriteLine("Hata!");
                return;
            }
            else
            {
                soruGecmisi.Pop();
                sonSoru = soruGecmisi.FirstOrDefault();
                List<Sorular> sorular = JsonConvert.DeserializeObject<List<Sorular>>(soruDosyasi);
                textSoru.Text = sorular[sonSoru].soru.ToString();
                List<string> cevapListesi = new List<string>()
                {
                    sorular[sonSoru].cevapDogru,
                    sorular[sonSoru].cevap1,
                    sorular[sonSoru].cevap2,
                    sorular[sonSoru].cevap3,
                    sorular[sonSoru].cevap4
                };
                cevapListesi.Karistir();
                lblCvp1.Text = cevapListesi[0];
                lblCvp2.Text = cevapListesi[1];
                lblCvp3.Text = cevapListesi[2];
                lblCvp4.Text = cevapListesi[3];
                lblCvp5.Text = cevapListesi[4];
                labelCevap.Text = "";
            }
        }

        private void btnKontrol(object sender, EventArgs e)
        {
            int sonSoru = soruGecmisi.FirstOrDefault();
            List<Sorular> sorular = JsonConvert.DeserializeObject<List<Sorular>>(soruDosyasi);
            if (lblCvp1.Checked)
            {
                if (lblCvp1.Text == sorular[sonSoru].cevapDogru) labelCevap.Text = "Doğru Cevap";
                else labelCevap.Text = "Yanlış Cevap";
            }
            else if (lblCvp2.Checked)
            {
                if (lblCvp2.Text == sorular[sonSoru].cevapDogru) labelCevap.Text = "Doğru Cevap";
                else labelCevap.Text = "Yanlış Cevap";
            }
            else if (lblCvp3.Checked)
            {
                if (lblCvp3.Text == sorular[sonSoru].cevapDogru) labelCevap.Text = "Doğru Cevap";
                else labelCevap.Text = "Yanlış Cevap";
            }
            else if (lblCvp4.Checked)
            {
                if (lblCvp4.Text == sorular[sonSoru].cevapDogru) labelCevap.Text = "Doğru Cevap";
                else labelCevap.Text = "Yanlış Cevap";
            }
            else if (lblCvp5.Checked)
            {
                if (lblCvp5.Text == sorular[sonSoru].cevapDogru) labelCevap.Text = "Doğru Cevap";
                else labelCevap.Text = "Yanlış Cevap";
            }
            else
            {
                labelCevap.Text = "Boş Cevap";
            }
            //labelCevap.Text += "\r\n" + sorular[sonSoru].cevapDogru;
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
