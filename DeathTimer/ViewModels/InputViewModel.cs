using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeathTimer.ViewModels
{
    class InputViewModel : BaseViewModel
    {
       
        private string _gender;
        public string Gender { 
            get { return _gender; }
            set
            {
               _gender = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Gender");
                Console.WriteLine(Gender);

            }
            }
        private string _age;
        public string Age {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
                Console.WriteLine(Age);
            }
        }

        private string _height;        
        public string Height { get; set; }

        private string _weight;
        public string Weight { get; set; }

        private string _stress;
        public string Stress { get; set; }

        private string _calories;
        public string Calories { get; set; }

        private string _alcohol;
        public string Alcohol { get; set; }

        private string _cigarettes;
        public string Cigarettes { get; set; }

        private string _job;
        public float Job { get; set; }

        private string _activity;
        public string Activity { get; set; }

        public InputViewModel()
        {           
        }

       
    }
}
