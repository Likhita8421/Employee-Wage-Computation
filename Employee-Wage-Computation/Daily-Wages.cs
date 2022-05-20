class Program
{
    static void Main()
    {
        //Constants
        int Full_Time = 1;
        int Emp_Rate_Per_Hour = 20;
        //Variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        //Computation
        int empCheck = random.Next(0, 2);
        if (empCheck == Full_Time)
        {
            empHrs = 8;
        }
        else
        {
            empHrs = 0;
        }
        empWage = empHrs * Emp_Rate_Per_Hour;
        Console.WriteLine("Emp Wage : " + empWage);    
    }
}