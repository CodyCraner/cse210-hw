using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> myNumbers = new List<int>{};
       Boolean complete = false;
       float total = 0;
       int biggestNumber = 0;
       float average = 0;
       Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
       
       while(complete == false)
       {
        Console.WriteLine("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());
        if(number == 0)
        {
            int length = myNumbers.Count();
             foreach(int instance in myNumbers)
                {
                    
                    total = total + instance;
                    average = total / length;

                    if (instance > biggestNumber)
                    {
                        biggestNumber = instance;

                    }


                }
            complete = true;
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average} ");
            Console.WriteLine($"The largest number is: {biggestNumber}");
        }
        else
        {
            myNumbers.Add(number);
        }

       }

      
    }
}