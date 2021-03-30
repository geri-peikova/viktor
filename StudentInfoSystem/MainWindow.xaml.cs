using StudentInfoSystem;
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

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new StudentViewModel();
        }

        public void ClearInput()
        {

            foreach (var item in PersonalDataGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }

            foreach (var item in StudentDataGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        public void SetEnabledAll(bool enable)
        {

            foreach (var item in PersonalDataGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = enable;
                }
            }

            foreach (var item in StudentDataGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = enable;
                }
            }
        }
    }
}
