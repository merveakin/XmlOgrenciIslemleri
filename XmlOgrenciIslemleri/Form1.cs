using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ornek3
{
    public partial class Form1 : Form
    {

        //Global Alan
        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();

        public Form1()
        {
            InitializeComponent();
            //istersen addrange ile de ekleyebilirsiniz. 
            //Addrange içeriye dizi yanş array istiyor
            // bu nedenle listenizi toarray ile diziye çevirmelisşn.



            // ComboSinif.Items.AddRange(SiniflarListesi.ToArray());

            foreach (var item in SiniflarListesi)
            {
                ComboSinif.Items.Add(item);
            }
            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            pickerDTarihi.TabIndex = 2;
            ComboSinif.TabIndex = 3;
            btnEkle.TabIndex = 4;
            listBoxASinifi.TabIndex = 5;

            groupBoxSecmeliDersler.Enabled = false;

            //ChechkOnClick tıkladığım an listedeki checkbox'ı tiklesin.
            checkedlistSecmeliDers.CheckOnClick = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //A sınıfındaki herkesi B ye gönderecek
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinifi = "B Sınıfı";
            }
            BSinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();

        }

        private void pickerDTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Öğrenci ekleyeceğiz.

            //string.IsNullOrEmpty--> Hazır bir string metottur.
            //içine verilen value nun null ya da boş olup olmadığına bakar.


            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = pickerDTarihi.Value

                };
                //combobox ta seçtiği değer
                //if (ComboSinif.SelectedIndex=-1)
                //{
                //    MessageBox.Show("Lütfen sınıf seçiniz!");
                //}
                //else
                //{
                //    //işlemler

                //}

                if (ASinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci A sınıfına zaten kayıt olmuş!");
                }
                else if (BSinifindaAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci B sınıfına zaten kayıt olmuş!");
                }
                else if (ComboSinif.SelectedIndex >= 0)
                {
                    //işlemler
                    ogr1.Sinifi = ComboSinif.SelectedItem.ToString();
                    //Artık öğrenciyi listeye eklemelyiz..
                    switch (ComboSinif.SelectedIndex)
                    {
                        case 0:         //A SINIFI
                            if (ASinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                ASinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci Sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case 1:         //B SINIFI
                            if (BSinifindaAyniOgrencidenVarMi(ogr1) == false)
                            {
                                BSinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci Sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        default:

                            break;
                    }

                    //Ogrenci seçmeli ders alıyorsa listesine dersleri eklensin.
                    ogr1.SecmeliDersAliyorMu = checkSecmeliDers.Checked;

                    //alıyorsa -se -sa eki koşul bildirir. C# ta koşul deyince if aklımıza gelir.

                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }

                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz");
                }
            }

        }

        private bool ASinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        private bool BSinifindaAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        private void KontrolleriTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = string.Empty;
            ComboSinif.SelectedIndex = -1;
            ComboSinif.Text = "Sınıfızı Seçiniz..";
            pickerDTarihi.Value = DateTime.Now;
            //checkedlist içinde checklenmiş(yani tik atılmış) olan derslere unchecked yapmalıyız.
            foreach (int indeksi in checkedlistSecmeliDers.CheckedIndices)
            {
                checkedlistSecmeliDers.SetItemCheckState(indeksi, CheckState.Unchecked);
            }
            //Checked olan dersleri tuttuğumuz listeyi temizlemeliyiz.
            SecilenSecmeliDersler.Clear();
            //checkSecmeiDers unchecked olsun
            checkSecmeliDers.Checked = false;
        }

        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.AliceBlue;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());

            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.Azure;
            listBoxBSinifi.Items.AddRange(BSinifiOgrencileri.ToArray());

        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            //seçili olanı sağa gönder
            //kim seçili old.nu ListBox'ın SelectedItem özelliği ile alıyoruz.
            //Bu nedenle gelen object tipinde değer gönderiyor.
            //Cast etme 1. yol

            Ogrenci transferEdilecekOgr = listBoxASinifi.SelectedItem as Ogrenci;

            //cast etme 2. yol

            //ya da -->   // Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "B Sınıfı";
                BSinifiOgrencileri.Add(transferEdilecekOgr);
                ListeleriDoldur();
            }

        }

        private void checkSecmeliDers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSecmeliDers.Checked)
            {
                groupBoxSecmeliDersler.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDersler.Enabled = false;
            }
        }

        private void checkedlistSecmeliDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checkedlistbox ın checkeditems property si bize bir koleksiyon veriyor.

            SecilenSecmeliDersler.Clear();

            foreach (var item in checkedlistSecmeliDers.CheckedItems)
            {
                //Eğer SeçilenSeçmeliDers listesinde bu ders varsa bir daha eklememesi için koşul yazalım.
                //CheckedItems 'ın foreach dçngüsündeki var item ile bize sunduğu değişken object tipte geliyor.
                //SeçilenSecmeliDers listemiz string tipte bir listedir.

                if (SecilenSecmeliDersler.Count(x => x == item.ToString()) == 0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }
            }
        }

        private void XMLİleDisariAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktailacaklar = new List<Ogrenci>();
            //A sınıfında öğrenci varsa
            if (ASinifiOgrencileri.Count > 0)
            {
                DisariAktailacaklar.AddRange(ASinifiOgrencileri);
            }
            //B sınıfında öğrenci varsa 
            if (BSinifiOgrencileri.Count > 0)
            {
                DisariAktailacaklar.AddRange(BSinifiOgrencileri);
            }
            //OLuşacak xml dosyasını nereye kaydedeceği ile ilgili 
            //DİYALOG nesnesine ihtiyaç var.

            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //açılan diyalog penceresinde tamam/OK tuşuna basarsan xml dosyasını oluşturabiliriz.

                //xml i seriliaze edecek işlemler
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Ogrenci>));

                //Bu yazımda C#’ta using bloğundan bahsedeceğim.
                //IDisposable interface inden türemiş nesneler using(){} bloğu içinde oluşturulursa,
                //using bloğundan çıkılır çıkılmaz GC(Garbage Collector)’ye devredilir
                //ve hemen silinirler(Dispose edilirler).Çünkü IDisposable’den türemiş classlarda %100 Dispose metodu vardır.
                //using bloğuda aslında blok sonunda bu metodu çalıştırmaktadır.Bu sayede manuel olarak nesneyi Dispose etmemize gerek kalmaz
                using (TextWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerializer.Serialize(yazar, DisariAktailacaklar);
                }
                MessageBox.Show($"{DisariAktailacaklar.Count} adet öğrenci xml dosyası olarak aktarıldı.");
            }

        }

        private void XMLIleIceriVeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bilgisayarda olan xml dosyasını açmamıza yardımcı olacak DİYALOG dosyasına ihtiyaç var.
            KontrolleriTemizle();
            openFileDialog1.Title = "XML Dosyanızı Seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSeriliazer = new XmlSerializer(typeof(List<Ogrenci>));
                //Var olan dosyayı okumak için okuyucuya ihtiyaç vardır.
                using (StreamReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {

                    //ASinifiOgrencileri = myXMLSeriliazer.Deserialize(okuyucu) as List<Ogrenci>;

                    //kısa yol
                    ASinifiOgrencileri = (List<Ogrenci>)
                    myXMLSeriliazer.Deserialize(okuyucu);
                    MessageBox.Show($"{ASinifiOgrencileri.Count} adet kişi içeri aktarıldı.");
                    ListeleriDoldur();

                }
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgrenci = (Ogrenci)listBoxBSinifi.SelectedItem;

            if (transferEdilecekOgrenci != null)
            {
                BSinifiOgrencileri.Remove(transferEdilecekOgrenci);
                transferEdilecekOgrenci.Sinifi = "A Sınıfı";
                ASinifiOgrencileri.Add(transferEdilecekOgrenci);
                ListeleriDoldur();
            }
        }

        private void btnEnSol_Click(object sender, EventArgs e)
        {
            foreach (var item in BSinifiOgrencileri)
            {
                item.Sinifi = "A Sınıfı";
            }
            ASinifiOgrencileri.AddRange(BSinifiOgrencileri.ToArray());
            BSinifiOgrencileri.Clear();
            ListeleriDoldur();
        }
    }


}
