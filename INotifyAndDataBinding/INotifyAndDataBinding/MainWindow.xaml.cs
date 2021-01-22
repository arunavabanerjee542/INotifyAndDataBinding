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

namespace INotifyAndDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        View v;

        public MainWindow()
        {
          InitializeComponent();

            v = new View();

            DataContext = v;


        }


        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            v.bg.SetBackGround(Brushes.Red);


        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            v.bg.SetBackGround(Brushes.Blue);
        }



    }
}
