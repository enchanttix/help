using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Program
    {
        public static Double pow(double n)
        {
            return n * n;
        }

        public static Boolean trueFalse(int n)
        {
            if(n%2==0)
            {
                return true;
            }
            else return false;
        }
        public static object nullOrNull(int n) 
        {
            object a;
            if (n % 2 == 0)
            {
                a = n;
                return a;
            }
            else
            {
                a = null;
                return a;
            }
        }
        public static string srt()
        {
            string stroka = "miau";
            return stroka;
        }
        static void Main(string[] args)
        {
        }
    }
}
