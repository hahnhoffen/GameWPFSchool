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

namespace WPFGameSchool
{
    /// <summary>
    /// Interaction logic for PrincessLocation.xaml
    /// </summary>
    public partial class PrincessLocation : Window
    {
        public PrincessLocation()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }

        private void GoHome_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
