using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfWeatherApi.ClassBiz;
using WpfWeatherApi.Entities;

namespace WpfWeatherApi.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        BizClass biz = new BizClass(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            WeatherData weatherData = new WeatherData();

            weatherData.City = CitynameTxtBox.Text;

            if (CitynameTxtBox.Text != "")
            {
                ShowTempLbl.Content = biz.GetTempatureBasedOnCity(CitynameTxtBox.Text);
                if (ShowTempLbl.Content == "N/A")
                {
                    MessageLbl.Content = "Byen ser ikke ud til at findes, check navnet og prøv igen";
                }
            }
            else
            {
                MessageLbl.Content = "Indtast et by navn i text boksen";
            }
                     
        }
    }
}
