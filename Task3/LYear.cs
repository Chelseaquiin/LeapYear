using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LYear
    {
        public int Year { get; set; }

        

        public void Years(int year)
        {
            int count = 0;
            while (count < 80)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0 && year % 400 == 0)
                    {

                    }
                    else if (year % 100 != 0)
                    {

                    }

                    Console.WriteLine(year);

                }
                year++;
                count++;
            }
        }
    }
    }

