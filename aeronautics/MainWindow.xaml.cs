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
using System.IO;

namespace aeronautics
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //StreamReader
        FileStream fs = null;
        Player player;


        public MainWindow()
        {
            
            InitializeComponent();

            player = new Player();

            //Debug.Text = "Starting from Here";


            // should try catch
            // stream reader
            // final stream

            
            
                Debug.Text = "Starting from Here";
            
            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            

            Button b = (Button)(sender);

            player.HashTableAdd(player.HashTableGetCount(), (string)b.Tag);


            string s = "";

            // prints out the stored text from the play's hashTable
            for (int i = 0; i < player.HashTableGetCount(); i++)
            {
                s += (player.HashTableGetText(i) + ", ");
            }


            Debug.Text = s;


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


            image1.Source = new BitmapImage(new Uri(@"pack://application:,,,/aeronautics;component/Images/Chrysanthemum.jpg"));
            Debug.Text = "Image Clicked.";
        }
    }
}
