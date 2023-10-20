using Language_School.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Language_School
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static public LSEntities2 db = new LSEntities2();
        public static bool isAdmin = false;
        //public static MainWindow MainWindow = ;
    }
}
