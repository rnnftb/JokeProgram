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
using System.Windows.Navigation;
using System.Windows.Shapes;
using gayprogram.Windows;
//Пока печатал название ^^^ допустил грамматическую ошибку

namespace gayprogram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        //В случае нажатия идет переход на экран к гачи
        private void btnGayYes1_Click(object sender, RoutedEventArgs e)
        {
            GifWindow gifWindow = new GifWindow();
            gifWindow.Show();
            this.Close();
        }
        //В случае нажатия идет переход на экран к гачи
        private void btnGayYes2_Click(object sender, RoutedEventArgs e)
        {
            GifWindow gifWindow = new GifWindow();
            gifWindow.Show();
            this.Close();
        }
        //В случае наведеия мышки на кнопку текст будет меняться на "Yes"
        private void btnGayYes2_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGayYes2.Content = "Yes, daddy UWU";
        }
        //В случае наведеия мышки на кнопку текст будет меняться на "No"
        private void btnGayYes2_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGayYes2.Content = "No";
        }
        //Рудимент. Можете поэкспериментировать :D
        private void btnGayYes1_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void btnGayYes1_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        //В случае нажатия идет переход на экран к гачи
        private void btnGayExit_Click(object sender, RoutedEventArgs e)
        {
            GifWindow gifWindow = new GifWindow();
            gifWindow.Show();
            this.Close();
        }
    }
}
