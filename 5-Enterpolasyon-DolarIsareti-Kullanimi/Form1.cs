using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Enterpolasyon_DolarIsareti_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int s1, s2, toplam;
            s1 = 4;
            s2 = 7;
            toplam = s1 + s2;
            // Başta kullanılan $ işareti sayesinde skop alanlarınıza {} veri tipi değişkenleri verebilirsiniz.
            string message = $"{s1} ile {s2} toplamı {toplam} sayısına eşittir.";

        }
    }
}
