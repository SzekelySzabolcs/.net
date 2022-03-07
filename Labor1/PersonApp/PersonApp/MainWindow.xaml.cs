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

namespace PersonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { FirstName = "John", LastName = "Doe" });
            people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
            people.Add(new Person { FirstName = "Sue", LastName = "Strom" });
            cmbBxPeopleName.ItemsSource = people;
        }
        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {txtBxFirstName.Text} {txtBxLastName.Text}");
        }
        private void PeopleList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Person currentPerson = (Person)cmbBxPeopleName.SelectedItem;
            txtBxFirstName.Text = currentPerson.FirstName;
            txtBxLastName.Text = currentPerson.LastName;
        }

    }
}
