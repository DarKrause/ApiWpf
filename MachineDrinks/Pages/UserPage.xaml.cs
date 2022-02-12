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

namespace MachineDrinks.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            TbSum.Text = "0 руб.";
            LoadDrinks();
            LoadCoinsInMachine();
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
        public void LoadCoinsInMachine()
        {
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                if (coinsInMachines.ToList().Where(p=>p.Id_монета ==1).FirstOrDefault().Активный == 0)
                {
                    Btn1.IsEnabled = false;
                }
                if (coinsInMachines.ToList().Where(p => p.Id_монета == 2).FirstOrDefault().Активный == 0)
                {
                    Btn2.IsEnabled = false;
                }
                if (coinsInMachines.ToList().Where(p => p.Id_монета == 3).FirstOrDefault().Активный == 0)
                {
                    Btn5.IsEnabled = false;
                }
                if (coinsInMachines.ToList().Where(p => p.Id_монета == 4).FirstOrDefault().Активный == 0)
                {
                    Btn10.IsEnabled = false;
                }

            }
        }

        int s = 0;
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            s += 1;
            TbSum.Text = s.ToString() + " руб.";
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = coinsInMachines.Where(p=>p.id == 1).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = stroka.Количество + 1;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Активный = stroka.Активный;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                client.UploadData("http://192.168.0.102:53184/api/Монета_в_торговом_автомате/1", WebRequestMethods.Http.Put, jsonData);
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            s += 2;
            TbSum.Text = s.ToString() + " руб.";
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = coinsInMachines.Where(p => p.id == 2).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = stroka.Количество + 1;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Активный = stroka.Активный;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                client.UploadData("http://192.168.0.102:53184/api/Монета_в_торговом_автомате/2", WebRequestMethods.Http.Put, jsonData);
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            s += 5;
            TbSum.Text = s.ToString() + " руб.";
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = coinsInMachines.Where(p => p.id == 3).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = stroka.Количество + 1;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Активный = stroka.Активный;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                client.UploadData("http://192.168.0.102:53184/api/Монета_в_торговом_автомате/3", WebRequestMethods.Http.Put, jsonData);
            }
        }

        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            s += 10;
            TbSum.Text = s.ToString() + " руб.";
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = coinsInMachines.Where(p => p.id == 4).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = stroka.Количество + 1;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Активный = stroka.Активный;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                client.UploadData("http://192.168.0.102:53184/api/Монета_в_торговом_автомате/4", WebRequestMethods.Http.Put, jsonData);
            }
        }



        private void LvDrinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LvDrinks.SelectedIndex == -1)
            {
                return;
            }
            var napitok = LvDrinks.SelectedItem as Drinks;
            if (s < napitok.Стоимость)
            {
                MessageBox.Show("?");
                LvDrinks.SelectedIndex = -1;
                return;
            }
            using (WebClient client = new WebClient())
            {
                DrinksInMachine drinkInMachine = new DrinksInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Напиток_из_торгового_автомата");
                List<DrinksInMachine> drinksInMachines = JsonConvert.DeserializeObject<List<DrinksInMachine>>(data);
                var stroka = drinksInMachines.Where(p => p.Id_напиток == napitok.id).FirstOrDefault();
                drinkInMachine.id = stroka.id;
                drinkInMachine.Количество = stroka.Количество -1;
                if (drinkInMachine.Количество == -1)
                {
                    MessageBox.Show("Напиток закончился!");
                    LvDrinks.SelectedIndex = -1;
                    return;
                }
                drinkInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                drinkInMachine.Id_напиток = stroka.Id_напиток;
                var jsonText = JsonConvert.SerializeObject(drinkInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                string put = "http://192.168.0.102:53184/api/Напиток_из_торгового_автомата/" + stroka.id.ToString();
                client.UploadData(put, WebRequestMethods.Http.Put, jsonData);
            }
            s -= (int)napitok.Стоимость;
            TbSum.Text = s.ToString() + " руб.";
            LvDrinks.SelectedIndex = -1;
        }

        private void BtnSdacha_Click(object sender, RoutedEventArgs e)
        {

            int c10 = 0;
            for (int i = s; i >= 10; i = s)
            {
                c10++;
                s -= 10;
            }
            
            int c5 = 0;
            for (int i = s; i >= 5; i = s)
            {
                c5++;
                s -= 5;
            }

            int c2 = 0;
            for (int i = s; i >= 2; i = s)
            {
                c2++;
                s -= 2;
            }

            int c1 = 0;
            for (int i = s; i >= 1; i = s)
            {
                c1++;
                s -= 1;
            }
            TbSum.Text = s.ToString() + " руб.";
            Sdacha(1, c1);
            Sdacha(2, c2);
            Sdacha(3, c5);
            Sdacha(4, c10);

        }

        public void Sdacha(int id, int kol)
        {
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> CoinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = CoinsInMachines.Where(p => p.Id_монета == id).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = stroka.Количество - kol;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Активный = stroka.Активный;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                string put = "http://192.168.0.102:53184/api/Монета_в_торговом_автомате/" + id.ToString();
                client.UploadData(put, WebRequestMethods.Http.Put, jsonData);

            }
        }

    }
}
