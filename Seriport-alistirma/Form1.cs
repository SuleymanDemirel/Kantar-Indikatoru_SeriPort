using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using FastReport;
using System.Data.SqlClient;
using System.Configuration;

namespace Seriport_alistirma
{

    public partial class Form1 : Form
    {
       public static BaglantiSinif baglantiadres = new BaglantiSinif();
       SqlConnection baglanti = new SqlConnection(baglantiadres.Adres);


        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
   
        DataTable tablo = new DataTable(); // ürün liste
        DataTable tablo2 = new DataTable(); // firma liste

       
        void VeriListele() // Ürünleri listeleme
        {
            
         
            tablo.Clear();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM EtiketBilgiler Order by ID desc", baglanti);
            da.Fill(tablo);
            dgwTablo.DataSource = tablo;
            baglanti.Close();
            dgwTablo.AllowUserToAddRows = false;
        }

        void FirmaListele() // Firma listeleme
        {
            tablo2.Clear();
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Firmalar", baglanti);
            da.Fill(tablo2);
            dgwFirmalar.DataSource = tablo2;
            baglanti.Close();
            dgwFirmalar.AllowUserToAddRows = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            VeriListele();
            FirmaListele();
           
            if (!sp.IsOpen)
            {
                try
                {
                    string[] lines = File.ReadAllLines("Config.txt");
                    if (lines.Length > 0)
                        sp.PortName = lines[0];
                    sp.BaudRate = Convert.ToInt32(lines[1]);
                    sp.DataBits = Convert.ToInt32(lines[2]);
                    sp.Parity = Parity.None;
                    sp.StopBits = StopBits.One;
                    sp.Open();
                    lblBaglanti.ForeColor = Color.DarkGreen;
                    lblBaglanti.Text = "Başarılı: " + sp.PortName.ToString();
                    sp.ReadTimeout = 500;
                }
                catch (Exception ex)
                {
                    lblBaglanti.ForeColor = Color.DarkRed;
                    lblBaglanti.Text = "Bağlantı Başarısız";
                  
                    MessageBox.Show(ex.ToString());
                }            
            }
        }
        
