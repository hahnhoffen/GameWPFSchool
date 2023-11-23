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
    /// Interaction logic for EnchanterLocation.xaml
    /// </summary>
    public partial class EnchanterLocation : Window
    {
        public Fighters fighter;
        public Location location;
        public EnchanterLocation(Fighters fighter, Location location)
        {
            InitializeComponent();
            this.fighter = fighter;
            this.location = location;
            Loaded += EnchanterLocation_Loaded;
            ResizeMode = ResizeMode.NoResize;
        }
        private void EnchanterLocation_Loaded(object sender, RoutedEventArgs e)
        {
            EnchanterShowText.Visibility = Visibility.Hidden;
            Loaded -= EnchanterLocation_Loaded;
        }
        private void TakeLoot_Click(object sender, RoutedEventArgs e)
        {
            EnchanterShowText.Visibility= Visibility.Visible;
            fighter.AddItem(location.Loot);

        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Enchanter_Text(object sender, RoutedEventArgs e)
        {

        }
    }
}
