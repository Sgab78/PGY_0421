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
using System.IO;

namespace PGY_StanczLevente_11B_0421
{

    public partial class MainWindow : Window
    {
        private int cbCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_megrendel_Click(object sender, RoutedEventArgs e)
        {

            // Kiíratás
            FileStream fs = new FileStream("rendelés.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            //méret
            if (RB_32.IsChecked == true)
            {
                sw.WriteLine("32cm;");
            }else if (RB_45.IsChecked == true)
            {
                sw.WriteLine("45cm;");
            }
            //szósz
            if (RB_pdszósz.IsChecked == true)
            {
                sw.WriteLine("Paradicsom szósz;");
            }else if (RB_tejföl.IsChecked == true)
            {
                sw.WriteLine("Tejföl;");
            }else if (RB_chili.IsChecked == true)
            {
                sw.WriteLine("Chili;");
            }

            sw.Close();
            fs.Close();
            // Kiíratás vége
        }

        /////////
        private void RB_32_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RB_45_Checked(object sender, RoutedEventArgs e)
        {

        }

        //////////////

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RB_tejföl_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RB_chili_Checked(object sender, RoutedEventArgs e)
        {

        }
        ////////////////

        private void CB_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            
            if (cb.IsChecked == true) { cbCounter++; } 
            else { cbCounter--; }
            
            if (cbCounter > 3)
            {
                MessageBox.Show("Max 3 feltét választható !!!");
                cb.IsChecked = false;
            }
        }

        ////////
    }
}
