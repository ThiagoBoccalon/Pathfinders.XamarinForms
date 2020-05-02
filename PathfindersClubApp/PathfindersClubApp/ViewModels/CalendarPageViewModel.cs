using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PathfindersClubApp.ViewModels
{
    public class CalendarPageViewModel : BindableBase
    {
        public CalendarPageViewModel()
        {

        }

        private Color _consoleColor;
        public Color ColorBackground
        {
            get { return _consoleColor; }
            set
            {
                _consoleColor = RandomColorBackground();
            }
        }

        private Color RandomColorBackground()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));            
        }
    }
}
