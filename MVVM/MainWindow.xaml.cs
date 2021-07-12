using System;
using System.Collections.Generic;
using System.Configuration;
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
namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserControl1 uc1 = new UserControl1();
        public MainWindow()
        {
            InitializeComponent();
            MyGrid.Children.Add(uc1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ipLbl.Content = ConfigurationManager.AppSettings["MyIP"];
            UserControl2 uc2 = new UserControl2();
            MyGrid.Children.RemoveAt(0);
            MyGrid.Children.Add(uc2);
        }
    }
}
