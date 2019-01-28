using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ScheduleSample
{
    /// <summary>
    /// Represents image format converter.
    /// </summary>
    public class ImageFormatConverter : IValueConverter
    {
        /// <summary>
        /// Convert method
        /// </summary>
        /// <param name="value">return the object</param>
        /// <param name="targetType">return the target type value</param>
        /// <param name="parameter">return the object</param>
        /// <param name="culture">return the culture value</param>
        /// <returns>return the value</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return value.ToString() + ".png";            
            return value;
        }

        /// <summary>
        /// Convert back method 
        /// </summary>
        /// <param name="value">return the object</param>
        /// <param name="targetType"> return the target type value</param>
        /// <param name="parameter">return the object</param>
        /// <param name="culture">return the culture value</param>
        /// <returns>return the value</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
