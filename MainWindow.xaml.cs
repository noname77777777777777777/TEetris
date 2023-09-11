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

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] imageSource = new ImageSource[]
        {
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-Empty.png",UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-I.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-J.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-L.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-O.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-S.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-T.png", UriKind.Relative)),
            new BitmapImage(new Uri("C:\\Users\\thanh\\OneDrive\\Máy tính\\Tetris\\Tetris\\Asset\\Block-Z.png", UriKind.Relative)),
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
