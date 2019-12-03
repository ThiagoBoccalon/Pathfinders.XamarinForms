using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PathfindersClubApp.Models
{
    public class Unit
    {        
        public string Name { get; set; }
        public string Image { get; set; }
        public string BackgroundColor { get; set; }
        public StackLayout AnthemUnity { get; set; }
        public Conselheiro Conselheiro { get; set; }
    }
}
