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

namespace Lazzat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> WebPages;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void svernut_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Myweb.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Myweb.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Myweb.Refresh();
        }

  
    }
        /* private void Application_NavigationFailed(object sender,
System.Windows.Navigation.NavigationFailedEventArgs e)
{
if (e.Exception is System.Net.WebException)
{
MessageBox.Show("Сайт " + e.Uri.ToString() + " не доступен :(");
// Нейтрализовать ошибку, чтобы приложение продолжило свою работу
e.Handled = true;
}
}*/


    
}
