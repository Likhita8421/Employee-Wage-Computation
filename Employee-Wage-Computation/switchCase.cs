using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    internal class switchCase
    {
        class Program
        {
            public const int Part_Time = 1;
            public const int Full_Time = 2;
            public const int Emp_Rate_Per_Hour = 20;
            static void Main(string[] args)
            {
                //Variables
                int empHrs = 0;
                int empWage = 0;
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Part_Time:
                        empHrs = 4;
                        break;
                    case Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                Console.WriteLine("Emp Wage : " + empWage);
            }
        }
    }
}
