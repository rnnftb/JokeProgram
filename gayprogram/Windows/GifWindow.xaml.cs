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

namespace gayprogram.Windows
{
    /// <summary>
    /// Логика взаимодействия для GifWindow.xaml
    /// </summary>
    public partial class GifWindow : Window
    {
        public GifWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
            meGif.Source = new Uri(Environment.CurrentDirectory + @"\gay.gif");
        }

        private void meGif_MediaEnded(object sender, RoutedEventArgs e)
        {
             meGif.Play();
        }
    }
}
