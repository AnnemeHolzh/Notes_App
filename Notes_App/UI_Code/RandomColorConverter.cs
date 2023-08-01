using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Notes_App.UI_Code
{
    public class RandomColorConverter : IValueConverter
    {
        private int colorIndex = 0;
        private readonly List<string> hoverColors = new List<string>
        {
            "#D53302", // Oraney
            "#FDC261", // Yellow
            "#A0CAAC", // Mint
            "#8EB1BC", // Pastel Blue 
            "#00002B"  // Dark Blue 
            // Add more hex codes of colors as needed
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isMouseOver && isMouseOver)
            {
                // Get the next hex code from the list
                string hexCode = hoverColors[colorIndex];
                colorIndex = (colorIndex + 1) % hoverColors.Count; // Increment the index and wrap around

                // Convert the hex code to a SolidColorBrush
                var brush = (SolidColorBrush)new BrushConverter().ConvertFrom(hexCode);
                return brush;
            }

            // Return the default color if not hovered
            return new SolidColorBrush(Color.FromRgb(238, 238, 238));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
