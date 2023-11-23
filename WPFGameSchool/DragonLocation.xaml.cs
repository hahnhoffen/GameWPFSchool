using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for DragonLocation.xaml
    /// </summary>
    public partial class DragonLocation : Window
    {
        public DragonLocation()
        {
            InitializeComponent();
            Loaded += DragonLocation_Loaded;
            ResizeMode = ResizeMode.NoResize;
        }


        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            AttackSelected.Visibility = Visibility.Visible;
            Attackselected2.Visibility = Visibility.Visible;
        }
        private void DragonLocation_Loaded(object sender, RoutedEventArgs e)
        {
            AttackSelected.Visibility = Visibility.Hidden;
            Attackselected2.Visibility = Visibility.Hidden;
            Loaded -= DragonLocation_Loaded;
        }

        private void TryLeave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("YOU CANT LEAVE NOW, GO BACK");
        }

        private void Attack_Text(object sender, RoutedEventArgs e)
        {
        }


        private void GoToPrincess_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Princess_buttonShow(object sender, RoutedEventArgs e)
        {
            PrincessLocation princesslocation = new PrincessLocation();
            princesslocation.Show();
        }
    }
}
