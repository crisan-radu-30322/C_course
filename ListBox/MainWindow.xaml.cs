using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ListBox.Data;

namespace ListBox;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public List<Person> People = new List<Person>
    {
        new Person{Name = "Radu", Age = 22},
        new Person{Name = "Tudor", Age = 24}
    };
    public MainWindow()
    {
        InitializeComponent();
        ListBoxPeople.ItemsSource = People;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var selectedItems = ListBoxPeople.SelectedItems;
        foreach (var item in selectedItems)
        {
            var person = (Person)item;
            MessageBox.Show(person.Name);
        }
    }
}