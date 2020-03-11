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
    /// Interaction logic for giris.xaml
    /// </summary>
    public partial class giris : Window
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            message msj = new message();
            msj.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.Show();
        }
        AnaEkran ana = new AnaEkran();
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string giris = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\KutuphaneO1.accdb";
            OleDbConnection baglanti = new OleDbConnection(giris);
            baglanti.Open();
            OleDbCommand kmt = new OleDbCommand("select * from Uyeler where UKullanıcıAD='"+giristext.Text+ "' and USifre='"+girissifre.Text + "'",baglanti);
            OleDbDataReader datar = kmt.ExecuteReader();
            if(datar.Read())
            {
                ana.Show();
                this.Close();
            }
            else
            {
                Hata hata = new Hata("HATA!");
                hata.ShowDialog();
            }
            baglanti.Close();
        }
    }
}
