using System;
using System.Linq;
using Windows.UI.Xaml.Data;
using FChart;

namespace UWP.CartesianChart.Energy_Predictions
{
    public class ReverseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((SeriesCollection)value).Reverse();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}