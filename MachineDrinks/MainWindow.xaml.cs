using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using MachineDrinks.Models;
using Newtonsoft.Json;
using MachineDrinks.Pages;

namespace MachineDrinks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrm.Navigate(new MainPage());
            //load();
            
        }
        //public void load()
        //{
        //    using (WebClient client = new WebClient())
        //    {
        //        Coins coin = new Coins();
        //        client.Encoding = Encoding.UTF8;
        //        string data = client.DownloadString("http://192.168.0.103:53184/api/Монета");
        //        List<Coins> coins = JsonConvert.DeserializeObject<List<Coins>>(data);
        //        DgCoins.ItemsSource = coins;
        //    }
        //}
    }
}
