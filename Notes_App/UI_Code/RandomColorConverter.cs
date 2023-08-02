//-----------00000000000ooooooooooo..........Start Of File...........ooooooooooo00000000000-----------//
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
        //------------------------------------------Creating a list to store the colour values of the button------------------------------------------//
        private int colorIndex = 0;
        /// <summary>
        /// The variable that makes iterating through the given colours possible. 
        /// </summary>
        private readonly List<string> hoverColors = new List<string>
        {
            "#D53302", // Oraney
            "#FDC261", // Yellow
            "#A0CAAC", // Mint
            "#8EB1BC", // Pastel Blue 
            "#00002B"  // Dark Blue 
            // Add more hex codes of colors as needed
        };
        //------------------------------------------Convert Method------------------------------------------//
        /// <summary>
        /// This method iterates through the given colours randomly, converts the hex code from the colours to a SolidColourBrush and returns the randomized colour on the button. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isMouseOver && isMouseOver) //This checks whether the mouse is hovering over the button or not. 
            {
                // Get the next hex code from the list
                string hexCode = hoverColors[colorIndex];
                colorIndex = (colorIndex + 1) % hoverColors.Count; // Increment the index and wrap around

                // Convert the hex code to a SolidColorBrush
                var brush = (SolidColorBrush)new BrushConverter().ConvertFrom(hexCode);
                return brush; //Displays the colour on the button
            }

            // Return the default color if not hovered
            return new SolidColorBrush(Color.FromRgb(238, 238, 238));
        }
        //------------------------------------------Convert Back Method------------------------------------------//
        /// <summary>
        /// This method converts the button colour back to the default colour when the user stops hovernig over the button. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
//-----------00000000000ooooooooooo..........End Of File...........ooooooooooo00000000000-----------//