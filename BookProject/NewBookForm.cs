using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProject
{
    public partial class NewBookForm : Form
    {
        string connectionString = @"Data Source=MELI\SQLEXPRESS;Initial Catalog=TechCareerBook;Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True;";
        
        public int secilenKategoriId;
        public int secilenYayinEviId;
        public int secilenYazarId;
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void NewBookForm_Load(object sender, EventArgs e)
        {
            KategoriGetir();
            YayınEviGetir();
            YazarGetir();
        }

        public void KategoriGetir()
        {
            try
            {
                List<Category> kategoriList = new List<Category>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sorgu = "select * from Category";
                SqlCommand command = new SqlCommand(sorgu, conn);
                SqlDataReader reader = command.ExecuteReader();
                kategoriList.Add(new Category()
                {
                    ID = -1,
                    KategoriAdi = "Kategori Seçiniz"
                });

                while (reader.Read())
                {
                    kategoriList.Add(new Category()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        KategoriAdi = reader["KategoriAdi"].ToString()
                    });
                }

                cmbKategori.DataSource = kategoriList;
                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "ID";
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());
            }
        }
        public void YazarGetir()
        {
            try
            {
                List<Author> yazarList = new List<Author>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sorgu = "select * from Author";
                SqlCommand command = new SqlCommand(sorgu, conn);
                SqlDataReader reader = command.ExecuteReader();
                yazarList.Add(new Author()
                {
                    ID = -1,
                    YazarAdiSoyadi = "Yazar Seçiniz"
                });

                while (reader.Read())
                {
                    yazarList.Add(new Author()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        YazarAdiSoyadi = reader["YazarAdi"].ToString() + " " + reader["YazarSoyadi"].ToString()
                    });
                }

                cmbYazar.DataSource = yazarList;
                cmbYazar.DisplayMember = "YazarAdiSoyadi";
                cmbYazar.ValueMember = "ID";
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());
            }
        }
        public void YayınEviGetir()
        {
            try
            {
                List<Publisher> yayinEviListesi = new List<Publisher>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sorgu = "select * from Publisher";
                SqlCommand command = new SqlCommand(sorgu, conn);
                SqlDataReader reader = command.ExecuteReader();
                yayinEviListesi.Add(new Publisher()
                {
                    ID = -1,
                    YayinEviAdi = "Yayın Evi Seçiniz"
                });

                while (reader.Read())
                {
                    yayinEviListesi.Add(new Publisher()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        YayinEviAdi = reader["YayinEviAdi"].ToString()
                    });
                }

                cmbYayinEvi.DataSource = yayinEviListesi;
                cmbYayinEvi.DisplayMember = "YayinEviAdi";
                cmbYayinEvi.ValueMember = "ID";
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());
            }
        }
        public void KitaplariGetir()
        {
            try
            {
                //using kullanımı sqlconnection nesnesi ile ilgili işlem tamamlandığında garbage collector'a gerek kalmadan 
                //nesnenin ram'den temizlenmesini sağlar
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sorgu = "select yk.ID, yk.KitapAdi, yk.Fiyat, yk.SayfaSayisi, ya.YazarAdi, ya.YazarSoyadi, k.KategoriAdi, ye.YayinEviAdi\r\nfrom NewBook as yk\r\ninner join Author as ya \r\non ya.ID = yk.YazarID\r\ninner join Category as k\r\non k.ID = yk.KategoriID\r\ninner join Publisher as ye\r\non ye.ID = yk.YayinEviID";
                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
                    DataSet ds = new DataSet(); //veri tabanı saklama
                    adapter.Fill(ds, "Kitaplar"); //veri kümesine isim verip sorguyu doldur
                    dataGridView1.DataSource = ds.Tables["Kitaplar"];
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sorgu = "insert into NewBook(KitapAdi, Fiyat, SayfaSayisi, YazarID, KategoriID, YayinEviID) values('" + txtKitapAdi.Text + "','" + txtFiyati.Text + "','" + txtSayfaSayisi.Text + "','" + secilenYazarId + "','" + secilenKategoriId + "','" + secilenYayinEviId + "')";
                    SqlCommand komut = new SqlCommand(sorgu, conn);
                    int etkilenenKayitSayisi = komut.ExecuteNonQuery();
                    if(etkilenenKayitSayisi> 0)
                    {
                        MessageBox.Show("Kayıt eklendi");
                        KitaplariGetir();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi");
                    }
                    conn.Close();

                    // SqlCommand command = new SqlCommand($"insert into YeniKitap(KitapAdi,Fiyat,SayfaSayisi,YazarId,KategoriId,YayinEviId) values('{txtKitapAdi.Text}','{txtFiyati.Text}',{txtSayfaSayisi.Text},{secilenYazarId},'{secilenKategoriId}',{secilenYayinEviId}", conn);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message.ToString());
            }

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category kategori = (Category)cmbKategori.SelectedItem;
            secilenKategoriId = kategori.ID;
        }
        private void cmbYayınEvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publisher yayinEvi = (Publisher)cmbYayinEvi.SelectedItem;
            secilenYayinEviId = yayinEvi.ID;
        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author yazar = (Author)cmbYazar.SelectedItem;
            secilenYazarId = yazar.ID;
        }
    }
}
