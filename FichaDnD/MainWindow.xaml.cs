using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace FichaDnD
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Router(int Page)
        {
            switch (Page)
            {
                case 1:
                    Home.Visibility = Visibility.Visible;
                    Clas.Visibility = Visibility.Hidden;
                    Race.Visibility = Visibility.Hidden;
                    Itens.Visibility = Visibility.Hidden;
                    Magia.Visibility = Visibility.Hidden;
                    Sheet.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Home.Visibility = Visibility.Hidden;
                    Clas.Visibility = Visibility.Visible;
                    Race.Visibility = Visibility.Hidden;
                    Itens.Visibility = Visibility.Hidden;
                    Magia.Visibility = Visibility.Hidden;
                    Sheet.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    Home.Visibility = Visibility.Hidden;
                    Clas.Visibility = Visibility.Hidden;
                    Race.Visibility = Visibility.Visible;
                    Itens.Visibility = Visibility.Hidden;
                    Magia.Visibility = Visibility.Hidden;
                    Sheet.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    Home.Visibility = Visibility.Hidden;
                    Clas.Visibility = Visibility.Hidden;
                    Race.Visibility = Visibility.Hidden;
                    Itens.Visibility = Visibility.Visible;
                    Magia.Visibility = Visibility.Hidden;
                    Sheet.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    Home.Visibility = Visibility.Hidden;
                    Clas.Visibility = Visibility.Hidden;
                    Race.Visibility = Visibility.Hidden;
                    Itens.Visibility = Visibility.Hidden;
                    Magia.Visibility = Visibility.Visible;
                    Sheet.Visibility = Visibility.Hidden;
                    break;
                case 6:
                    Home.Visibility = Visibility.Hidden;
                    Clas.Visibility = Visibility.Hidden;
                    Race.Visibility = Visibility.Hidden;
                    Itens.Visibility = Visibility.Hidden;
                    Magia.Visibility = Visibility.Hidden;
                    Sheet.Visibility = Visibility.Visible;
                    break;
            }
        }
















        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Router(1);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Router(2);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Router(3);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Router(4);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Router(5);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Router(6);
        }
    }
}