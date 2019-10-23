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
            for (int i = 1; i <= Branch.Count; i++)
            {
                decResult = decResult + (Convert.ToInt32(Branch[Branch.Count - i]) * Convert.ToInt32(Math.Pow(2, i-1)) );
            }
            return FindGame(decResult);
        }

       public string FindGame(int result)
        {
            switch(result)
            {
                case 0:
                    return "Final_Fantasy_VII.jpg";
                case 1:
                  return "Planescape_Torment.jpg";
                case 2:
                  return "Fallout_2.jpg";
                case 3:
                    return "XCOM_2.jpg";
                case 4:
                    return "Final_Fantasy_XV.jpg";
                case 5:
                    return "Dark_Souls.jpg";
                case 6:
                    return "Fallout_New_Vegas.jpg";
                case 7:
                    return "Mass_Effect.jpg";
                case 8:
                    return "Heroes_III.jpg";
                case 9:
                    return "Path_of_Exile.jpg";
                case 10:
                    return "Lost_Sector.jpg";
                case 11:
                    return "XCOM_Enemy_Unknown.jpg";
                case 12:
                    return "Guild_Wars_2.jpg";
                case 13:
                    return "Diablo_II.jpg";
                case 14:
                    return "Borderlands_II.jpg";
                case 15:
                    return "Fallout_76.jpg";
                default:
                    return "Error";
            }

            
        }
        
    }
}
