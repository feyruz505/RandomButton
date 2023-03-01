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

namespace RandomButton
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            Button button = (Button)sender;
            MessageBoxResult result = MessageBox.Show("butonu deqiq silmek isteyirsiniz ?", "Alert", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                StackPanel parent = (StackPanel)button.Parent;
                parent.Children.Remove(button);
                MessageBox.Show(string.Format("{0} Button silindi.", button.Content), "Buton Silindi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn1.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn2.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn3.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn4.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn5.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            Brush brush = new SolidColorBrush(color);
            btn6.Background = brush;
            MessageBox.Show($"Hansi rengem men: {color.ToString()}");
        }
    }
}
