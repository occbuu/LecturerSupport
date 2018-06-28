using System.Windows;

namespace DataBiding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person _person;

        public MainWindow()
        {
            InitializeComponent();
            _person = new Person { FirstName = "First name", LastName = "Last name" };

            //Set the DataContext of the Window.
            DataContext = _person;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}