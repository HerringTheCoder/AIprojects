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
        public string Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
                Console.WriteLine(Height);
            }
        }

        private string _weight;
        public string Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
                Console.WriteLine(Weight);
            }
        }

        private string _stress;
        public string Stress
        {
            get { return _stress; }
            set
            {
                _stress = value;
                OnPropertyChanged("Stress");
                Console.WriteLine(Stress);
            }
        }
        private string _calories;
        public string Calories
        {
            get { return _calories; }
            set
            {
                _calories = value;
                OnPropertyChanged("Calories");
                Console.WriteLine(Calories);
            }
        }

        private string _alcohol;
        public string Alcohol
        {
            get { return _alcohol; }
            set
            {
                _alcohol = value;
                OnPropertyChanged("Alcohol");
                Console.WriteLine(Alcohol);
            }
        }

        private string _cigarettes;
        public string Cigarettes
        {
            get { return _cigarettes; }
            set
            {
                _cigarettes = value;
                OnPropertyChanged("Cigarettes");
                Console.WriteLine(Cigarettes);
            }
        }

        private string _job;
        public string Job
        {
            get { return _job; }
            set
            {
                _job = value;
                OnPropertyChanged("Job");
                Console.WriteLine(Job);
            }
        }

        private string _activity;
        public string Activity
        {
            get { return _activity; }
            set
            {
                _activity = value;
                OnPropertyChanged("Activity");
                Console.WriteLine(Activity);
            }
        }

        public InputViewModel()
        {           
        }

       
    }
}
