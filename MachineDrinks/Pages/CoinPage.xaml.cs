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
    /// Логика взаимодействия для CoinPage.xaml
    /// </summary>
    public partial class CoinPage : Page
    {
        public CoinPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            int active = 0;
            int kol = 0;
            if (Cb1.IsChecked == true)
            {
                active = 1;
            }
            else active = 0;
            kol = Convert.ToInt32(Tb1.Text);
            kekw(1, kol, active);

            if (Cb2.IsChecked == true)
            {
                active = 1;
            }
            else active = 0;
            kol = Convert.ToInt32(Tb2.Text);
            kekw(2, kol, active);

            if (Cb5.IsChecked == true)
            {
                active = 1;
            }
            else active = 0;
            kol = Convert.ToInt32(Tb5.Text);
            kekw(3, kol, active);

            if (Cb10.IsChecked == true)
            {
                active = 1;
            }
            else active = 0;
            kol = Convert.ToInt32(Tb10.Text);
            kekw(4, kol, active);
        }

        private void Tb1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            short value;
            if (!Int16.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }
        public void kekw(int id, int count, int active)
        {
            using (WebClient client = new WebClient())
            {
                CoinsInMachine coinInMachine = new CoinsInMachine();
                client.Encoding = Encoding.UTF8;
                string data = client.DownloadString("http://192.168.0.102:53184/api/Монета_в_торговом_автомате");
                List<CoinsInMachine> coinsInMachines = JsonConvert.DeserializeObject<List<CoinsInMachine>>(data);
                var stroka = coinsInMachines.Where(p => p.id == id).FirstOrDefault();
                coinInMachine.id = stroka.id;
                coinInMachine.Количество = count;
                coinInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                coinInMachine.Id_монета = stroka.Id_монета;
                coinInMachine.Активный = active;
                var jsonText = JsonConvert.SerializeObject(coinInMachine);
                var jsonData = Encoding.UTF8.GetBytes(jsonText);
                client.Headers.Add("Content-Type", "application/json");
                client.UploadData("http://192.168.0.102:53184/api/Монета_в_торговом_автомате/" + id.ToString(), WebRequestMethods.Http.Put, jsonData);
            }
        }
    }
}
