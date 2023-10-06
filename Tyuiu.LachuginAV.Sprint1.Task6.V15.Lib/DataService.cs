using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LachuginAV.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            {
               
                int k = 0; int m = 0;
                foreach (char i in value)
                {
                    if (Char.IsLetter(i))
                    {
                        k += 1;
                    }
                    if (Char.IsDigit(i))
                    {
                        m += 1;
                    }
                }
                int l = value.Length - k - m;
                if (l >= k)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
    }
}

