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
    /// Interaction logic for TownWindow.xaml
    /// </summary>
    public partial class TownWindow : Window
    {
        Item FirePotion = new Item("FirePotion");
        Item FrostEnchant = new Item("FrostEnchant");
        Item OldMan = new Item("OldMan");
        Item Sword;
        Item Bow;
        Item Dagger;
        private Fighters fighter;
        public TownWindow(Fighters fighter,Item Sword, Item Bow,Item Dagger, Item FirePotion, Item FrostEnchant, Item OldMan)
        {
            InitializeComponent();
            this.fighter = fighter;
            this.FirePotion = FirePotion;
            this.FrostEnchant = FrostEnchant;
            this.OldMan = OldMan;
            this.Sword = Sword;
            this.Bow = Bow;
            this.Dagger = Dagger;
            ResizeMode = ResizeMode.NoResize;
        }
        private void HandleUserAction(MouseButtonEventHandler action)
        {
            action?.Invoke(this, new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left));
        }
        private void townwindow_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.Key)
            {
                case Key.D1:
                    HandleUserAction(Alchemist_click);
                    break;
                case Key.D2:
                    HandleUserAction(Enchanter_Click);
                    break;
                case Key.D3:
                    HandleUserAction(Localinn_Click);
                    break;
                case Key.D4:
                    HandleUserAction(FindDragon_Click);
                    break;
                case Key.D5:
                    HandleUserAction(RunAway_Click);
                    break;
            }
        }
        private void Alchemist_click(object sender, RoutedEventArgs e)
        {
            Location alchemist = new Location("Alchemist", FirePotion);
            Fighters fighter = this.fighter;
            AlchemistLocation alchemistLocation = new AlchemistLocation(fighter, alchemist);
            alchemistLocation.Show();
        }
        private void Enchanter_Click(object sender, RoutedEventArgs e)
        {
            Location enchanter = new Location("Enchanter", FrostEnchant);
            Fighters fighter = this.fighter;
            EnchanterLocation enchanterLocation = new EnchanterLocation(fighter, enchanter);
            enchanterLocation.Show();
        }
        private void Localinn_Click(object sender, RoutedEventArgs e)
        {
            Location localInn = new Location("LocalInn", OldMan);
            Fighters fighter = this.fighter;
            LocalinnLocation localInnLocation = new LocalinnLocation(fighter, localInn);
            localInnLocation.Show();

        }
        private void FindDragon_Click(object sender, RoutedEventArgs e)
        {
            if(fighter.GetItems().Contains(FirePotion) && fighter.GetItems().Contains(FrostEnchant) && fighter.GetItems().Contains(OldMan))
            {
                DragonLocation dragonLocation = new DragonLocation();
                dragonLocation.Show();
            }
            else
            {
                MessageBox.Show("You dont have the required items yet!");
            }
        }
        private void RunAway_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dont be a coward now!");
        }
    }
}
