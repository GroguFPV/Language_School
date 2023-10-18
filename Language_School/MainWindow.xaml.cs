using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using Language_School.Pages;

namespace Language_School
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var path = @"C:\Users\Admin\Desktop\Task\Сессия 1\services_s_import\";
            foreach (var item in App.db.Service.ToArray())
            {
                var fullPath = path + item.MainImagePath;
                item.MainImage = File.ReadAllBytes(fullPath);
            }
            App.db.SaveChanges();

            MainFrame.Navigate(new Autoris());
        }

        private void BackBut_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) {
                MainFrame.GoBack(); 
                MainFrame.RemoveBackEntry();
            }

        }
        

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            App.isAdmin = false;
            MainFrame.Navigate(new Autoris());  
        }
    }
}
