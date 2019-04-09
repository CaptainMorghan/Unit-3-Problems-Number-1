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

namespace Unit_Three_problems._1_Take_Info_from_internet_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //global variables
        


        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
       
            if ((bool)rb2017Sales.IsChecked)
            {
                System.Net.WebClient webClient = new System.Net.WebClient();
                webClient.BaseAddress = "https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt";

                System.IO.StreamReader streamReader = new System.IO.StreamReader(webClient.OpenRead("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt"));
                while (!streamReader.EndOfStream)
                {
                  streamReader.ReadLine();
                }
             
            }
        }
        
            


                
    }
}
