using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoringApp.Model;

namespace BoringApp.Static
{
    public static class RaceTitle
    {
        public static string RACE_HEADER = "WELCOME TO FAST & FURIOUS RACE 2018";
        
        public static string PrintHeader()
        {
            int lines = 0;
            string s = "";
            while (lines < 3)
            {
                lines++;
                if (lines % 2 == 0)
                    s += String.Format("{0}  {1}   {0}\n", String.Concat(Enumerable.Repeat("*", 30)), RaceTitle.RACE_HEADER);
                else
                {
                    s += String.Concat(Enumerable.Repeat("*", 100)) + "\n";
                }

            }
            return s;
        }

        public static string PrintCarTable(params Car[] cars)
        {
            string s = "";
            s += String.Concat(Enumerable.Repeat("#", 100)) + "\n";
            s += String.Format("Number of participants for {0} race: {1} Cars\n", null, cars.Length);
            foreach (Car car in cars)
                s += car + "\n";
            s += String.Concat(Enumerable.Repeat("#", 100)) + "\n";
            return s;
        }
    }
}
