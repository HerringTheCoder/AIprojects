using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathTimer
{
    //This class contains weighted values of input parameters in application
    class WeightedInput
    {
        public int Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Stress { get; set; }
        public int Calories { get; set; }
        public int Alcohol { get; set; }
        public int Cigarettes { get; set; }
        public int Job { get; set; }     
        public int Activity { get; set; }
    }
}
