// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
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
            Console.WriteLine("Employee is Absent");
        }


    }
}