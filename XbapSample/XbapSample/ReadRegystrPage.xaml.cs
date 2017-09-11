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
using XbapSample.Helpers;

namespace XbapSample
{
    /// <summary>
    /// Interaction logic for ReadRegystrPage.xaml
    /// </summary>
    public partial class ReadRegystrPage: PageFunction<String>
    {
        public ReadRegystrPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(PathTextBox.Text) && !string.IsNullOrEmpty(KeyTextBox.Text))
            {
                DataContext = RegistryHelper.GetRegistryKeyValue(PathTextBox.Text, KeyTextBox.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.OnReturn(new ReturnEventArgs<string>((string)this.DataContext));

            //if (this.NavigationService.CanGoBack)
            //{
            //    this.NavigationService.GoBack();
            //}
        }
    }
}
