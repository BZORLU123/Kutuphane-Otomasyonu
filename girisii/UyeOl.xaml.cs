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
    /// Interaction logic for UyeOl.xaml
    /// </summary>
    public partial class UyeOl : Window
    {
        public UyeOl()
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
            Baglanti.Open();
            OleDbCommand kmt = new OleDbCommand("INSERT INTO Uyeler(UAd,USoyad,UTelefon,UEPosta,UAdres,UKullanıcıAD,USifre) VALUES('" + ad.Text + "','" + Soyad.Text + "','" + Telefon.Text + "','" + Eposta.Text + "','" + Adres.Text + "','" + Kullanıcı.Text + "','" + Sıfre.Text + "')", Baglanti);
            kmt.ExecuteNonQuery();
            Baglanti.Close();
            Hata msj = new Hata("Başarılı");
            msj.Show();
        }

        private void Telefon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
