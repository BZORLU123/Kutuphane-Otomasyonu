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
    /// Interaction logic for EmanetKitaplar.xaml
    /// </summary>
    public partial class EmanetKitaplar : Window
    {
        public EmanetKitaplar()
        {
            InitializeComponent();
            dpv.Text = DateTime.Now.ToShortDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\KutuphaneO1.accdb");
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Baglanti.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from Uyeler where UTelefon like '" + ttxt.Text+"'",Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Teldata.ItemsSource = dt.DefaultView;
            Baglanti.Close();

        }

        private void Isbntxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Baglanti.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from Kitaplar where ISBN like '"+isbntxt.Text+"'",Baglanti);
            DataTable dtb = new DataTable();
            ad.Fill(dtb);
            isbndt.ItemsSource = dtb.DefaultView;
            Baglanti.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand();
            kmt.Connection = Baglanti;
            kmt.CommandText = "INSERT INTO Emanetler(UTelefon,ISBN,EmanetTarihi,IadeTarihi) values (@UTelefon,@ISBN,@EmanetTarihi,@IadeTarihi)";
            kmt.Parameters.AddWithValue("@UTelefon",ttxt.Text);
            kmt.Parameters.AddWithValue("@ISBN",isbntxt.Text);
            kmt.Parameters.AddWithValue("@EmanetTarihi", dpv.Text);
            kmt.Parameters.AddWithValue("@IadeTarihi",dpi.Text);
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            Hata hata = new Hata("Emanet verildi");
            hata.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Baglanti.Open();
            string bag = "select EID,UTelefon,ISBN,EmanetTarihi,IadeTarihi,Getirildi from Emanetler";
            OleDbCommand komut = new OleDbCommand(bag, Baglanti);
            komut.ExecuteNonQuery();
            OleDbDataAdapter adp = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable("Kitaplar");
            adp.Fill(dt);
            Uyedtg.ItemsSource = dt.DefaultView;
            adp.Update(dt);
            Baglanti.Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int onay;
            if (rdr1.IsChecked == true)
            {
                onay = 0;
            }
            else
            {
                onay = -1;
            }
            Baglanti.Open();
            string sorgu = "UPDATE Emanetler set IadeTarihi=@IadeTarihi,Getirildi=@Getirildi WHERE EID=" + int.Parse(EID.Text);
            OleDbCommand kmt = new OleDbCommand(sorgu,Baglanti);
            kmt.Parameters.AddWithValue("@IadeTarihi", dpi.Text);
            kmt.Parameters.AddWithValue("@Getirildi",rdr1.IsChecked);
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            Hata hata = new Hata("Güncellendi");
            hata.ShowDialog();
        }

        private void EID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void Ttxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void Isbntxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void EID_TextChanged(object sender, TextChangedEventArgs e)
        {
            Baglanti.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from Emanetler where EID like '" + EID.Text + "'", Baglanti);
            DataTable dtb = new DataTable();
            ad.Fill(dtb);
            Uyedtg.ItemsSource = dtb.DefaultView;
            Baglanti.Close();
        }
    }
}
