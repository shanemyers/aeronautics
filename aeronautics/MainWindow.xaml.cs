using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aeronautics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Player player;
        

        public MainWindow()
        {
            InitializeComponent();

            player = new Player();

            Debug.Text = "Starting from Here";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)(sender);

            // Get Path
            string s = "";

            // prints out the stored text from the play's hashTable

            

            for (int i = 0; i < player.HashTableGetCount(); i++)
            {
                s += (player.HashTableGetText(i));
            }
            


            // Route #1 :: A, B, A, C, B, D

            // Test Path Logic
            switch(s)
            {
                // room 1
                case "":
                    if ((string)b.Tag == "A" && player.inventoryObjectCount() > 0 && player.checkInventoryObject(0) == 98)
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Chrysanthemum.jpg"));
                        button1.Margin = new Thickness(40, 40, 0, 0);
                        button2.Margin = new Thickness(80, 80, 0, 0);
                        button3.Margin = new Thickness(120, 120, 0, 0);
                        button4.Margin = new Thickness(160, 160, 0, 0);
                        button5.Margin = new Thickness(200, 200, 0, 0);

                        player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);

                        Debug.Text = "Moving on!";
                    }
                    else if ((string)b.Tag == "A")
                    {
                        Debug.Text = "You need a key";
                    }


                    if ((string)b.Tag == "B")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "C")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "D")
                    {
                        Debug.Text = "You found a KEY";

                        InventoryObject inv = new InventoryObject();
                        inv.SetObjectID(98);

                        player.newInventoryObject(inv);
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;

                // room 2
                case "A":
                    if ((string)b.Tag == "B")
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Jellyfish.jpg"));
                        button1.Margin = new Thickness(200, 200, 0, 0);
                        button2.Margin = new Thickness(240, 160, 0, 0);
                        button3.Margin = new Thickness(280, 120, 0, 0);
                        button4.Margin = new Thickness(320, 80, 0, 0);
                        button5.Margin = new Thickness(360, 40, 0, 0);

                        player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);

                        Debug.Text = "Moving on!";
                    }
                    if ((string)b.Tag == "A")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "C")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "D")
                    {
                        Debug.Text = "Yes that could be interesting....";
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;


                // room 3
                case "AB":
                    if ((string)b.Tag == "A")
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Chrysanthemum.jpg"));
                        button1.Margin = new Thickness(40, 40, 0, 0);
                        button2.Margin = new Thickness(120, 40, 0, 0);
                        button3.Margin = new Thickness(200, 40, 0, 0);
                        button4.Margin = new Thickness(280, 40, 0, 0);
                        button5.Margin = new Thickness(360, 40, 0, 0);

                        player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);
                        Debug.Text = "Moving on!";
                    }
                    if ((string)b.Tag == "B")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "C")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "D")
                    {
                        Debug.Text = "Yes that could be interesting....";
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;

                // room 4
                case "ABA":
                    if ((string)b.Tag == "C")
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Jellyfish.jpg"));
                        button1.Margin = new Thickness(40, 40, 0, 0);
                        button2.Margin = new Thickness(40, 80, 0, 0);
                        button3.Margin = new Thickness(40, 120, 0, 0);
                        button4.Margin = new Thickness(40, 160, 0, 0);
                        button5.Margin = new Thickness(40, 200, 0, 0);

                        player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);
                        Debug.Text = "Moving on!";
                    }
                    if ((string)b.Tag == "A")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "B")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "D")
                    {
                        Debug.Text = "Yes that could be interesting....";
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;

                // room 5
                case "ABAC":
                    if ((string)b.Tag == "B")
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Chrysanthemum.jpg"));
                        button1.Margin = new Thickness(40, 200, 0, 0);
                        button2.Margin = new Thickness(120, 200, 0, 0);
                        button3.Margin = new Thickness(200, 200, 0, 0);
                        button4.Margin = new Thickness(280, 200, 0, 0);
                        button5.Margin = new Thickness(340, 200, 0, 0);

                        player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);
                        Debug.Text = "Moving on!";
                    }
                    if ((string)b.Tag == "A")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "C")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "D")
                    {
                        Debug.Text = "Yes that could be interesting....";
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;

                // room 5
                case "ABACB":
                    if ((string)b.Tag == "D")
                    {
                        image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Jellyfish.jpg"));
                        button1.Margin = new Thickness(61, 91, 0, 0);
                        button2.Margin = new Thickness(120, 173, 0, 0);
                        button3.Margin = new Thickness(209, 126, 0, 0);
                        button4.Margin = new Thickness(326, 91, 0, 0);
                        button5.Margin = new Thickness(362, 155, 0, 0);

                        player.HashTableClear();
                        player.removeInventoryAll();

                        Debug.Text = "Game Start";
                        // win screen
                    }
                    if ((string)b.Tag == "A")
                    {
                        Debug.Text = "Where were you clicking?";
                    }
                    if ((string)b.Tag == "C")
                    {
                        Debug.Text = "If only that did something.";
                    }
                    if ((string)b.Tag == "B")
                    {
                        Debug.Text = "Yes that could be interesting....";
                    }
                    if ((string)b.Tag == "E")
                    {
                        Debug.Text = "Are... are you confused?";
                    }
                    break;

            }

            /*
            Button b = (Button)(sender);

            if ((string)b.Tag == "A")
            {
                image1.Width += 40;
            }

            // this will result in the game shifting screen, throwing up text
            // or adding to the player's inventory.


            Button b = (Button)(sender);

            if ((string)b.Tag == "A")
            {
                image1.Width += 40;
            }
            */



            //player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);


            

            /*

            Debug.Text = s;

            if (s == "ABC")
            {
                Debug.Text = "LOL";
            }
           */


            //Debug.Text = player.HashTableGetCount().ToString();   // able to add to the player's hashtable correctly
            //Debug.Text = (string)b.Tag;                           // able to get the sender's tage successfully
            //Debug.Text = "choice Clicked";                        // able to successfully click all buttons with the same function running each time
        }

        private void Debug_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Choice Clicked");
        }

        private void image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // verifies that the image can be clicked and trigger a function
            //image1.Visibility = Visibility.Hidden;


            //image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Chrysanthemum.jpg"));
            Debug.Text = "Image Clicked.";
        }
    }
}
