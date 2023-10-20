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
    public partial class AddEditProductPage : Page
    {
        private Service service;
        public AddEditProductPage(Service _service)
        {
            InitializeComponent();
            service = _service;
            this.DataContext = service;
        }
    }
}
