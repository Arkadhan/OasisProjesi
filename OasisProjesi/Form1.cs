using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OasisProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbAd.Text = "";
            tbSoyad.Text = ""; 
            tbVize.Text = "";
            tbFinal.Text = "";

                
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                lbAd.Items.Add(tbAd.Text);
                lbSoyad.Items.Add(tbSoyad.Text);
                lbVize.Items.Add(tbVize.Text);
                lbFinal.Items.Add(tbFinal.Text);
                int vize = Convert.ToInt16(tbVize.Text);
                int final = Convert.ToInt16(tbFinal.Text);
                double ort = vize * 0.4 + final * 0.6;
                if (ort >= 60)
                    lbDurum.Items.Add("GEÇTİ");
                else
                    lbDurum.Items.Add("KALDI");

            }
            catch
            {

                MessageBox.Show("Girişlerden birisi yanlış", "Hata", MessageBoxButtons.OK);
            }
         }
    }
}
