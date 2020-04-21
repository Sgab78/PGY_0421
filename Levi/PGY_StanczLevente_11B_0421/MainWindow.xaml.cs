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
        }

        private int checkcounter = 0;

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


        private void CHB_bacon_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CHB_sonka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CHB_szalámi_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CHB_tarja_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CHB_kolbász_Checked(object sender, RoutedEventArgs e)
        {

        }

        ////////
    }
}
