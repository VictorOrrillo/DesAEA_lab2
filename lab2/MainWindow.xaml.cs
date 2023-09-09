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

namespace lab2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string userText = userlabel.Text;
            string keyText = keylabel.Text;

            string userinfo = "usuario";
            string keyinfo = "123456";

            if ((userText == userinfo) && (keyText == keyinfo))
            {
                Window1 window1 = new Window1();
                this.Close();
                window1.Show();
            }
            else
            {
                Window2 window1 = new Window2();
                this.Close();
                window1.Show(); ;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
