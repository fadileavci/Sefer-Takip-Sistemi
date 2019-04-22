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

        
		private void button1_Click(object sender, EventArgs e)
		{
       
           Rezarvasyon frm = new Rezarvasyon();
           
            frm.seferID =int.Parse(dataGridView1.SelectedRows[0].Cells["SeferID"].Value.ToString());
            frm.binisdurakid= int.Parse(cmbBinilenDurak.SelectedValue.ToString());
            frm.inisdurakid = int.Parse(cmbinilenDurak.SelectedValue.ToString());
            frm.Show();

            // buttonun kliğine yine 
            //int DurakID = int.Parse(cmbBinilenDurak.SelectedValue.ToString());
            //lstgüzergahlar.DataSource = DuraklarBLL.GuzergahIsimGetir(DurakID);
            //lstgüzergahlar.DisplayMember = "GuzergahAadi";

        }
	
		private void Form1_Load(object sender, EventArgs e)
		{
			// combobaxlara durak isimleri getirildi.
			cmbBinilenDurak.DisplayMember = "DurakAdi";
			cmbBinilenDurak.ValueMember = "DurakID";
			cmbBinilenDurak.DataSource = DuraklarBLL.TumDuraklarıGetir();
			//cmbinilenDurak.DisplayMember = "DurakAdi";
			//cmbinilenDurak.ValueMember = "DurakID";
			//cmbinilenDurak.DataSource = DuraklarBLL.TumDuraklarıGetir();

		


		}

		private void cmbBinilenDurak_SelectedIndexChanged(object sender, EventArgs e)
		{
			//listbox a güzergah isimleri getirildi
			int DurakID = int.Parse(cmbBinilenDurak.SelectedValue.ToString());
			lstgüzergahlar.DataSource = DuraklarBLL.GuzergahIsimGetir(DurakID);
			lstgüzergahlar.DisplayMember = "GuzergahAdi";
			lstgüzergahlar.ValueMember = "GuzergahID";


            cmbinilenDurak.DisplayMember = "DurakAdi";
            cmbinilenDurak.ValueMember = "DurakID";
            cmbinilenDurak.DataSource = DuraklarBLL.InilenDurakGetir(DurakID);



            //listBox1.DataSource = DuraklarBLL.GuzergahlarlariGtir(DurakID);
            //listBox1.DisplayMember = "GuzergahID";// listboxa ıd getirmek için kullanıldı


        }

		private void cmbinilenDurak_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lstgüzergahlar_SelectedIndexChanged(object sender, EventArgs e)
		{
            lstgüzergahlar.ValueMember = "GuzergahID";

            dataGridView1.DataSource = DuraklarBLL.SeferGetir(int.Parse(lstgüzergahlar.SelectedValue.ToString()));




          



        }
    }
}
