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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public string url = string.Empty;
        ClassSearch weath;
        public MainWindow()
        {
            InitializeComponent();
            weath = new ClassSearch();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            url += "http://api.openweathermap.org/data/2.5/weather?q=";
            url += CityName.Text.ToString();
            url += "&appid=ecc0ea77210f8032ef8804a80a9f40f0&units=metric";

            weath.ChangeRequest(url); 
            weath.Search();
            weath.MessageShow();
            url = string.Empty;
        }
    }
}
