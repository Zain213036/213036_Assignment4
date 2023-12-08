using System.Windows;

namespace WpfOneWayBindingExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create an instance of the Person class
            Person person = new Person
            {
                Name = "Zain",
                Age = 21,
                Occupation = "Student"
            };

            // Set the DataContext of the window to the instance of the Person class
            DataContext = person;
        }
    }
}
