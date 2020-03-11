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

namespace girisii
{
    /// <summary>
    /// Interaction logic for AnaEkran.xaml
    /// </summary>
    public partial class AnaEkran : Window
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Butonkapatma_Click(object sender, RoutedEventArgs e)
        {
            butonacma.Visibility = Visibility.Visible;
            butonkapatma.Visibility = Visibility.Collapsed;
        }

        private void Butonacma_Click(object sender, RoutedEventArgs e)
        {
            butonacma.Visibility = Visibility.Collapsed;
            butonkapatma.Visibility = Visibility.Visible;
        }
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            KitapEkle KitapE = new KitapEkle();
            KitapE.ShowDialog();
        }
        private void CıkısyapButon_Click(object sender, RoutedEventArgs e)
        {
            message msj = new message();
            msj.ShowDialog();
            //Application.Current.Shutdown();
        }

        private void Kiekle_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            UyeleriListele listele = new UyeleriListele();
            listele.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            GecikmisKitaplar gecik = new GecikmisKitaplar();
            gecik.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            EmanetKitaplar emanet = new EmanetKitaplar();
            emanet.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            KitaplariListele Klist = new KitaplariListele();
            Klist.ShowDialog();
        }
    }
}
