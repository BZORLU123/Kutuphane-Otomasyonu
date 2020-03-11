using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;

namespace girisii
{
    /// <summary>
    /// Interaction logic for KitaplariListele.xaml
    /// </summary>
    public partial class KitaplariListele : Window
    {
        public KitaplariListele()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\KutuphaneO1.accdb");
        public void doldur()
        {
            try
            {
                Baglanti.Open();
                string bag = "select KID,KAd,KYazar,KBaskıYılı,KSayfaSayısı,KYayınevi,Kaciklama,ISBN,KAdet,KTur from Kitaplar";
                OleDbCommand komut = new OleDbCommand(bag, Baglanti);
                komut.ExecuteNonQuery();
                OleDbDataAdapter adp = new OleDbDataAdapter(komut);
                DataTable dt = new DataTable("Kitaplar");
                adp.Fill(dt);
                dtg_kitaplistesi.ItemsSource = dt.DefaultView;
                adp.Update(dt);
                Baglanti.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }
        public void sil()
        {
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.Connection = Baglanti;
            kmt.CommandText = "delete from Kitaplar where KID=" + KID.Text;
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            doldur();
        }
        public static string[] txt = new string[10];
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            doldur();  
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sil();
            Hata hata = new Hata("Silindi");
            hata.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Baglanti.Open();
                string sorgu = "UPDATE Kitaplar set KAd=@KAd,KYazar=@KYazar,KBaskıYılı=@KBaskıYılı,KSayfaSayısı=@KSayfaSayısı,KYayınevi=@KYayınevi,Kaciklama=@Kaciklama,ISBN=@ISBN,KAdet=@KAdet,KTur=@KTur WHERE KID=" + int.Parse(Kıd.Text);
                OleDbCommand komut = new OleDbCommand(sorgu, Baglanti);
                komut.Parameters.AddWithValue("@KAd", Ad.Text);
                komut.Parameters.AddWithValue("@KYazar", yazar.Text);
                komut.Parameters.AddWithValue("@KBaskıYılı", date.Text);
                komut.Parameters.AddWithValue("@KSayfaSayısı", sayfa.Text);
                komut.Parameters.AddWithValue("@KYayınevi", yayınevi.Text);
                komut.Parameters.AddWithValue("@Kaciklama", aciklama.Text);
                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);
                komut.Parameters.AddWithValue("@KAdet", Adet.Text);
                komut.Parameters.AddWithValue("@KTur",tur.Text);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Hata hat = new Hata("Güncellendi");
                hat.ShowDialog();
                doldur();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void Kıd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void KID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void Sayfa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void ISBN_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void Adet_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.CommandText = "select * from Kitaplar";
            kmt.Connection = Baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sayi.Text = dt.Rows.Count.ToString();
            Baglanti.Close();
        }
    }
}