        private void VeriEkle() // Ürün ekleme
        {
            


            string sorgu = "INSERT INTO EtiketBilgiler(Firma,IplikCinsi,IplikKodu,BobinAdet,Tarih,NetKG) VALUES (@Firma,@IplikCinsi,@IplikKodu,@BobinAdet,@Tarih,@NetKG)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@Firma", tbxFirma.Text);
            komut.Parameters.AddWithValue("@IplikCinsi", tbxIplikCinsi.Text);
            komut.Parameters.AddWithValue("@IplikKodu", tbxIplikKodu.Text);
            komut.Parameters.AddWithValue("@BobinAdet", tbxBobinAdet.Text);
            komut.Parameters.AddWithValue("@Tarih", Convert.ToDateTime(dateTimePicker1.Text));  
            komut.Parameters.AddWithValue("@NetKG", tbxNetKG.Text);
       
         
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tablo2.DefaultView;
            dv.RowFilter = "FirmaAdı LIKE '" + tbxFirmaAra.Text + "%'";
            dgwFirmalar.DataSource = dv;
        }
        private void dgwFirmalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbxFirma.Text = dgwFirmalar.CurrentRow.Cells[0].Value.ToString();
            DataView dv = tablo.DefaultView;
            dv.RowFilter = "Firma LIKE '" + dgwFirmalar.CurrentRow.Cells[0].Value.ToString() + "%'";
            dgwTablo.DataSource = dv;
        }


        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Firma ve Etiket bilgilerini silmek istiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM Firmalar WHERE FirmaAdı=@FirmaAdı";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@FirmaAdı", dgwFirmalar.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();


                string sorgu2 = "DELETE FROM EtiketBilgiler WHERE Firma=@Firma";
                komut = new SqlCommand(sorgu2, baglanti);

                komut.Parameters.AddWithValue("@Firma", dgwFirmalar.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                FirmaListele();
                VeriListele();
            }
          
           
        }    
        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Firmalar(FirmaAdı) VALUES (@FirmaAdı)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@FirmaAdı", tbxFirmaEkle.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            FirmaListele();
        }


        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Seçili etiketi silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM EtiketBilgiler WHERE ID=@ID";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@ID", dgwTablo.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                VeriListele();
            }
        }
        private bool HataControl()
        {
            if (String.IsNullOrEmpty(tbxYazdirAdet.Text))
                 { 
                MessageBox.Show("Yazdırma Adeti Giriniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                 }
            if (string.IsNullOrEmpty(tbxDara.Text))
                {
                MessageBox.Show("Dara Boş Bırakılamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
            return true;
            
        }
        string veri;

        private void sp_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            if (HataControl())
            {
                veri = sp.ReadLine();
                Control.CheckForIllegalCrossThreadCalls = false; // thread çakışmaması için..
                veri = veri.Substring(2, 9);

                tbxGelenVeri.Text = veri.Trim();
                tbxNetKG.Text = tbxGelenVeri.Text;

                string bosluk = "";
                string[] a = tbxNetKG.Text.Split(' ');
                for (int i = 0; i < a.Length; i++)
                {
                    bosluk += a[i];
                }
                tbxNetKG.Text = bosluk;

                VeriEkle();
                VeriListele();


                baglanti.Open();
                DataSet dataset = new DataSet();
                for (int i = 0; i < Convert.ToInt32(tbxYazdirAdet.Text); i++)
                {
                 
                    da = new SqlDataAdapter("SELECT top 1 * FROM EtiketBilgiler Order by ID desc", baglanti);
                    da.Fill(dataset, "dataset");
                    baglanti.Close();
                    Report rapor = new Report();
                    rapor.RegisterData(dataset, "dataset");
                    rapor.Load("Etiket_Design.frx");
                    rapor.PrintSettings.ShowDialog = false;
                    rapor.Print();
                }
              

                double s1, s2, toplam;
                s1 = Convert.ToDouble(tbxNetKG.Text);
                if (string.IsNullOrEmpty(tbxToplamKg.Text))
                {
                    tbxToplamKg.Text = tbxNetKG.Text;
                }
                else
                {
                    s2 = Convert.ToDouble(tbxToplamKg.Text);

                    s2 = Convert.ToDouble(tbxToplamKg.Text.Replace('.', ','));
                    s1 = Convert.ToDouble(tbxNetKG.Text.Replace('.', ','));
                    toplam = s2 + s1;
                    s2 = Convert.ToDouble(tbxToplamKg.Text.Replace(',', '.'));
                    s1 = Convert.ToDouble(tbxNetKG.Text.Replace(',', '.'));
                    tbxToplamKg.Text = toplam.ToString();
                    tbxToplamKg.Text = tbxToplamKg.Text.Replace(',', '.');
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet dataset = new DataSet();

            da = new SqlDataAdapter("SELECT * FROM EtiketBilgiler where ID = '" + dgwTablo.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);

            da.Fill(dataset, "dataset");
            baglanti.Close();
            Report rapor = new Report();
            rapor.RegisterData(dataset, "dataset");
            rapor.Load("Etiket_Design.frx");
            rapor.Design();
        }

        private void btnManuelYazdir_Click(object sender, EventArgs e)
        {
            if (dgwTablo.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Ekleyiniz.", "Hata!", MessageBoxButtons.OK,MessageBoxIcon.Error);
           }
            else
            {
                ManuelYazdir();
            }
        }

        private void ManuelYazdir()
        {
            for (int i = 0; i < Convert.ToInt32(tbxYazdirAdet.Text); i++)
            {
                baglanti.Open();
                DataSet dataset = new DataSet();

                da = new SqlDataAdapter("SELECT * FROM EtiketBilgiler where ID = '" + dgwTablo.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);

                da.Fill(dataset, "dataset");
                baglanti.Close();
                Report rapor = new Report();
                rapor.RegisterData(dataset, "dataset");
                rapor.Load("Etiket_Design.frx");
                rapor.PrintSettings.ShowDialog = false;
                rapor.Print();

            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Etiket bilgilerini silmek istiyor musunuz ?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                string sorgu2 = "DELETE FROM EtiketBilgiler WHERE Firma=@Firma";
                komut = new SqlCommand(sorgu2, baglanti);

                komut.Parameters.AddWithValue("@Firma", dgwFirmalar.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();


                VeriListele();
                tbxFirma.Text = "";
                tbxIplikCinsi.Text = "";
                tbxIplikKodu.Text = "";
                tbxBobinAdet.Text = "";

                tbxNetKG.Text = "";
                tbxToplamKg.Text = "";
            }
        }
    }
}
