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
using System.Windows.Shapes;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public ExpenseItHome()
        {
            InitializeComponent();
            ListBoxItem mike = new ListBoxItem();
            ListBoxItem lisa = new ListBoxItem();
            ListBoxItem john = new ListBoxItem();
            ListBoxItem mary = new ListBoxItem();
            ListBoxItem james = new ListBoxItem();
            ListBoxItem david = new ListBoxItem();
            mike.Content = "Mike";
            lisa.Content = "Lisa";
            john.Content = "John";
            mary.Content = "Mary";
            james.Content = "James";
            david.Content = "David";
            peopleListBox.Items.Add(mike);
            peopleListBox.Items.Add(lisa);
            peopleListBox.Items.Add(john);
            peopleListBox.Items.Add(mary);
            peopleListBox.Items.Add(james);
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ExpenseItReport expenseReportWindow = new ExpenseItReport();
            expenseReportWindow.Show();
        }
    }
}
