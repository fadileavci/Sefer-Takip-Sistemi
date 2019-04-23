using Seferi_BLL;
using Seferi_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seferi_UI
{
    public partial class Rezarvasyon : Form
    {
        public Rezarvasyon()
        {
            InitializeComponent();
        }
        public int rezervasyonid;
        public int seferID;
        public int inisdurakid;
        public int binisdurakid;
        public string adisoyadi;
        public string tcNo;
        public string aciklama;

        private void Rezarvasyon_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rzv = new Rezervasyonlar();
        
            rzv.SeferID = seferID;
            rzv.BinisDurakID = binisdurakid;
            rzv.InisDurakID = inisdurakid;
            rzv.MusteriAdiSoyadi = txtadi.Text+' '+txtSoyadi.Text;
            rzv.MusteriTCKN = txtTcNo.Text;
            rzv.Aciklama = txtAciklama.Text;
            DuraklarBLL.RezervasyonKaydet(rzv);
			MessageBox.Show("rezervasyonunuz alınmıştır");
        }
    }
}
