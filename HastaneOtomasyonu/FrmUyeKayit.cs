using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class FrmUyeKayit : Form
    {
        public FrmUyeKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmUyeKayit_Load(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.Baglanti());
            //komut.Parameters.AddWithValue("@p1", txtAd.Text);
            //komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            //komut.Parameters.AddWithValue("@p3", mskTC.Text);
            //komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            //komut.Parameters.AddWithValue("@p5", txtSifre.Text);

            //komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            //komut.ExecuteNonQuery();
            //bgl.Baglanti().Close();
            //MessageBox.Show("Kaydınız gerçekleşmiştir Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);

            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
