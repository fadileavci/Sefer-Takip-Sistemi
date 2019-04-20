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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Duraklar drk = new Duraklar();

		private void button1_Click(object sender, EventArgs e)
		{
			drk.DurakAdi = txtDurakAdi.Text;
			drk.Aciklama = txtAciklama.Text;
			DuraklarBLL.DurakEkle(drk);
			MessageBox.Show("durak eklendi");
			
			
		}
	}
}
