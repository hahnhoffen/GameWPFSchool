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
    /// Interaction logic for LocalinnLocation.xaml
    /// </summary>
    public partial class LocalinnLocation : Window
    {
        public Fighters fighter;
        public Location location;
        public LocalinnLocation(Fighters fighter, Location location)
        {
            InitializeComponent();
            this.fighter = fighter;
            this.location = location;
            Loaded += LocalinnLocation_Loaded;
            ResizeMode = ResizeMode.NoResize;
        }
        private void LocalinnLocation_Loaded(object sender, RoutedEventArgs e)
        {
            OldmanShowText.Visibility = Visibility.Hidden;
            Loaded -= LocalinnLocation_Loaded;
        }
        private void OldmanLoot_Click(object sender, RoutedEventArgs e)
        {
            OldmanShowText.Visibility=Visibility.Visible;
            fighter.AddItem(location.Loot);
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void OldMan_Text(object sender, RoutedEventArgs e)
        {
        }
    }
}
