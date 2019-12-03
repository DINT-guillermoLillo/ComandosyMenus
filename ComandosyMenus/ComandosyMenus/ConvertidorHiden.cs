using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ComandosyMenus
{
    class ConvertidorHiden : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "Visible";
            else
                return "Collapsed";
        }   

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((String)value == "Visible")
                return true;
            else
                return false;
        }
    }
}
