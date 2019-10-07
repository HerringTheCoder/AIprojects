using System;
using System.Collections.Generic;


namespace Pick_an_RPG
{
    public class Tree
    {
        public List<bool> Branch = new List<bool>();
        public string Result()
        {
            int decResult=0;
            for (int i = 0; i > Branch.Count; i++)
            {
                decResult = +Convert.ToInt32(Branch[i - 1]) * Convert.ToInt32(Math.Pow(2, i));
            }
            return FindGame(decResult);
        }

       public string FindGame(int result)
        {
            switch(result)
            {
                case 0:
                    return "";
                case 1:
                  return "";
                case 2:
                  return "";
                case 3:
                    return "";
                case 4:
                    return "";
                case 5:
                    return "";
                case 6:
                    return "";
                case 7:
                    return "";
                case 8:
                    return "";
                case 9:
                    return "";
                case 10:
                    return "";
                case 11:
                    return "";
                case 12:
                    return "";
                case 13:
                    return "";
                case 14:
                    return "";
                case 15:
                    return "";
                case 16:
                    return "";
                default:
                    return "Error";
            }
            
        }

    }
}
