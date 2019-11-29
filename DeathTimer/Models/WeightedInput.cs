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
        public float Gender { get; set; }
        public float Age { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Stress { get; set; }
        public float Calories { get; set; }
        public float Alcohol { get; set; }
        public float Cigarettes { get; set; }
        public float Job { get; set; }     
        public float Activity { get; set; }
    }
}
