using System.Windows;

namespace DemoWPF
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

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Grid gr = new Grid();
            gr.ShowDialog();
        }

        private void Verical_Click(object sender, RoutedEventArgs e)
        {
            StackPanelVer st = new StackPanelVer();
            st.ShowDialog();
        }

        private void Horizontal_Click(object sender, RoutedEventArgs e)
        {
            StackPanelHor st = new StackPanelHor();
            st.ShowDialog();
        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dock = new DockPanel();
            dock.ShowDialog();
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            Canvas canvas = new Canvas();
            canvas.ShowDialog();
        }

        private void Animation_Click(object sender, RoutedEventArgs e)
        {
            Animation ani = new Animation();
            ani.ShowDialog();
        }

        private void TypeConverters_Click(object sender, RoutedEventArgs e)
        {
            TypeConverters type = new TypeConverters();
            type.ShowDialog();
        }
    }
}