class Program
{
    static void Main()
    {
        //Constants
        int Full_Time = 1;
        Random random = new Random();
        //Computation
        int empCheck = random.Next(0, 2);
        if (empCheck == Full_Time)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is absent");
        }
    
    }
}