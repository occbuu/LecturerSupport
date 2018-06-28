using System.Windows;
using System.Windows.Input;

namespace StylesAndTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}