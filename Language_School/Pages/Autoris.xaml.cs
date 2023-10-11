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

namespace Language_School.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autoris.xaml
    /// </summary>
    public partial class Autoris : Page
    {
        public Autoris()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordTb.Password == "0000")
            {
                App.isAdmin = true;
            }

            NavigationService.Navigate(new ListPage());
        }
    }
}
