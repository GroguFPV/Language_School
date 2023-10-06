using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Language_School.Components
{
    public partial class Service
    {
        public string costTimeStr
        {
            get
            {
                if (Discount == 0)
                {
                    return $"{Cost} рублей за {DurationInSeconds / 60} минут";
                }
                else
                {
                    return $" {Cost - (Cost * (decimal) Discount / 100):0} рублей за {DurationInSeconds / 60} минут";
                }
            }
           
        }
        public Visibility GetVisibility
        {
            get
            {
                if (Discount == 0)
                {
                    return Visibility.Collapsed;
                }
            
                else{
                    return Visibility.Visible;
                }
            }
        }
        public string DiscountStr
        {
            get
            {
                if (Discount == 0){
                    return "";
                }
                else
                {
                    return $"*скидка {Discount}%";
                }
            }
        }
    }
}
