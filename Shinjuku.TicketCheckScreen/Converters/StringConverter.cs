using OpenCCNET;
using System.Globalization;
using System.Windows.Data;

namespace Shinjuku.TicketCheckScreen.Converters
{
    public class StringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string strValue)
            {

                return ZhConverter.ToHantFromHans(strValue);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
