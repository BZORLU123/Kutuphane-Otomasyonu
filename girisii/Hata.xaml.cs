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
    /// Interaction logic for Hata.xaml
    /// </summary>
    public partial class Hata : Window
    {
        public Hata(string mesaj)
        {
            InitializeComponent();
            yazi.Text = mesaj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
