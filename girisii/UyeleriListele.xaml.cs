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
    /// Interaction logic for UyeleriListele.xaml
    /// </summary>
    public partial class UyeleriListele : Window
    {
        public UyeleriListele()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\KutuphaneO1.accdb");
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            doldur();
        }
    
        public void sil()
        {
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.Connection = Baglanti;
            kmt.CommandText = "delete from Uyeler where UID=" + UID.Text;
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            doldur();
        }
        public void doldur()
        {
            Baglanti.Open();
            string bag = "select UID,UAd,USoyad,UTelefon,UEPosta,UAdres,UKullanıcıAD,USifre from Uyeler";
            OleDbCommand komut = new OleDbCommand(bag, Baglanti);
            komut.ExecuteNonQuery();
            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable("Uyeler");
            adp.Fill(dt);
            dtg_uyelistesi.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            Baglanti.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            sil();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                Baglanti.Open();
                string sorgu = "UPDATE Uyeler set UAd=@UAd,USoyad=@USoyad,UTelefon=@UTelefon,UEPosta=@UEPosta,UAdres=@UAdres,UKullanıcıAD=@UKullanıcıAD,USifre=@USifre WHERE UID="+int.Parse(UId.Text);
                OleDbCommand komut = new OleDbCommand(sorgu, Baglanti);
                komut.Parameters.AddWithValue("@UAd", UAD.Text);
                komut.Parameters.AddWithValue("@USoyad", USOYAD.Text);
                komut.Parameters.AddWithValue("@UTelefon", UTelefon.Text);
                komut.Parameters.AddWithValue("@UEPosta", Posta.Text);
                komut.Parameters.AddWithValue("@UAdres", Adres.Text);
                komut.Parameters.AddWithValue("@UKullanıcıAD", KA.Text);
                komut.Parameters.AddWithValue("@USifre", Sifrem.Text);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                Hata hat = new Hata("Güncellendi");
                hat.ShowDialog();
                doldur();
            }
            catch(Exception h)
            {
                MessageBox.Show(h.Message);
            }
        }

        private void UId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void UTelefon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void UID_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
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
            kmt.CommandText = "select * from Uyeler";
            kmt.Connection = Baglanti;
            OleDbDataAdapter da = new OleDbDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sayi.Text = dt.Rows.Count.ToString();
            Baglanti.Close();
        }
    }
}
