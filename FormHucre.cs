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
using System.Text.Json;

namespace BTE_202___2023_Grup_C_Uygulaması
{
    public partial class FormHucre : Form
    {

        public FormHucre()
        {
            InitializeComponent();
            string text = File.ReadAllText(@"./Assets/konular.json");
            var soru = JsonSerializer.Deserialize<konular>(text);
            Console.WriteLine($"Soru numarası: {konular.hucre_soru_seti[itemID]}");
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
            textSoru.Text = "Meraba";
        }


    }
}
