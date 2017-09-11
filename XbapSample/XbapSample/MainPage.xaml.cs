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

namespace XbapSample
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReadRegystrPage pageFunction = new ReadRegystrPage();
            pageFunction.Return += new ReturnEventHandler<string>(GetResult);
            this.NavigationService.Navigate(pageFunction);
        }

        private void GetResult(object sender, ReturnEventArgs<string> e)
        {
            var result = e.Result;
        }
    }
}
