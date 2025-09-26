using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Shinjuku.TicketCheckScreen.Converters
{
    public class TrainNumberToColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string trainNumber)
            {
                if (int.TryParse(trainNumber.AsSpan(0,1),out int _))
                {
                    trainNumber = "0";
                }
                return trainNumber.AsSpan(0, 1) switch
                {
                    "0" => new SolidColorBrush(Color.FromRgb(51, 102, 0)),
                    "K" => new SolidColorBrush(Color.FromRgb(204, 0, 0)),
                    "T" => new SolidColorBrush(Color.FromRgb(0, 0, 204)),
                    "Z" => new SolidColorBrush(Color.FromRgb(0, 0, 102)),
                    "C" => new SolidColorBrush(Color.FromRgb(0, 204, 204)),
                    "G" => new SolidColorBrush(Color.FromRgb(51, 51, 255)),
                    "D" => new SolidColorBrush(Color.FromRgb(0, 102, 204)),
                    _ => new SolidColorBrush(Color.FromRgb(204, 0, 102)),
                };
            }
            return new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
