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
using BL;
using DAT;

namespace girisii
{
    /// <summary>
    /// Interaction logic for KitapEkle.xaml
    /// </summary>
    public partial class KitapEkle : Window
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        //baglanti baglan = new baglanti();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pshow.PopUp(Popup_Bilgi);
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory +"\\KutuphaneO1.accdb");
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            { 
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.Connection = Baglanti;
            kmt.CommandText = "INSERT INTO Kitaplar(KAd,KYazar,KBaskıYılı,KSayfaSayısı,KYayınevi,Kaciklama,ISBN,KAdet,KTur) values(@KAd,@KYazar,@KBaskıYılı,@KSayfaSayısı,@KYayınevi,@Kaciklama,@ISBN,@KAdet,@KTur)";
            kmt.Parameters.AddWithValue("@KAd", adı.Text);
            kmt.Parameters.AddWithValue("@KYazar", yazar.Text);
            kmt.Parameters.AddWithValue("@KBaskıYılı", date.Text);
            kmt.Parameters.AddWithValue("@KSayfaSayısı", SayfaSayısı.Text);
            kmt.Parameters.AddWithValue("@KYayınevi", YayınE.Text);
            kmt.Parameters.AddWithValue("@Kaciklama", acıklama.Text);
            kmt.Parameters.AddWithValue("@ISBN", ISBN.Text);
            kmt.Parameters.AddWithValue("@KAdet", Stok.Text);
            kmt.Parameters.AddWithValue("@KTur", tur.Text);
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            Hata hata = new Hata("Başarılı");
            hata.ShowDialog();
            }
            catch(Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }
        private void Adı_TextChanged(object sender, TextChangedEventArgs e)
        {
            adı.CharacterCasing = CharacterCasing.Lower;
        }
        private void Yazar_TextChanged(object sender, TextChangedEventArgs e)
        {
            yazar.CharacterCasing = CharacterCasing.Lower;
        }
        private void YayınE_TextChanged(object sender, TextChangedEventArgs e)
        {
            YayınE.CharacterCasing = CharacterCasing.Lower;
        }
        private void Acıklama_TextChanged(object sender, TextChangedEventArgs e)
        {
            acıklama.CharacterCasing = CharacterCasing.Lower;
        }

        private void SayfaSayısı_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
        private void Stok_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
