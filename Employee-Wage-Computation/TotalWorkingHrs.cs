using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    internal class TotalWorkingHrs
    {
        class program
        {
            public const int Part_Time = 1;
            public const int Full_Time = 2;
            public const int Emp_Rate_Per_Hrs = 20;
            public const int Num_Of_Working_Days = 2;
            public const int Max_Hrs_In_Month = 10;
            static void main(string[] args)
            {
                //Variables
                int empHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
                //Computation
                while(TotalEmpHrs <= Max_Hrs_In_Month && TotalWorkingDays < Num_Of_Working_Days)
                    {
                    TotalWorkingDays++;
                    Random random = new Random();
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
                    TotalEmpHrs += empHrs
                    Console.WriteLine("Day#:" + TotalWorkingDays + "Emp Hrs : " + empHrs);
                }
                int totalEmpWage = TotalEmpHrs * Emp_Rate_Per_Hrs;
                Console.WriteLine("Total emp Wage : " + totalEmpWage);
            }
        }
    }
}
