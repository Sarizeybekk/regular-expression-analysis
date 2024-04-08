using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZemberekDotNet.Morphology.Analysis;
using ZemberekDotNet.Morphology;

namespace RgxApp
{
    public partial class MorfolojikAnalizFrm : Form
    {
        public MorfolojikAnalizFrm()
        {
            InitializeComponent();


        }
        public void MorfolojikAnalizSonuclariniGoster(string analizSonuclari)
        {
            listBox1.Items.Add(analizSonuclari);
        }
        public void SetEsisizKelimeSayilari(int oncekiEsisizKelimeSayisi, int sonraEsisizKelimeSayisi)
        {
           oncekiKelimeSayisiLbl.Text = "Kök Öncesi Eşsiz Kelime Sayısı: " + oncekiEsisizKelimeSayisi.ToString();
            sonrakiKelimeSayisiLbl.Text = "Kök Sonrası Eşsiz Kelime Sayısı: " + sonraEsisizKelimeSayisi.ToString();
        }

    }




}
