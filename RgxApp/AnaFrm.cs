using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZemberekDotNet;
using ZemberekDotNet.Core.Turkish;
using ZemberekDotNet.Morphology;
using ZemberekDotNet.Tokenization;
using ZemberekDotNet.Morphology.Analysis;
using System.Data;
using System;
using ZemberekDotNet.Normalization;

namespace RgxApp
{
    public partial class AnaFrm : Form
    {
        private string dosyaYolu = ""; // Se�ilen dosyan�n yolu i�in bir de�i�ken

        public AnaFrm()
        {
            InitializeComponent();

        }

        private void dosyaEkleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyalar�|*.txt";

            if (!string.IsNullOrEmpty(dosyaYolu) && File.Exists(dosyaYolu))
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(dosyaYolu);
            }

            dosyaYolu = openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : dosyaYolu;
            dosyaAdiLbl.Text = openFileDialog.ShowDialog() == DialogResult.OK ? "Se�ilen Dosya: " + openFileDialog.SafeFileName : dosyaAdiLbl.Text;
        }

        private void rgxAraBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dosyaYolu) && File.Exists(dosyaYolu))
            {
                // Dosya i�eri�ini oku
                string dosyaIcerigi = File.ReadAllText(dosyaYolu);

                // RegEx ifadesini al ve dosya i�eri�inde arama yap
                string regexIfadesi = rgxAraTxtBx.Text;
                if (!string.IsNullOrEmpty(regexIfadesi))
                {
                    MatchCollection eslesmeler = Regex.Matches(dosyaIcerigi, regexIfadesi);

                    // Sonu�lar� yeni bir formda g�ster
                    RegexSonucFrm sonuclarForm = eslesmeler.Count > 0
                        ? new RegexSonucFrm()
                        : null;

                    sonuclarForm?.SonuclarListBox.Items.AddRange(eslesmeler
                        .Cast<Match>()
                        .Select(eslesme => eslesme.Value)
                        .ToArray());

                    sonuclarForm?.Show();
                }
                else
                {
                    MessageBox.Show("L�tfen bir RegEx ifadesi girin.");
                }
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir dosya se�in.");
            }
        }

        private void morfolojikAnalizBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dosyaYolu) && File.Exists(dosyaYolu))
            {

                string dosyaIcerigi = File.ReadAllText(dosyaYolu);
                string metinWithoutPunctuation = new string(dosyaIcerigi.Where(c => !char.IsPunctuation(c)).ToArray());
                MessageBox.Show("Noktalama ��aretleri Silinmi� Metin: " + metinWithoutPunctuation);

                File.WriteAllText(dosyaYolu, metinWithoutPunctuation);
                MessageBox.Show("Metin d�zenleme i�lemi tamamland� ve dosya g�ncellendi.");
                // Morfolojik analiz sonu�lar�n� yeni formda g�ster
                MorfolojikAnalizFrm morfolojiSonucForm = new MorfolojikAnalizFrm();
                MorfolojikAnalizYap(dosyaIcerigi, morfolojiSonucForm);
                morfolojiSonucForm.Show();
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir dosya se�in.");
            }

        }
        private void MorfolojikAnalizYap(string metin, MorfolojikAnalizFrm morfolojikAnalizFrm)
        {
            var morphology = TurkishMorphology.CreateWithDefaults();
            var oncekiEsisizKelimeSayisi = new HashSet<string>(metin.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)).Count;
            var tokenizedMetin = metin.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var sonraEsisizKelimeler = new HashSet<string>();

            foreach (var token in tokenizedMetin)
            {
                var analyses = morphology.Analyze(token);
                var enYayginKok = analyses
                    .Select(analysis => analysis.GetLemmas()[0])
                    .GroupBy(kok => kok)
                    .OrderByDescending(grp => grp.Count())
                    .Select(grp => grp.Key)
                    .FirstOrDefault();

                var pos = analyses.FirstOrDefault()?.GetPos(); 

              
                if (enYayginKok != null && pos != null)
                {
                    morfolojikAnalizFrm.MorfolojikAnalizSonuclariniGoster("Kelime: " + token + ", K�k: " + enYayginKok + ", POS: " + pos);
                    sonraEsisizKelimeler.Add(enYayginKok);
                }
            }
            var sonraEsisizKelimeSayisi = sonraEsisizKelimeler.Count;
            if (morfolojikAnalizFrm != null)
            {
                morfolojikAnalizFrm.SetEsisizKelimeSayilari(oncekiEsisizKelimeSayisi, sonraEsisizKelimeSayisi);
            }
        }





    }



}


