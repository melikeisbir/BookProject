using Microsoft.Data.SqlClient;

namespace BookProject
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MELI\SQLEXPRESS;Initial Catalog=TechCareerBook;Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string kitapAdi = txtKitapAdi.Text;
                string kitapFiyati = txtFiyat.Text;
                string sayfaSayisi = txtSayfaSayisi.Text;

                string sorgu = "insert into Book(KitapAdi, Fiyat, SayfaSayisi) values ('" + kitapAdi + "','" + kitapFiyati + "','" + sayfaSayisi + "')";
                SqlCommand command = new SqlCommand(sorgu, conn);
                int etkilenenKayitSayisi = command.ExecuteNonQuery(); //kod oluþturulup bu kýsýmda kayýt gerçekleþiyor
                if (etkilenenKayitSayisi > 0)
                {
                    MessageBox.Show("Kayýt eklenmiþtir");
                }
                else
                {
                    MessageBox.Show("Kayýt eklenmiþtir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluþtu : " + ex.Message.ToString());
            }
        }
    }
}
