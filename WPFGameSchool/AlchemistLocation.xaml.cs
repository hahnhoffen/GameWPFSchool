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
    /// Interaction logic for AlchemistLocation.xaml
    /// </summary>
    public partial class AlchemistLocation : Window
    {
        public Fighters fighter;
        public Location location;
        public AlchemistLocation(Fighters fighter, Location location)
        {
            InitializeComponent();
            this.fighter = fighter;
            this.location = location;
            Loaded += AlchemistLocation_Loaded;
            ResizeMode = ResizeMode.NoResize;
        }
        private void AlchemistLocation_Loaded(object sender, RoutedEventArgs e)
        {
            AlchemistShowText.Visibility = Visibility.Hidden;
            Loaded -= AlchemistLocation_Loaded;
        }
        private void TakeLoot_Click(object sender, RoutedEventArgs e)
        {
            AlchemistShowText.Visibility = Visibility.Visible;
            fighter.AddItem(location.Loot);
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Alchemist_Text(object sender, RoutedEventArgs e)
        {

        }
    }
}
