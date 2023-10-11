using Language_School.Components;
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
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            
            if (App.isAdmin == false)
            {
                AddBut.Visibility = Visibility.Collapsed;
            }
            Refresh();
        }
        private void Refresh()
        {
            IEnumerable<Service> servicesListSort = App.db.Service;
            if(SortCb.SelectedIndex  != 0)
            {
                if (SortCb.SelectedIndex == 1)
                {
                    servicesListSort = servicesListSort.OrderBy(x => x.CostDiscount);
                }
                else if (SortCb.SelectedIndex == 2)
                {
                    servicesListSort = servicesListSort.OrderByDescending(x => x.CostDiscount);
                }
            }
            ServiceWP.Children.Clear();
            foreach (var service in servicesListSort)
            {
                ServiceWP.Children.Add(new ServiceUserControl(service));
            }
        }
        
        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
