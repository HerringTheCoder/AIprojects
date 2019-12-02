using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathTimer
{
    class Converter
    {
        public WeightedInput Input = new WeightedInput();
        private double BMI;
        public double Output { get; set; }
        
        public double Calculate()
        {
            Output = Input.Activity
                + Input.Alcohol
                + Input.Calories
                + Input.Cigarettes
                + Input.Gender               
                + Input.Job
                + Input.Stress
                + this.BMI;
            return Output;
        }
        public void ConvertActivity(string bindedInput)
        {
           Input.Activity = (bindedInput=="Niska") ? -5 : (bindedInput=="Przeciętna") ? 0 : 10 ;
        }
        public void ConvertAlcohol(string bindedInput)
        {
            Input.Alcohol = (bindedInput == "Niskie/brak") ?  0 : (bindedInput == "Średnie") ?  -5 :  -15;
        }
        public void ConvertCalories(string bindedInput)
        {
            Input.Alcohol = (bindedInput == "Średnia") ? 0 : -5;
        }
        public void ConvertCigarettes(string bindedInput)
        {
            Input.Cigarettes = (bindedInput == "Brak") ?  0 : (bindedInput == "5-10+") ? -5 : -15;
        }
        public void ConvertGender(string bindedInput)
        {
            Input.Gender = (bindedInput == "M") ? 74 : 82;
        }
        public void ConvertJob(string bindedInput)
        {
            Input.Job = (bindedInput == "Biurowa") ? -5 : (bindedInput == "Mieszana") ? +5 : 0;
        }
        public void ConvertStress(string bindedInput)
        {
            Input.Stress = (bindedInput == "Niski") ? 5 : (bindedInput == "Przeciętny") ? 0 : -5;
        }
        public void ConvertBMI(string Weight, string Height)
        {
            this.BMI = Double.Parse(Weight) / Math.Pow(Double.Parse(Height) / 100, 2);            
            this.BMI = (BMI > 40) ? -30 : (BMI > 30) ? -15 : (BMI >= 25) ? -5 : (BMI > 19) ? 5 : -5;  
        }
    }
}
