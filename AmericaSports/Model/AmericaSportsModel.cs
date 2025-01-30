using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericaSports 
{ 
    public class AmericaSportsModel
    {
        public String Name { get; set; }
        public double Value { get; set; }
        public Color Color1 { get; set; }
        public string ImageName { get; set; }
        public AmericaSportsModel(string name, double value, string imageName, Color color)
        {
            Name = name;
            Value = value;
            Color1 = color;
            ImageName = imageName;
        }
    }

}
