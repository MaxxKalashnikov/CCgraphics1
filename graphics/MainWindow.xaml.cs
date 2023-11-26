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

namespace graphics
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

        private void cmDraw(object sender, RoutedEventArgs e)
        {
            // линия 
            Line L;
            L = new Line();
            L.X1 = 0;
            L.Y1 = 0;
            L.X2 = 170;
            L.Y2 = 170;
            L.Stroke = Brushes.Red;
            L.StrokeThickness = 5;
            g.Children.Add(L);
            // четырёхугольник
            Rectangle R;
            R = new Rectangle();
            R.Width = 200;
            R.Height = 100;
            R.Margin = new Thickness(200, 200, 0, 0);
            R.Fill = Brushes.Blue;
            R.Stroke = Brushes.PapayaWhip;
            R.StrokeThickness = 25;
            g.Children.Add(R);
            // круг
            Ellipse O;
            O = new Ellipse();
            O.Width = 100;
            O.Height = 100;
            O.Margin = new Thickness(500, 100, 0, 0);
            O.Fill = Brushes.DarkBlue;
            O.Stroke = Brushes.BurlyWood;
            O.StrokeThickness = 15;
            g.Children.Add(O);

        }

        private void cmLines(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Line L;
            for (int i = 0; i < 100; i++)
            {
                L = new Line();
                L.X1 = rnd.NextDouble() * g.Width;
                L.Y1 = rnd.NextDouble() * g.Height;
                L.X2 = rnd.NextDouble() * g.Width;
                L.Y2 = rnd.NextDouble() * g.Height;
                L.Stroke = Brushes.Black;
                L.StrokeThickness = 3;
                g.Children.Add(L);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            g.Children.Clear();
        }
    }
}
