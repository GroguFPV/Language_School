﻿using Language_School.Pages;
using System;
using System.Collections.Generic;
using System.IO;
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


namespace Language_School.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        private Service service;
        public ServiceUserControl(Service _service)
        {    
            InitializeComponent();
            service = _service;
            if (App.isAdmin == false)
            {
                EditBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            TitleTb.Text = service.Title;
            CostTb.Text = service.Cost.ToString("N0");
            CostTimeTb.Text = service.costTimeStr;
            DiscountTb.Text = service.DiscountStr;
            CostTb.Visibility = service.GetVisibility;
            MainBorder.Background = service.ColorDiscount;
            ImageImg.Source = GetImageSources(service.MainImage);

        }
        private BitmapImage GetImageSources(byte[] byteImage)
        {
            if (byteImage != null)
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                return image;
            }
                return new BitmapImage(new Uri(@"\res\school_logo.png", UriKind.Relative));
        }
            private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PageComponent("Редактирование услуги", new AddEditProductPage(service)));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(service.ClientService.Count !=0)
            {
                MessageBox.Show("Удаление запрещено!");
            }
            else
            {
                MessageBox.Show("Удалено: " +  service.Title);

                App.db.Service.Remove(service); 
                App.db.SaveChanges();
                Navigation.NextPage(new PageComponent("Список услуг", new ListPage()));
            }
        }
    }
}
