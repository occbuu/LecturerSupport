using System.Windows;

namespace Navigation
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

        private void btnP1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }

        private void btnP2_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
    }
}