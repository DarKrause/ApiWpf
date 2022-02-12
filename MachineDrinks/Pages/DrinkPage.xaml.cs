using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace MachineDrinks.Pages
{
    /// <summary>
    /// Логика взаимодействия для DrinkPage.xaml
    /// </summary>
    public partial class DrinkPage : Page
    {
        public DrinkPage()
        {
            InitializeComponent();
            LoadDrinks();
        }
        public void LoadDrinks()
        {
            using (WebClient client = new WebClient())
            {
                Drinks drink = new Drinks();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Напиток");
                List<Drinks> drinks = JsonConvert.DeserializeObject<List<Drinks>>(data);
                LvDrinks.ItemsSource = drinks;
            }
        }

        private void MiAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinksEdit());
        }

        private void MiEdit_Click(object sender, RoutedEventArgs e)
        {
            if (LvDrinks.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите нужную запись");
                return;
            }
            
            NavigationService.Navigate(new DrinksEdit(LvDrinks.SelectedItem as Drinks));
        }

        private void MiDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LvDrinks.SelectedIndex == -1)
            {
                MessageBox.Show("?");
                return;
            }
            var current = LvDrinks.SelectedItem as Drinks;
            DrinksInMachine stroka;
            using (WebClient client = new WebClient())
            {
                DrinksInMachine drinkInMachine = new DrinksInMachine();
                client.Encoding = Encoding.UTF8;
                var data = client.DownloadString("http://192.168.0.102:53184/api/Напиток_из_торгового_автомата");
                List<DrinksInMachine> drinksInMachines = JsonConvert.DeserializeObject<List<DrinksInMachine>>(data);
                stroka = drinksInMachines.Where(p => p.Id_напиток == current.id).FirstOrDefault();
            }
            using (HttpClient client = new HttpClient())
            {
                string uri = $"http://192.168.0.102:53184/api/Напиток_из_торгового_автомата/{stroka.id}";
                client.BaseAddress =new Uri(uri);

                var response = client.DeleteAsync(uri).Result;
                LoadDrinks();
            }
        }
    }
}
