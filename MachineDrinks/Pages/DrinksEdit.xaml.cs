using MachineDrinks.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using Image = System.Drawing.Image;

namespace MachineDrinks.Pages
{
    /// <summary>
    /// Логика взаимодействия для DrinksEdit.xaml
    /// </summary>
    public partial class DrinksEdit : Page
    {
        public DrinksEdit()
        {
            InitializeComponent();
            s = 1;
        }
        public DrinksEdit(Drinks drink)
        {
            InitializeComponent();
            s = 0;
            this.drink = drink;
            this.drinks1 = drink;
            SpEdit.DataContext = drinks1;
            TbCostDrink.Text = drink.Стоимость.ToString();
            TbNameDrink.Text = drink.Название;
            //using (var ms = new MemoryStream(drink.Фото))
            //{
            //    var image = new BitmapImage();
            //    ms.Position = 0;
            //    image.BeginInit();
            //    image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
            //    image.CacheOption = BitmapCacheOption.OnLoad;
            //    image.UriSource = null;
            //    image.StreamSource = ms;
            //    image.EndInit();
            //    image.Freeze();
            //    ImgDrink.Source = image;
            //}
            foto.Фото = drink.Фото;
        }
        public int s=0;
        Drinks drink = new Drinks();
        Drinks foto = new Drinks();
        Drinks drinks1 { get;set;}
        
        private void TbCostDrink_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            short value;
            if (!Int16.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TbNameDrink.Text == "" || TbCostDrink.Text == "" || TbCountDrink.Text == "")
            {
                MessageBox.Show("Заполните все данные");
                return;
            }
            if (s == 0)
            {
                using (WebClient client = new WebClient())
                {
                    Drinks drinks = new Drinks();
                    client.Encoding = Encoding.UTF8;
                    string data = client.DownloadString("http://192.168.0.102:53184/api/Напиток");
                    drinks.id = drink.id;
                    drinks.Название = TbNameDrink.Text;
                    drinks.Стоимость = Convert.ToDecimal(TbCostDrink.Text);
                    drinks.Фото = foto.Фото;
                    var jsonText = JsonConvert.SerializeObject(drinks);
                    var jsonData = Encoding.UTF8.GetBytes(jsonText);
                    client.Headers.Add("Content-Type", "application/json");
                    string put = "http://192.168.0.102:53184/api/Напиток/" + drink.id.ToString();
                    client.UploadData(put, WebRequestMethods.Http.Put, jsonData);

                    DrinksInMachine drinkInMachine = new DrinksInMachine();
                    data = client.DownloadString("http://192.168.0.102:53184/api/Напиток_из_торгового_автомата");
                    List<DrinksInMachine> drinksInMachines = JsonConvert.DeserializeObject<List<DrinksInMachine>>(data);
                    var stroka = drinksInMachines.Where(p => p.Id_напиток == drink.id).FirstOrDefault();
                    drinkInMachine.id = stroka.id;
                    drinkInMachine.Количество = Convert.ToInt32(TbCountDrink.Text);
                    drinkInMachine.Id_торговый_автомат = stroka.Id_торговый_автомат;
                    drinkInMachine.Id_напиток = stroka.Id_напиток;
                    jsonText = JsonConvert.SerializeObject(drinkInMachine);
                    jsonData = Encoding.UTF8.GetBytes(jsonText);
                    client.Headers.Add("Content-Type", "application/json");
                    put = "http://192.168.0.102:53184/api/Напиток_из_торгового_автомата/" + stroka.id.ToString();
                    client.UploadData(put, WebRequestMethods.Http.Put, jsonData);
                }
            }
            else
            {
                using (WebClient client = new WebClient())
                {
                    Drinks drinks = new Drinks();
                    client.Encoding = Encoding.UTF8;
                    drinks.Название = TbNameDrink.Text;
                    drinks.Стоимость = Convert.ToDecimal(TbCostDrink.Text);
                    drinks.Фото = foto.Фото;
                    var jsonText = JsonConvert.SerializeObject(drinks);
                    var jsonData = Encoding.UTF8.GetBytes(jsonText);
                    client.Headers.Add("Content-Type", "application/json");
                    string put = "http://192.168.0.102:53184/api/Напиток";
                    client.UploadData(put, WebRequestMethods.Http.Post, jsonData);

                    DrinksInMachine drinkInMachine = new DrinksInMachine();
                    string data = client.DownloadString("http://192.168.0.102:53184/api/Напиток");
                    List<Drinks> drinksInMachines = JsonConvert.DeserializeObject<List<Drinks>>(data);
                    int stroka = (int)drinksInMachines.Last().id;
                    drinkInMachine.Количество = Convert.ToInt32(TbCountDrink.Text);
                    drinkInMachine.Id_торговый_автомат = 1;
                    drinkInMachine.Id_напиток = stroka;
                    jsonText = JsonConvert.SerializeObject(drinkInMachine);
                    jsonData = Encoding.UTF8.GetBytes(jsonText);
                    client.Headers.Add("Content-Type", "application/json");
                    put = "http://192.168.0.102:53184/api/Напиток_из_торгового_автомата";
                    client.UploadData(put, WebRequestMethods.Http.Post, jsonData);
                }
            }
            NavigationService.Navigate(new DrinkPage());
        }

        private void BtnImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog pfd = new OpenFileDialog();
            pfd.Filter = "Image files(*.jpg)|*.jpg|Image Files(*.jpeg)|*.jpeg";
            if (pfd.ShowDialog() == false)
            {
                return;
            }
            ImgDrink.Source = new BitmapImage(new Uri(pfd.FileName));
            ImageConverter imageConverter = new ImageConverter();
            Image image = Image.FromFile(pfd.FileName);

            foto.Фото = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
        }
    }
}
