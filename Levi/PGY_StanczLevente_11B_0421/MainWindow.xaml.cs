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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_megrendel_Click(object sender, RoutedEventArgs e)
        {
            //validálás
            bool vanHiba = false;
            if (checkcounter == 0)
            {
                MessageBox.Show("Feltétet nem választott ki! (minimum 1db)");
                vanHiba = true;
            }
            if (checkcounter > 3)
            {
                MessageBox.Show("Túl sok feltétet választott ki! (maximum 3db)");
                CHB_bacon.IsChecked = false;
                CHB_sonka.IsChecked = false;
                CHB_szalámi.IsChecked = false;
                CHB_tarja.IsChecked = false;
                CHB_kolbász.IsChecked = false;
                vanHiba = true;
            }
            if (CHB_mozarella.IsChecked == false && CHB_márványsajt.IsChecked == false )
            {
                MessageBox.Show("Sajt nélkül nem rendelhetsz pizzát!");
                vanHiba = true;
            }
            if (vanHiba == true) { 
                return; 
            }
            //validálás vége
            //beírás
            FileStream fs = new FileStream("rendelés.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            //méret
            if (RB_32.IsChecked == true)
            {
                sw.WriteLine("32cm;\n");
            }else if (RB_45.IsChecked == true)
            {
                sw.WriteLine("45cm;\n");
            }
            //méret vége
            //szósz
            if (RB_pdszósz.IsChecked == true)
            {
                sw.WriteLine("Paradicsom szósz;\n");
            }else if (RB_tejföl.IsChecked == true)
            {
                sw.WriteLine("Tejföl;\n");
            }else if (RB_chili.IsChecked == true)
            {
                sw.WriteLine("Chili;\n");
            }
            //szósz vége
            //feltét
            if (CHB_bacon.IsChecked == true)
            {
                sw.WriteLine("Bacon;\n");
            }
            if (CHB_sonka.IsChecked == true)
            {
                sw.WriteLine("Sonka;\n");
            }
            if (CHB_szalámi.IsChecked == true)
            {
                sw.WriteLine("Szalámi;\n");
            }
            if (CHB_tarja.IsChecked == true)
            {
                sw.WriteLine("Tarja;\n");
            }
            if (CHB_kolbász.IsChecked == true)
            {
                sw.WriteLine("Kolbász;\n");
            }
            //feltét vége
            //sajt
            if (CHB_mozarella.IsChecked == true)
            {
                sw.WriteLine("Mozzarella;\n");
            }
            if (CHB_márványsajt.IsChecked == true)
            {
                sw.WriteLine("Márványsajt;\n");
            }
            //sajt vége
            sw.Close();
            fs.Close();
            //beírás vége
            //kiirás
            FileStream fs2 = new FileStream("rendelés.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2, Encoding.Default);
            StringBuilder rendeles = new StringBuilder("Rendelésed a következők: \n");
            while (!sr.EndOfStream)
            {
                rendeles.Append(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
            //            if (!(checkcounter == 0) && !(checkcounter > 3) && !(CHB_mozarella.IsChecked == false && CHB_márványsajt.IsChecked == false))
            //            {
            MessageBox.Show(rendeles.ToString());
            //            }
        }

        //méret
        private void RB_32_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void RB_45_Checked(object sender, RoutedEventArgs e)
        {

        }
        //méret vége
        //szósz
        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void RB_tejföl_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void RB_chili_Checked(object sender, RoutedEventArgs e)
        {

        }
        //szósz vége
        private int checkcounter = 0;
        //feltét
        private void CHB_bacon_Checked(object sender, RoutedEventArgs e)
        {
            checkcounter++;
        }
        private void CHB_bacon_Unchecked(object sender, RoutedEventArgs e)
        {
            checkcounter--;
        }
        private void CHB_sonka_Checked(object sender, RoutedEventArgs e)
        {
            checkcounter++;
        }
        private void CHB_sonka_Unchecked(object sender, RoutedEventArgs e)
        {
            checkcounter--;
        }
        private void CHB_szalámi_Checked(object sender, RoutedEventArgs e)
        {
            checkcounter++;
        }
        private void CHB_szalámi_Unchecked(object sender, RoutedEventArgs e)
        {
            checkcounter--;
        }
        private void CHB_tarja_Checked(object sender, RoutedEventArgs e)
        {
            checkcounter++;
        }
        private void CHB_tarja_Unchecked(object sender, RoutedEventArgs e)
        {
            checkcounter--;
        }
        private void CHB_kolbász_Checked(object sender, RoutedEventArgs e)
        {
            checkcounter++;
        }
        private void CHB_kolbász_Unchecked(object sender, RoutedEventArgs e)
        {
            checkcounter--;
        }
        //feltét vége
        //sajt
        private void CHB_mozarella_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void CHB_mozarella_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }

        private void CHB_márványsajt_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void CHB_márványsajt_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }
        //sajt vége
    }
}
