using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormHucre : Form
    {
        public FormHucre()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 12);
            //string konuDosyasi = File.ReadAllText("../../../Assets/konular.json");
            string konuDosyasi = File.ReadAllText("./Assets/konular.json");
            List<Konular> konular = JsonConvert.DeserializeObject<List<Konular>>(konuDosyasi);
            textSoru.Text = konular[rastgeleSayi].cisim.ToString();
            textCevap.Text = konular[rastgeleSayi].tanim.ToString();
        }

        class Konular
        {
            public int itemID { get; set; }
            public string cisim { get; set; }
            public string tanim { get; set; }
        }
    }
}
