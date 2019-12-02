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
        public Converter MyConverter = new Converter();

        private double _output;
        public double Output
        {
            get { return _output; }
            set
            {
                _output = value;
                OnPropertyChanged("Output");
                Console.WriteLine("Output is equal {0}", value);
            }
        }

        private int _outputLeft;
       public int OutputLeft
        {
            get { return _outputLeft; }
            set {
                _outputLeft = value;
                OnPropertyChanged("OutputLeft");
                Console.WriteLine("Time left: {0}", value);
            }
        }


        private string _gender;
        public string Gender { 
            get { return _gender; }
            set
            {
               _gender = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Gender");
                Console.WriteLine("Gender is equal {0}",value);
                MyConverter.ConvertGender(value);
                Refresh();
            }
            }
        private string _age = "18";
        public string Age
        {
            get { return _age; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Any(x => char.IsLetter(x)))
                {
                    value = "18";
                }
                _age = value;
                OnPropertyChanged("Age");
                Console.WriteLine("Age is equal {0}", value);
                Refresh();
            }
        }

        private string _height = "170";        
        public string Height
        {
            get { return _height; }
            set
            {
                if ( string.IsNullOrEmpty(value) || value.Any(x => char.IsLetter(x)) )
                {
                    value = "1";
                }
                _height = value;                
                OnPropertyChanged("Height");
                Console.WriteLine("Height is equal {0}", value);
                MyConverter.ConvertBMI(Weight, Height);
                Refresh();
            }
        }

        private string _weight = "70";
        public string Weight
        {
            get { return _weight; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Any(x => char.IsLetter(x)))
                {
                    value = "70";
                }
                _weight = value;
                OnPropertyChanged("Weight");
                Console.WriteLine("Weight is equal {0}", value);
                MyConverter.ConvertBMI(Weight, Height);
                Refresh();
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
                Console.WriteLine("Stress is equal {0}", value);
                MyConverter.ConvertStress(value);
                Refresh();
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
                Console.WriteLine("Calories is equal {0}", value);
                MyConverter.ConvertCalories(Calories);
                Refresh();
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
                Console.WriteLine("Alcohol is equal {0}", value);
                MyConverter.ConvertAlcohol(Alcohol);
                Refresh();
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
                Console.WriteLine("Cigarettes is equal {0}", value);
                MyConverter.ConvertCigarettes(value);
                Refresh();
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
                Console.WriteLine("Job is equal {0}", value);
                MyConverter.ConvertJob(value);
                Refresh();
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
                Console.WriteLine("Activity is equal {0}", value);
                MyConverter.ConvertActivity(value);
                Refresh();
            }
        }
        private void Refresh()
        {
            Output = MyConverter.Calculate();
            if ((int)Output - Int32.Parse(Age) <= 0)
            {
                OutputLeft = 0;
            }
            else
            {
                OutputLeft = (int)Output - Int32.Parse(Age);
            }
            
        }
        public InputViewModel()
        {
            Output = MyConverter.Calculate();
        }
    }
}
