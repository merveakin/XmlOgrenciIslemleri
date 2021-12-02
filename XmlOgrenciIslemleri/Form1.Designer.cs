
namespace Ornek3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.lblSinifSec = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.pickerDTarihi = new System.Windows.Forms.DateTimePicker();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.ComboSinif = new System.Windows.Forms.ComboBox();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnEnSag = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnEnSol = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLİleDisariAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIleIceriVeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSecmeliDersler = new System.Windows.Forms.GroupBox();
            this.checkedlistSecmeliDers = new System.Windows.Forms.CheckedListBox();
            this.checkSecmeliDers = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSecmeliDersler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(70, 52);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(48, 90);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(36, 135);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(69, 20);
            this.lblDTarihi.TabIndex = 2;
            this.lblDTarihi.Text = "D. Tarihi :";
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(21, 250);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(315, 144);
            this.listBoxASinifi.TabIndex = 3;
            this.listBoxASinifi.Tag = "";
            this.listBoxASinifi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblSinifSec
            // 
            this.lblSinifSec.AutoSize = true;
            this.lblSinifSec.Location = new System.Drawing.Point(12, 181);
            this.lblSinifSec.Name = "lblSinifSec";
            this.lblSinifSec.Size = new System.Drawing.Size(93, 20);
            this.lblSinifSec.TabIndex = 4;
            this.lblSinifSec.Text = "Sınıf Seçimi :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(111, 83);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 27);
            this.txtAd.TabIndex = 0;
            // 
            // pickerDTarihi
            // 
            this.pickerDTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDTarihi.Location = new System.Drawing.Point(111, 128);
            this.pickerDTarihi.Name = "pickerDTarihi";
            this.pickerDTarihi.Size = new System.Drawing.Size(250, 27);
            this.pickerDTarihi.TabIndex = 3;
            this.pickerDTarihi.Value = new System.DateTime(2021, 12, 1, 11, 26, 6, 0);
            this.pickerDTarihi.ValueChanged += new System.EventHandler(this.pickerDTarihi_ValueChanged);
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(504, 250);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(346, 144);
            this.listBoxBSinifi.TabIndex = 8;
            // 
            // ComboSinif
            // 
            this.ComboSinif.FormattingEnabled = true;
            this.ComboSinif.Location = new System.Drawing.Point(111, 173);
            this.ComboSinif.Name = "ComboSinif";
            this.ComboSinif.Size = new System.Drawing.Size(250, 28);
            this.ComboSinif.TabIndex = 9;
            this.ComboSinif.Text = "Sınıfınızı Seçiniz...";
            this.ComboSinif.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(352, 250);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(131, 29);
            this.btnSag.TabIndex = 10;
            this.btnSag.Text = ">";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnEnSag
            // 
            this.btnEnSag.Location = new System.Drawing.Point(352, 285);
            this.btnEnSag.Name = "btnEnSag";
            this.btnEnSag.Size = new System.Drawing.Size(131, 29);
            this.btnEnSag.TabIndex = 11;
            this.btnEnSag.Text = ">>";
            this.btnEnSag.UseVisualStyleBackColor = true;
            this.btnEnSag.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(352, 326);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(131, 29);
            this.btnSol.TabIndex = 12;
            this.btnSol.Text = "<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnEnSol
            // 
            this.btnEnSol.Location = new System.Drawing.Point(352, 367);
            this.btnEnSol.Name = "btnEnSol";
            this.btnEnSol.Size = new System.Drawing.Size(131, 27);
            this.btnEnSol.TabIndex = 13;
            this.btnEnSol.Text = "<<";
            this.btnEnSol.UseVisualStyleBackColor = true;
            this.btnEnSol.Click += new System.EventHandler(this.btnEnSol_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(367, 45);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 156);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "ÖĞRENCİ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLİleDisariAktarToolStripMenuItem,
            this.XMLIleIceriVeriAlToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // XMLİleDisariAktarToolStripMenuItem
            // 
            this.XMLİleDisariAktarToolStripMenuItem.Name = "XMLİleDisariAktarToolStripMenuItem";
            this.XMLİleDisariAktarToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.XMLİleDisariAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            this.XMLİleDisariAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLİleDisariAktarToolStripMenuItem_Click);
            // 
            // XMLIleIceriVeriAlToolStripMenuItem
            // 
            this.XMLIleIceriVeriAlToolStripMenuItem.Name = "XMLIleIceriVeriAlToolStripMenuItem";
            this.XMLIleIceriVeriAlToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.XMLIleIceriVeriAlToolStripMenuItem.Text = "XML ile içeri veri al";
            this.XMLIleIceriVeriAlToolStripMenuItem.Click += new System.EventHandler(this.XMLIleIceriVeriAlToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // groupBoxSecmeliDersler
            // 
            this.groupBoxSecmeliDersler.Controls.Add(this.checkedlistSecmeliDers);
            this.groupBoxSecmeliDersler.Location = new System.Drawing.Point(488, 45);
            this.groupBoxSecmeliDersler.Name = "groupBoxSecmeliDersler";
            this.groupBoxSecmeliDersler.Size = new System.Drawing.Size(377, 156);
            this.groupBoxSecmeliDersler.TabIndex = 18;
            this.groupBoxSecmeliDersler.TabStop = false;
            this.groupBoxSecmeliDersler.Text = "Seçmeli Dersler";
            // 
            // checkedlistSecmeliDers
            // 
            this.checkedlistSecmeliDers.FormattingEnabled = true;
            this.checkedlistSecmeliDers.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmeti",
            "İtalyanca",
            "Halk Sağlığı",
            "Evrim Teorisi"});
            this.checkedlistSecmeliDers.Location = new System.Drawing.Point(16, 38);
            this.checkedlistSecmeliDers.Name = "checkedlistSecmeliDers";
            this.checkedlistSecmeliDers.Size = new System.Drawing.Size(346, 114);
            this.checkedlistSecmeliDers.TabIndex = 19;
            this.checkedlistSecmeliDers.SelectedIndexChanged += new System.EventHandler(this.checkedlistSecmeliDers_SelectedIndexChanged);
            // 
            // checkSecmeliDers
            // 
            this.checkSecmeliDers.AutoSize = true;
            this.checkSecmeliDers.Location = new System.Drawing.Point(51, 220);
            this.checkSecmeliDers.Name = "checkSecmeliDers";
            this.checkSecmeliDers.Size = new System.Drawing.Size(272, 24);
            this.checkSecmeliDers.TabIndex = 0;
            this.checkSecmeliDers.Text = "Seçmeli ders almak istiyor musunuz?";
            this.checkSecmeliDers.UseVisualStyleBackColor = true;
            this.checkSecmeliDers.CheckedChanged += new System.EventHandler(this.checkSecmeliDers_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 508);
            this.Controls.Add(this.groupBoxSecmeliDersler);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.checkSecmeliDers);
            this.Controls.Add(this.btnEnSol);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnEnSag);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.ComboSinif);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.pickerDTarihi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSinifSec);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSecmeliDersler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.Label lblSinifSec;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker pickerDTarihi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.ComboBox ComboSinif;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnEnSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnEnSol;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDersler;
        private System.Windows.Forms.CheckBox checkSecmeliDers;
        private System.Windows.Forms.CheckedListBox checkedlistSecmeliDers;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLİleDisariAktarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem XMLIleIceriVeriAlToolStripMenuItem;
    }
}

