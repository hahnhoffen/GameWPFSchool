using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        Item Sword = new Item("Sword");
        Item Bow = new Item("Bow");
        Item Dagger = new Item("Dagger");
        Item FirePotion;
        Item FrostEnchant;
        Item OldMan;
        private Fighters fighter;
        public LoginWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;

        }
        private void barbarianButton_Click(object sender, RoutedEventArgs e)
        {
            barbarianSelected.Visibility = Visibility.Visible;
            barbarianSelected.IsHitTestVisible = true;
        }

        private void ratKingButton_Click(object sender, RoutedEventArgs e)
        {
            ratkingSelected.Visibility = Visibility.Visible;
            ratkingSelected.IsHitTestVisible= true;
        }

        private void archerButton_Click(object sender, RoutedEventArgs e)
        {
            archerSelected.Visibility = Visibility.Visible;
            archerSelected.IsHitTestVisible=true;
        }
        private void archerGoBack(object sender, RoutedEventArgs e)
        {
            archerSelected.Visibility=Visibility.Collapsed;

        }
        private void archerPick(object sender, RoutedEventArgs e)
        {
            Fighters fighter = new Fighters("Archer", Bow);
            TownWindow town = new TownWindow(fighter, Sword, Bow, Dagger, FirePotion, FrostEnchant, OldMan);
            town.Show();
            Close();
        }
        private void barbarianPick(object sender, RoutedEventArgs e)
        {
            Fighters fighter = new Fighters("Barbarian", Sword);
            TownWindow town = new TownWindow(fighter, Sword, Bow, Dagger, FirePotion, FrostEnchant, OldMan);
            town.Show();
            Close();
        }
        private void barbarianGoBack(object sender, RoutedEventArgs e)
        {
            barbarianSelected.Visibility=Visibility.Collapsed;
        }
        private void ratkingPick(object sender, RoutedEventArgs e)
        {
            Fighters fighter = new Fighters("RatKing", Dagger);
            TownWindow town = new TownWindow(fighter, Sword, Bow, Dagger, FirePotion, FrostEnchant, OldMan);
            town.Show();
            Close();
        }
        private void ratkingGoBack(object sender, RoutedEventArgs e)
        {
            ratkingSelected.Visibility=Visibility.Collapsed;
        }
    }
}
