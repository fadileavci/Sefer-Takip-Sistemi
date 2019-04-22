namespace Seferi_UI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBinilenDurak = new System.Windows.Forms.ComboBox();
            this.cmbinilenDurak = new System.Windows.Forms.ComboBox();
            this.lstgüzergahlar = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Binilecek Durak ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İnilecek Durak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBinilenDurak
            // 
            this.cmbBinilenDurak.FormattingEnabled = true;
            this.cmbBinilenDurak.Location = new System.Drawing.Point(132, 44);
            this.cmbBinilenDurak.Name = "cmbBinilenDurak";
            this.cmbBinilenDurak.Size = new System.Drawing.Size(121, 21);
            this.cmbBinilenDurak.TabIndex = 5;
            this.cmbBinilenDurak.SelectedIndexChanged += new System.EventHandler(this.cmbBinilenDurak_SelectedIndexChanged);
            // 
            // cmbinilenDurak
            // 
            this.cmbinilenDurak.FormattingEnabled = true;
            this.cmbinilenDurak.Location = new System.Drawing.Point(132, 92);
            this.cmbinilenDurak.Name = "cmbinilenDurak";
            this.cmbinilenDurak.Size = new System.Drawing.Size(121, 21);
            this.cmbinilenDurak.TabIndex = 6;
            this.cmbinilenDurak.SelectedIndexChanged += new System.EventHandler(this.cmbinilenDurak_SelectedIndexChanged);
            // 
            // lstgüzergahlar
            // 
            this.lstgüzergahlar.FormattingEnabled = true;
            this.lstgüzergahlar.Location = new System.Drawing.Point(363, 35);
            this.lstgüzergahlar.Name = "lstgüzergahlar";
            this.lstgüzergahlar.Size = new System.Drawing.Size(212, 95);
            this.lstgüzergahlar.TabIndex = 7;
            this.lstgüzergahlar.SelectedIndexChanged += new System.EventHandler(this.lstgüzergahlar_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstgüzergahlar);
            this.Controls.Add(this.cmbinilenDurak);
            this.Controls.Add(this.cmbBinilenDurak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cmbBinilenDurak;
		private System.Windows.Forms.ComboBox cmbinilenDurak;
		private System.Windows.Forms.ListBox lstgüzergahlar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

