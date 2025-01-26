using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AmericaSports
{  
    public class AmericaSportsViewModel
    {
        public List<AmericaSportsModel> SportsData { get; set; }

        public ObservableCollection<Brush> PaletteBrushes { get; set; }

        public AmericaSportsViewModel()
        {
            PaletteBrushes = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#FF5733")), // Vibrant Red
                new SolidColorBrush(Color.FromArgb("#33FF57")), // Bright Green
                new SolidColorBrush(Color.FromArgb("#3357FF")), // Bright Blue
                new SolidColorBrush(Color.FromArgb("#FF33A6")), // Hot Pink
                new SolidColorBrush(Color.FromArgb("#33FFA5")), // Aquamarine
                new SolidColorBrush(Color.FromArgb("#FFA533")), // Golden Orange
                new SolidColorBrush(Color.FromArgb("#A533FF")), // Vivid Purple
                new SolidColorBrush(Color.FromArgb("#FF5733")), // Vibrant Red
                new SolidColorBrush(Color.FromArgb("#FFC300")), // Bright Yellow
                new SolidColorBrush(Color.FromArgb("#DAF7A6")), // Light Green 
            };
            SportsData = new List<AmericaSportsModel>();

            SportsData.Add(new AmericaSportsModel("Wrestling", 11, "lifting.png", Color.FromArgb("#FF5733")));
            SportsData.Add(new AmericaSportsModel("Motorsports", 15, "racingcar.png", Color.FromArgb("#33FF57")));
            SportsData.Add(new AmericaSportsModel("Tennis", 21.64, "tennis.png", Color.FromArgb("#3357FF")));
            SportsData.Add(new AmericaSportsModel("Golf", 25, "golf.png", Color.FromArgb("#FF33A6")));
            SportsData.Add(new AmericaSportsModel("Boxing", 55.6, "boxinggloves.png", Color.FromArgb("#33FFA5")));
            SportsData.Add(new AmericaSportsModel("Ice Hockey", 73.5, "hockeystick.png", Color.FromArgb("#FFA533")));
            SportsData.Add(new AmericaSportsModel("Soccer", 97.4, "soccerplayer.png", Color.FromArgb("#A533FF")));
            SportsData.Add(new AmericaSportsModel("Baseball", 113.3, "baseball.png", Color.FromArgb("#FF5733")));
            SportsData.Add(new AmericaSportsModel("Basketball", 121.2, "basketball.png", Color.FromArgb("#FFC300")));
            SportsData.Add(new AmericaSportsModel("American Football", 139, "americanfootball.png", Color.FromArgb("#DAF7A6"))); 
        }
    }

}
