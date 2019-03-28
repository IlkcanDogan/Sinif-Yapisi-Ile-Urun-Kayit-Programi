using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDenemeUygulama
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

        Urun urun = new Urun();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            urun.Adet = Convert.ToInt32(txtAdet.Text);
            urun.Fiyat = Convert.ToInt32(txtFiyat.Text);
            urun.Marka = String.Format(txtMarka.Text);
            urun.TETT = DateTime.Parse(Ptett.Text);
           

            
            string[] kolon = {urun.Marka, cmbUrun.SelectedItem.ToString(), urun.Fiyat.ToString(),
                             urun.TETT.ToString(),urun.Adet.ToString(), urun.EklemeSaati.ToString()};
            var satir = new ListViewItem(kolon);

            LV.Items.Add(satir);

             
           
        }
    }
}
